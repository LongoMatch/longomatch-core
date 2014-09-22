//
//  Copyright (C) 2013 Andoni Morales Alastruey
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
using Mono.Unix;

namespace LongoMatch.Core.Common
{
	public class DBLockedException: Exception
	{
		public DBLockedException (Exception innerException):
			base (Catalog.GetString("Database locked:" + innerException.Message),
			      innerException)
		{
		}
	}
	
	public class UnknownDBErrorException: Exception
	{
		public UnknownDBErrorException (Exception innerException):
			base (Catalog.GetString("Unknown database error:" + innerException),
			      innerException)
		{
		}
	}
	
	public class SubstitutionException: Exception {
		public SubstitutionException (string error): base (error)
		{
		}
	}
}

