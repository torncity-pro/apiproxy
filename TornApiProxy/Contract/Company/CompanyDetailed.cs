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
    /// Detailed company profile
    /// </summary>
    public class CompanyDetailed
    {
        /// <summary>
        /// The company id
        /// </summary>
        [JsonProperty("ID")]
        public int CompanyId { get; set; }

        /// <summary>
        /// The amount of money in the company bank
        /// </summary>
        [JsonProperty("company_bank")]
        public long CompanyBank { get; set; }

        /// <summary>
        /// The % popularity of the company
        /// </summary>
        [JsonProperty("popularity")]
        public short Popularity { get; set; }

        /// <summary>
        /// The % effeciency of the company
        /// </summary>
        [JsonProperty("efficiency")]
        public short Efficiency { get; set; }

        /// <summary>
        /// The % cleanliness of the company
        /// </summary>
        [JsonProperty("environment")]
        public short Environment { get; set; }

        /// <summary>
        /// The number of trains the company has (20 max)
        /// </summary>
        [JsonProperty("trains_available")]
        public short TrainsAvailable { get; set; }

        /// <summary>
        /// The amount of money spent daily on advertising
        /// </summary>
        [JsonProperty("advertising_budget")]
        public int AdvertisingBudget { get; set; }

        /// <summary>
        /// The object which has the company upgrades that have been purchased
        /// </summary>
        [JsonProperty("upgrades")]
        public CompanyUpgrades Upgrades { get; set; }
    }

    /// <summary>
    /// A class to hold the company upgrades
    /// </summary>
    public class CompanyUpgrades
    {
        /// <summary>
        /// The size of the company
        /// </summary>
        [JsonProperty("company_size")]
        public byte CompanySize { get; set; }

        /// <summary>
        /// The current size of the staff room
        /// </summary>
        [JsonProperty("staffroom_size")]
        public string StaffroomSize { get; set; }

        /// <summary>
        /// The string representation  of the storeroom size for products the company sells
        /// </summary>
        [JsonProperty("storage_size")]
        public string StorageSize { get; set; }

        /// <summary>
        /// The amount of products the company can store
        /// </summary>
        [JsonProperty("storage_space")]
        public int StorageSpace { get; set; }
    }
}
