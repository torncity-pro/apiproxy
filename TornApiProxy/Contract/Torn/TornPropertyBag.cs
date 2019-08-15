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

    public class TornPropertyBag : PropertyBagBase
    {
        [JsonProperty("stocks")]
        public Dictionary<string, Stock> Stocks { get; set; }

        [JsonProperty("stats")]
        public Stats CityStats { get; set; }

        [JsonProperty("honors")]
        public Dictionary<string, Honor> Honors { get; set; }

        [JsonProperty("medals")]
        public Dictionary<string, Medal> Medals { get; set; }

        [JsonProperty("gyms")]
        public Dictionary<string, Gym> Gyms { get; set; }

        [JsonProperty("items")]
        public Dictionary<string, Item> Items { get; set; }

        [JsonProperty("education")]
        public Dictionary<string, Education> Educations { get; set; }

        [JsonProperty("organisedcrimes")]
        public Dictionary<string, OrganizedCrime> OrganizedCrimes { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, PropertyType> Properties { get; set; }

        [JsonProperty("companies")]
        public Dictionary<string, CompanyType> Companies { get; set; }

        [JsonProperty("factiontree")]
        public Dictionary<string, Dictionary<string, FactionUpgrade>> FactionUpgradeTree { get; set; }

        [JsonProperty("territory")]
        public Dictionary<string, Territory> Territories { get; set; }

        [JsonProperty("rackets")]
        public Dictionary<string, Racket> Rackets { get; set; }
    }
}
