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
        [JsonConverter(typeof(TornListConverter<Stock>))]
        public List<Stock> Stocks { get; set; }

        [JsonProperty("stats")]
        public Stats CityStats { get; set; }

        [JsonProperty("honors")]
        [JsonConverter(typeof(TornListConverter<Honor>))]
        public List<Honor> Honors { get; set; }

        [JsonProperty("medals")]
        [JsonConverter(typeof(TornListConverter<Medal>))]
        public List<Medal> Medals { get; set; }

        [JsonProperty("gyms")]
        [JsonConverter(typeof(TornListConverter<Gym>))]
        public List<Gym> Gyms { get; set; }

        [JsonProperty("items")]
        [JsonConverter(typeof(TornListConverter<Item>))]
        public List<Item> Items { get; set; }

        [JsonProperty("education")]
        [JsonConverter(typeof(TornListConverter<Education>))]
        public List<Education> Educations { get; set; }

        [JsonProperty("organisedcrimes")]
        [JsonConverter(typeof(TornListConverter<OrganizedCrime>))]
        public List<OrganizedCrime> OrganizedCrimes { get; set; }

        [JsonProperty("properties")]
        [JsonConverter(typeof(TornListConverter<PropertyType>))]
        public List<PropertyType> Properties { get; set; }

        [JsonProperty("companies")]
        [JsonConverter(typeof(TornListConverter<CompanyType>))]
        public List<CompanyType> Companies { get; set; }

        //// TODO: Fix this to fit into new List schema
        [JsonProperty("factiontree")]
        public Dictionary<string, Dictionary<string, FactionUpgrade>> FactionUpgradeTree { get; set; }

        [JsonProperty("territory")]
        [JsonConverter(typeof(TornListConverter<Territory>))]
        public List<Territory> Territories { get; set; }

        [JsonProperty("rackets")]
        [JsonConverter(typeof(TornListConverter<Racket>))]
        public List<Racket> Rackets { get; set; }

        [JsonProperty("bank")]
        public BankRates BankRates { get; set; }
    }
}
