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
    using Shared;
    using System.Collections.Generic;

    public class CompanyPropertyBag : PropertyBagBase
    {
        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("company_detailed")]
        public CompanyDetailed CompanyDetailed { get; set; }

        [JsonProperty("company_stock")]
        public Dictionary<string, CompanyStock> CompanyStock { get; set; }

        [JsonProperty("company_employees")]
        public Dictionary<string, CompanyEmployee> CompanyEmployees { get; set; }

        [JsonProperty("news")]
        public Dictionary<string, News> News { get; set; }
    }
}
