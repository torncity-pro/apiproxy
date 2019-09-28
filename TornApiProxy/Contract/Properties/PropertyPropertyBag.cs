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

    /// <summary>
    /// Represents an object with all possible root level keys that can be returned from the (real estate) property api url
    /// </summary>
    public class PropertyPropertyBag : PropertyBagBase
    {
        /// <summary>
        /// The info on the property queried
        /// </summary>
        [JsonProperty("property")]
        public PropertyInfo Info { get; set; }
    }

    /// <summary>
    /// A subclass to encapsulate the (real estate) property attributes
    /// </summary>
    public class PropertyInfo
    {
        /// <summary>
        /// The player id who owns this property
        /// </summary>
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        /// <summary>
        /// The type of property this is
        /// </summary>
        [JsonProperty("property_type")]
        public short PropertyType { get; set; }

        /// <summary>
        /// How much happy does the property give. This includes current staff bonuses.
        /// </summary>
        [JsonProperty("happy")]
        public int Happy { get; set; }

        /// <summary>
        /// The list of upgrades bought for this property.
        /// </summary>
        [JsonProperty("upgrades")]
        public string[] Upgrades { get; set; }

        /// <summary>
        /// The list of staff working on this property.
        /// </summary>
        [JsonProperty("staff")]
        public string[] Staff { get; set; }

        /// <summary>
        /// The object which holds rental information
        /// </summary>
        [JsonProperty("rented")]
        public RentObject Rented { get; set; }

        /// <summary>
        /// The users living in this property. Comma separated. One or two players max currently.
        /// </summary>
        [JsonProperty("users_living")]
        public string UsersLiving { get; set; }
    }
    
    /// <summary>
    /// An object to encapsulate rental information
    /// </summary>
    public class RentObject
    {
        /// <summary>
        /// The user renting this property
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// The number of days remaining on the rental
        /// </summary>
        [JsonProperty("days_left")]
        public byte? DaysLeft { get; set; }

        /// <summary>
        /// How much the rental cost in total
        /// </summary>
        [JsonProperty("total_cost")]
        public int? TotalCost { get; set; }

        /// <summary>
        /// How much per day the rental cost
        /// </summary>
        [JsonProperty("cost_per_day")]
        public int? CostPerDay { get; set; }
    }
}
