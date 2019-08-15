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

﻿namespace TornApiProxy.Contract.Properties
{
    using Newtonsoft.Json;
    using Shared;

    public class PropertyPropertyBag : PropertyBagBase
    {
        [JsonProperty("property")]
        public PropertyInfo Info { get; set; }
    }

    public class PropertyInfo
    {
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("property_type")]
        public short PropertyType { get; set; }

        [JsonProperty("happy")]
        public int Happy { get; set; }

        [JsonProperty("upgrades")]
        public string[] Upgrades { get; set; }

        [JsonProperty("staff")]
        public string[] Staff { get; set; }

        [JsonProperty("rented")]
        public RentObject Rented { get; set; }

        [JsonProperty("users_living")]
        public string UsersLiving { get; set; }
    }
    
    public class RentObject
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("days_left")]
        public byte? DaysLeft { get; set; }

        [JsonProperty("total_cost")]
        public int? TotalCost { get; set; }

        [JsonProperty("cost_per_day")]
        public int? CostPerDay { get; set; }
    }
}
