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

﻿namespace TornApiProxy.Contract.Company
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// A company employee
    /// </summary>
    public class CompanyEmployee
    {
        /// <summary>
        /// The position of the employee
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// The number of days the employee has been with the company
        /// </summary>
        [JsonProperty("days_employed")]
        public short DaysEmployed { get; set; }

        /// <summary>
        /// The employees wage $25,000,000 max
        /// </summary>
        [JsonProperty("wage")]
        public int Wage { get; set; }

        /// <summary>
        /// The employees effectiveness out of 5
        /// </summary>
        [JsonProperty("effectiveness")]
        public byte Effectiveness { get; set; }

        /// <summary>
        /// The employees manual labor stat
        /// </summary>
        [JsonProperty("manual_labor")]
        public int ManualLabor { get; set; }

        /// <summary>
        /// The employees intelligence stat
        /// </summary>
        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        /// <summary>
        /// The employees endurace stat
        /// </summary>
        [JsonProperty("endurance")]
        public int Endurance { get; set; }
    }
}
