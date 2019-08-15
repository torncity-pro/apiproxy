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

    public class CompanyDetailed
    {
        [JsonProperty("ID")]
        public int CompanyId { get; set; }

        [JsonProperty("company_bank")]
        public int CompanyBank { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("efficiency")]
        public int Efficiency { get; set; }

        [JsonProperty("environment")]
        public int Environment { get; set; }

        [JsonProperty("trains_available")]
        public int TrainsAvailable { get; set; }

        [JsonProperty("advertising_budget")]
        public int AdvertisingBudget { get; set; }

        [JsonProperty("upgrades")]
        public CompanyUpgrades Upgrades { get; set; }
    }

    public class CompanyUpgrades
    {
        [JsonProperty("company_size")]
        public byte CompanySize { get; set; }

        [JsonProperty("staffroom_size")]
        public string StaffroomSize { get; set; }

        [JsonProperty("storage_size")]
        public string StorageSize { get; set; }

        [JsonProperty("storage_space")]
        public int StorageSpace { get; set; }
    }
}
