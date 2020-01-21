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

﻿namespace TornApiProxy.Contract.Torn
{
    using Newtonsoft.Json;
    using Shared;
    using System.Collections.Generic;

    public class Results
    {        
        [JsonProperty("perk")]
        public List<string> Perk { get; set; }

        [JsonProperty("manual_labor")]
        public List<string> ManualLabor { get; set; }

        [JsonProperty("intelligence")]
        public List<string> Intelligence { get; set; }

        [JsonProperty("endurance")]
        public List<string> Endurance { get; set; }
    }

    public class Education : ApiListItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("money_cost")]
        public int MoneyCost { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }

        [JsonProperty("prerequisites")]
        public List<string> Prerequisites { get; set; }
    }
}
