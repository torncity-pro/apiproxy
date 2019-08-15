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

    public class OrganizedCrime
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("min_cash")]
        public int MinCash { get; set; }

        [JsonProperty("max_cash")]
        public int MaxCash { get; set; }

        [JsonProperty("min_respect")]
        public int MinRespect { get; set; }

        [JsonProperty("max_respect")]
        public int MaxRespect { get; set; }
    }
}
