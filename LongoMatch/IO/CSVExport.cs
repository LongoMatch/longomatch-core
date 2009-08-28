// CSVExport.cs
//
//  Copyright (C) 2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//

using System;
using System.IO;
using System.Collections.Generic;
using LongoMatch.DB;
using LongoMatch.TimeNodes;

namespace LongoMatch.IO
{
	
	
	public class CSVExport
	{
		string outputFile;
		Project project;
		
		#region Constructors 
		public CSVExport(Project project,string outputFile)
		{
			this.project = project;
			this.outputFile = outputFile;
		}
		#endregion
		
		#region Public methods
		public void WriteToFile(){
			List<List<MediaTimeNode>> list;
			string[] sectionNames;
			TextWriter tx;
			
			tx = new StreamWriter(outputFile);			
			list = project.GetDataArray();
			sectionNames = project.GetSectionsNames();
			
			tx.WriteLine("Section;Name;Team;StartTime;StopTime");
			
			for (int i=0; i<list.Count; i++){
				string sectionName = sectionNames[i];
				foreach (MediaTimeNode tn in list[i]){
					tx.WriteLine("\""+sectionName+"\";\""+tn.Name+"\";\""+tn.Team+"\";\""+tn.Start.ToMSecondsString()+"\";\""+tn.Stop.ToMSecondsString()+"\"");
				}						
			}			
			tx.Close();
		}
		#endregion
	}
}
