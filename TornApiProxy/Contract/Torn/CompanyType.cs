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
    using System.Collections.Generic;

    public class CompanyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public long Cost { get; set; }

        [JsonProperty("default_employees")]
        public int DefaultEmployeeCount { get; set; }

        [JsonProperty("positions")]
        public Dictionary<string, CompanyPosition> Positions { get; set; }

        [JsonProperty("stock")]
        public Dictionary<string, CompanyStock> Stock { get; set; }

        [JsonProperty("specials")]
        public Dictionary<string, CompanySpecial> Specials { get; set; }
    }

    public class CompanyPosition
    {
        [JsonProperty("man_required")]
        public int ManualLaborRequired { get; set; }

        [JsonProperty("int_required")]
        public int IntelligenceRequired { get; set; }

        [JsonProperty("end_required")]
        public int EnduranceRequired { get; set; }

        [JsonProperty("man_gain")]
        public int ManualLaborGain { get; set; }

        [JsonProperty("int_gain")]
        public int IntelligenceGain { get; set; }

        [JsonProperty("end_gain")]
        public int EnduranceGain { get; set; }

        [JsonProperty("special_ability")]
        public string SpecialAbility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CompanySpecial
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("rating_required")]
        public int RatingRequired { get; set; }
    }

    public class CompanyStock
    {
        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("rrp")]
        public int RecommendedRetailPrice { get; set; }
    }
}
