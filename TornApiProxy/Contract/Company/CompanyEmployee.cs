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
    
    public class CompanyEmployee
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("days_employed")]
        public ushort DaysEmployed { get; set; }

        [JsonProperty("wage")]
        public uint Wage { get; set; }

        [JsonProperty("effectiveness")]
        public byte Effectiveness { get; set; }

        [JsonProperty("manual_labor")]
        public uint Manual_labor { get; set; }

        [JsonProperty("intelligence")]
        public uint Intelligence { get; set; }

        [JsonProperty("endurance")]
        public uint Endurance { get; set; }
    }
}
