//
//  Copyright (C) 2014 Andoni Morales Alastruey
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using System.Collections.Generic;
using System.Linq;
using LongoMatch.Core.Store;
using LongoMatch.Drawing.CanvasObjects;
using LongoMatch.Core.Common;
using LongoMatch.Core.Handlers;
using LongoMatch.Core.Interfaces.Drawing;
using LongoMatch.Core.Store.Drawables;

namespace LongoMatch.Drawing.Widgets
{
	public class PlaysTimeline: SelectionCanvas
	{
	
		public event ShowTimelineMenuHandler ShowMenuEvent;
		public event ShowTimersMenuHandler ShowTimersMenuEvent;
		public event ShowTimerMenuHandler ShowTimerMenuEvent;

		Project project;
		EventsFilter playsFilter;
		double secondsPerPixel;
		Time duration;
		TimelineEvent loadedEvent;
		TimerTimeline periodsTimeline;
		Dictionary<TimelineObject, object> timelineToFilter;
		Dictionary<EventType, CategoryTimeline> eventsTimelines;

		public PlaysTimeline (IWidget widget): base(widget)
		{
			eventsTimelines = new Dictionary<EventType, CategoryTimeline> ();
			timelineToFilter = new Dictionary<TimelineObject, object> ();
			secondsPerPixel = 0.1;
			Accuracy = Constants.TIMELINE_ACCURACY;
			SelectionMode = MultiSelectionMode.MultipleWithModifier;
			SingleSelectionObjects.Add (typeof (TimerTimeNodeObject));
		}

		protected override void Dispose (bool disposing)
		{
			foreach (CategoryTimeline ct in eventsTimelines.Values) {
				ct.Dispose ();
			}
			base.Dispose (disposing);
		}

		public void LoadProject (Project project, EventsFilter filter)
		{
			int height;

			this.project = project;
			ClearObjects ();
			eventsTimelines.Clear ();
			duration = project.Description.FileSet.Duration;
			height = project.EventTypes.Count * StyleConf.TimelineCategoryHeight;
			widget.Height = height;
			playsFilter = filter;
			FillCanvas ();
			filter.FilterUpdated += UpdateVisibleCategories;
		}

		public Time CurrentTime {
			set {
				foreach (TimelineObject tl in Objects) {
					tl.CurrentTime = value;
				}
			}
		}

		public double SecondsPerPixel {
			set {
				secondsPerPixel = value;
				Update ();
			}
			get {
				return secondsPerPixel;
			}
		}

		public void LoadPlay (TimelineEvent play)
		{
			if (play == this.loadedEvent) {
				return;
			}

			foreach (CategoryTimeline tl in eventsTimelines.Values) {
				PlayObject loaded = tl.Load (play);
				if (loaded != null) {
					ClearSelection ();
					UpdateSelection (new Selection (loaded, SelectionPosition.All, 0), false);
					break;
				}
			}
		}

		public void AddPlay (TimelineEvent play)
		{
			eventsTimelines [play.EventType].AddPlay (play);
		}

		public void RemoveTimers (List<TimeNode> nodes)
		{
			foreach (TimerTimeline tl in Objects.OfType<TimerTimeline>()) {
				foreach (TimeNode node in nodes) {
					tl.RemoveNode (node);
				}
			}
			widget.ReDraw ();
		}

		public void RemovePlays (List<TimelineEvent> plays)
		{
			foreach (TimelineEvent p in plays) {
				eventsTimelines [p.EventType].RemoveNode (p);
				Selections.RemoveAll (s => (s.Drawable as PlayObject).Play == p);
			}
		}

		void Update ()
		{
			double width = duration.Seconds / SecondsPerPixel;
			widget.Width = width + 10;
			foreach (TimelineObject tl in Objects) {
				tl.Width = width + 10;
				tl.SecondsPerPixel = SecondsPerPixel;
			}
		}

		void AddTimeline (TimelineObject tl, object filter)
		{
			AddObject (tl);
			timelineToFilter[tl] = filter;
			if (tl is CategoryTimeline) {
				eventsTimelines [filter as EventType] = tl as CategoryTimeline;
			} 
		}

