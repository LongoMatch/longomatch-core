﻿//
//  Copyright (C) 2015 Fluendo S.A.
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
using System.IO;
using LongoMatch;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Interfaces.GUI;
using LongoMatch.Core.Interfaces.Multimedia;
using LongoMatch.DB;
using LongoMatch.Services;
using Moq;
using NUnit.Framework;

namespace Tests.Integration
{
	[TestFixture]
	public class TestDatabaseMigration
	{
		[Test]
		public void TestMigatingOldDatabase ()
		{
			string tmpPath = Path.Combine (Path.GetTempPath (), Path.GetRandomFileName ());
			string homePath = Path.Combine (tmpPath, "LongoMatch");
			string dbPath = Path.Combine (homePath, "db");
			string lmdbPath = Path.Combine (dbPath, "longomatch.ldb");
			string teamsPath = Path.Combine (dbPath, "teams");
			string dashboardsPath = Path.Combine (dbPath, "analysis");

			Directory.CreateDirectory (tmpPath);
			Directory.CreateDirectory (homePath);
			Directory.CreateDirectory (dbPath);
			Directory.CreateDirectory (lmdbPath);
			Directory.CreateDirectory (teamsPath);
			Directory.CreateDirectory (dashboardsPath);

			Utils.SaveResource ("spain.ltt", teamsPath);
			Utils.SaveResource ("france.ltt", teamsPath);
			Utils.SaveResource ("basket.lct", dashboardsPath);
			Utils.SaveResource ("spain_france_test.lgm", lmdbPath);

			Directory.CreateDirectory (tmpPath);
			Environment.SetEnvironmentVariable ("LONGOMATCH_HOME", tmpPath);
			Environment.SetEnvironmentVariable ("LGM_UNINSTALLED", "1");
			CoreServices.Init ();
			var guiToolkitMock = new Mock<IGUIToolkit> ();
			guiToolkitMock.Setup (g => g.RenderingStateBar).Returns (() => new Mock<IRenderingStateBar> ().Object);
			Config.EventsBroker = new EventsBroker ();
			CoreServices.Start (guiToolkitMock.Object, Mock.Of<IMultimediaToolkit> ());

			Assert.AreEqual (0, Config.DatabaseManager.ActiveDB.Count);
			Assert.AreEqual (2, Config.TeamTemplatesProvider.Templates.Count);
			Assert.AreEqual (1, Config.CategoriesTemplatesProvider.Templates.Count);

			DatabaseMigration dbMigration = new DatabaseMigration (Mock.Of<IProgressReport> ());
			dbMigration.Start ();

			Assert.AreEqual (1, Config.DatabaseManager.ActiveDB.Count);
			Assert.AreEqual (4, Config.TeamTemplatesProvider.Templates.Count);
			Assert.AreEqual (2, Config.CategoriesTemplatesProvider.Templates.Count);

			Assert.IsTrue (File.Exists (Path.Combine (dbPath, "templates", "backup", "spain.ltt")));
			Assert.IsTrue (File.Exists (Path.Combine (dbPath, "templates", "backup", "france.ltt")));
			Assert.IsTrue (File.Exists (Path.Combine (dbPath, "templates", "backup", "basket.lct")));
			Assert.IsTrue (File.Exists (Path.Combine (dbPath, "old", "longomatch.ldb", "spain_france_test.lgm")));
		}
	}
}
