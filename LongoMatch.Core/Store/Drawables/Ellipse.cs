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
using Newtonsoft.Json;
using LongoMatch.Common;

namespace LongoMatch.Store.Drawables
{
	public class Ellipse: Drawable
	{
		public Ellipse ()
		{
		}

		public Ellipse (Point center, double axisX, double axisY)
		{
			Center = center;
			AxisX = axisX;
			AxisY = axisY;
		}
		
		public Point Center {
			get;
			set;
		}
		
		public double AxisX {
			get;
			set;
		}
		
		public double AxisY {
			get;
			set;
		}
		
		[JsonIgnore]
		public Point Top {
			get {
				return new Point (Center.X, Center.Y + AxisY);
			}
		}
		
		[JsonIgnore]
		public Point Bottom {
			get {
				return new Point (Center.X, Center.Y - AxisY);
			}
		}
		
		[JsonIgnore]
		public Point Left {
			get {
				return new Point (Center.X - AxisX, Center.Y);
			}
		}
		
		public Point Right {
			get {
				return new Point (Center.X + AxisX, Center.Y);
			}
		}

		public override Selection GetSelection (Point p, double pr=0.05) {
			double d;
			
			if (MatchPoint (Top, p, pr, out d)) {
				return new Selection (this, SelectionPosition.Top, d);
			} else if (MatchPoint (Bottom, p, pr, out d)) {
				return new Selection (this, SelectionPosition.Bottom, d);
			} else if (MatchPoint (Left, p, pr, out d)) {
				return new Selection (this, SelectionPosition.Left, d);
			} else if (MatchPoint (Right, p, pr, out d)) {
				return new Selection (this, SelectionPosition.Right, d);
			} else {
				/* Ellipse equation */
				double a = Math.Pow (p.X - Center.X, 2) / Math.Pow (AxisX, 2);
				double b = Math.Pow (p.Y - Center.Y, 2) / Math.Pow (AxisY, 2);
				if ((a + b) <= 1) {
					return new Selection (this, SelectionPosition.All, p.Distance (Center));
				} else {
					return new Selection (this, SelectionPosition.None);
				}
			}
		}
		
		public override void Move (Selection sel, Point p, Point moveStart) {
			switch (sel.Position) {
			case SelectionPosition.Top:
			case SelectionPosition.Bottom: {
				AxisY = Math.Abs (p.Y - Center.Y);
				break;
			}
			case SelectionPosition.Left:
			case SelectionPosition.Right: {
				AxisX = Math.Abs (p.X - Center.X);
				break;
			}
			case SelectionPosition.All: {
				Center.X += p.X - moveStart.X;
				Center.Y += p.Y - moveStart.Y;
				break;
			}
			default:
				throw new Exception ("Unsupported move for line:  " + sel.Position);
			}
		}
	}
}