		void FillCanvas ()
		{
			TimelineObject tl;
			int i = 0;

			tl = new TimerTimeline (project.Periods.Select (p => p as Timer).ToList(),
			                        true, true, false, duration,
			                        i * StyleConf.TimelineCategoryHeight,
			                        Utils.ColorForRow (i), Config.Style.PaletteBackgroundDark);
			AddTimeline (tl, null);
			periodsTimeline = tl as TimerTimeline;
			i++;

			foreach (Timer t in project.Timers) {
				tl = new TimerTimeline (new List<Timer> {t}, false, true, false, duration,
				i * StyleConf.TimelineCategoryHeight,
				Utils.ColorForRow (i), Config.Style.PaletteBackgroundDark);
				AddTimeline (tl, t);
			}
			                        
			foreach (EventType type in project.EventTypes) {
				tl = new CategoryTimeline (project.EventsByType (type), duration,
				                           i * StyleConf.TimelineCategoryHeight,
				                           Utils.ColorForRow (i), playsFilter);
				AddTimeline (tl, type);
				i++;
			}
			UpdateVisibleCategories ();
			Update ();
		}

		void UpdateVisibleCategories ()
		{
			int i = 0;
			foreach (TimelineObject timeline in Objects) {
				if (playsFilter.IsVisible (timelineToFilter[timeline])) {
					timeline.OffsetY = i * timeline.Height;
					timeline.Visible = true;
					timeline.BackgroundColor = Utils.ColorForRow (i);
					i++;
				} else {
					timeline.Visible = false;
				}
			}
			widget.ReDraw ();
		}

		void ShowTimersMenu (Point coords)
		{
			if (coords.Y >= periodsTimeline.OffsetY &&
				coords.Y < periodsTimeline.OffsetY + periodsTimeline.Height) {
				Timer t = Selections.FirstOrDefault.Select (p => (p.Drawable as TimerTimeNodeObject).Timer);
				if (ShowTimerMenuEvent != nul) {
					ShowTimerMenuEvent (t, Utils.PosToTime (coords, SecondsPerPixel));
				}
			} else {
				List<TimeNode> nodes = Selections.Select (p => (p.Drawable as TimeNodeObject).TimeNode).ToList ();
				if (nodes.Count > 0 && ShowTimersMenuEvent != null) {
					ShowTimersMenuEvent (nodes);
				}
			}
		}

		void ShowPlaysMenu (Point coords) {
			EventType ev = null;
			List<TimelineEvent> plays;
			
			plays = Selections.Select (p => (p.Drawable as PlayObject).Play).ToList ();
			
			foreach (EventType evType in eventsTimelines.Keys) {
				TimelineObject tl;

				tl = eventsTimelines [evType];
				if (!tl.Visible)
					continue;
				if (coords.Y >= tl.OffsetY && coords.Y < tl.OffsetY + tl.Height) {
					ev = evType;
					break;
				}
			}
			
			if ((ev != null || plays.Count > 0) && ShowMenuEvent != null) {
				ShowMenuEvent (plays, ev, Utils.PosToTime (coords, SecondsPerPixel));
			}
		}

		protected override void SelectionChanged (List<Selection> selections)
		{
			TimelineEvent ev = null;
			if (selections.Count > 0) {
				CanvasObject d = selections.Last ().Drawable as CanvasObject;
				if (d is PlayObject) {
					ev = (d as PlayObject).Play;
					loadedEvent = ev;
				}
			}
			Config.EventsBroker.EmitLoadEvent (ev);
		}

		protected override void StartMove (Selection sel)
		{
			if (sel == null)
				return;

			if (sel.Position != SelectionPosition.All) {
				widget.SetCursor (CursorType.DoubleArrow);
			}
		}

		protected override void StopMove ()
		{
			widget.SetCursor (CursorType.Arrow);
		}

		protected override void ShowMenu (Point coords)
		{
			if (Selections.Count > 0) {
				if (Selections.Last ().Drawable is PlayObject) {
					ShowPlaysMenu (coords);
				} else {
					ShowTimersMenu (coords);
				}
			}
		}

		protected override void SelectionMoved (Selection sel)
		{
			Time moveTime;
			CanvasObject co;
			TimelineEvent play;
			
			co = (sel.Drawable as CanvasObject);
			
			if (co is PlayObject) {
				play = (co as PlayObject).Play;
				
				if (sel.Position == SelectionPosition.Right) {
					moveTime = play.Stop;
				} else {
					moveTime = play.Start;
				}
				Config.EventsBroker.EmitTimeNodeChanged (play, moveTime);
			} else if (co is TimeNodeObject) {
				TimeNode to = (co as TimeNodeObject).TimeNode;
				
				if (sel.Position == SelectionPosition.Right) {
					moveTime = to.Stop;
				} else {
					moveTime = to.Start;
				}
				Config.EventsBroker.EmitSeekEvent (moveTime, true);
			}
		}

		public override void Draw (IContext context, Area area)
		{
			tk.Context = context;
			tk.Begin ();
			tk.Clear (Config.Style.PaletteBackground);
			tk.End ();
			base.Draw (context, area);
		}
	}
}

