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

    public class Gym
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stage")]
        public int Stage { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("dexterity")]
        public int Dexterity { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }
}
