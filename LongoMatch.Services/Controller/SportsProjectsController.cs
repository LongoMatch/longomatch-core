﻿//
//  Copyright (C) 2016 Fluendo S.A.
//
//
using System;
using System.Threading.Tasks;
using LongoMatch.Core.Events;
using LongoMatch.Core.Store;
using LongoMatch.Core.ViewModel;
using LongoMatch.Services.State;
using VAS.Core.Events;
using VAS.Core.MVVMC;
using VAS.Services.Controller;
using VAS.Services.State;

namespace LongoMatch.Services.Controller
{

	/// <summary>
	/// Controller for sports projects.
	/// </summary>
	[ControllerAttribute (ProjectsManagerState.NAME)]
	public class SportsProjectsController : ProjectsController<LMProject, LMProjectVM>
	{
		public override async Task Start ()
		{
			await base.Start ();
			App.Current.EventsBroker.SubscribeAsync<ResyncEvent> (HandleResync);
			App.Current.EventsBroker.Subscribe<OpenEvent<LMProject>> (HandleOpen);
		}

		public override async Task Stop ()
		{
			await base.Stop ();
			App.Current.EventsBroker.UnsubscribeAsync<ResyncEvent> (HandleResync);
			App.Current.EventsBroker.Unsubscribe<OpenEvent<LMProject>> (HandleOpen);
		}

		async Task HandleResync (ResyncEvent ev)
		{
			if (!ViewModel.LoadedProject.FileSet.Model.CheckFiles ()) {
				// Show message in order to load video.
				if (!App.Current.GUIToolkit.SelectMediaFiles (ViewModel.LoadedProject.FileSet.Model)) {
					return;
				}
			}

			ViewModel.LoadedProject.Model.Load ();
			await App.Current.StateController.MoveTo (CameraSynchronizationEditorState.NAME, ViewModel.LoadedProject);
			ViewModel.SaveCommand.EmitCanExecuteChanged ();
		}

		void HandleOpen (OpenEvent<LMProject> arg)
		{
			if (ViewModel.LoadedProject != null) {
				LMStateHelper.OpenProject (ViewModel.LoadedProject);
			}
		}
	}
}

