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

    /// <summary>
    /// A super object which has deserialization for all fields returned from the api
    /// </summary>
    public class CompanyPropertyBag : PropertyBagBase
    {
        /// <summary>
        /// The company object (public)
        /// </summary>
        [JsonProperty("company")]
        public Company Company { get; set; }

        /// <summary>
        /// The detailed company object
        /// </summary>
        [JsonProperty("company_detailed")]
        public CompanyDetailed CompanyDetailed { get; set; }

        /// <summary>
        /// The current item stock of the company
        /// </summary>
        [JsonProperty("company_stock")]
        [JsonConverter(typeof(TornListConverter<CompanyStock>))]
        public List<CompanyStock> CompanyStock { get; set; }

        /// <summary>
        /// The company employees
        /// </summary>
        [JsonProperty("company_employees")]
        [JsonConverter(typeof(TornListConverter<CompanyEmployee>))]
        public List<CompanyEmployee> CompanyEmployees { get; set; }

        /// <summary>
        /// The news for the company
        /// </summary>
        [JsonProperty("news")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> News { get; set; }
    }
}
