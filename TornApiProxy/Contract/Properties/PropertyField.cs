/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2019  TornCityPro
  
  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.
  
  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.
  
  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
************************************************************************/

﻿namespace TornApiProxy.Fields
{
    /// <summary>
    /// The class which holds all the queryable fields for the properties endpoint
    /// </summary>
    public class PropertyField : ApiField
    {
        protected PropertyField(string fieldName) : base(fieldName) { }

        /// <summary>
        /// Properties only has one selection aside from timestamp "property"
        /// </summary>
        public static readonly PropertyField Property = new PropertyField("property");
        public static readonly PropertyField Lookup = new PropertyField("lookup");
        public static readonly PropertyField Timestamp = new PropertyField("timestamp");
    }
}
