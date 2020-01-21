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

﻿namespace TornApiProxy.Contract.User
{
    using Newtonsoft.Json;
    using Shared;
    using System.Collections.Generic;

    public class CityJobPoints
    {
        [JsonProperty("medical")]
        public int Medical { get; set; }

        [JsonProperty("casino")]
        public int Casino { get; set; }

        [JsonProperty("education")]
        public int Education { get; set; }

        [JsonProperty("law")]
        public int Law { get; set; }

        [JsonProperty("grocer")]
        public int Grocer { get; set; }
    }

    public class CompanyJobPoints : ApiListItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("jobpoints")]
        public int JobPoints { get; set; }
    }

    public class Jobpoints
    {
        [JsonProperty("jobs")]
        public CityJobPoints Jobs { get; set; }

        [JsonProperty("companies")]
        [JsonConverter(typeof(TornListConverter<CompanyJobPoints>))]
        public List<CompanyJobPoints> Companies { get; set; }
    }
}