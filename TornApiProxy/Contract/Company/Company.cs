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
    using System.Collections.Generic;

    public class Company
    {
        [JsonProperty("ID")]
        public int CompanyId { get; set; }

        [JsonProperty("company_type")]
        public int CompanyType { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("director")]
        public int Director { get; set; }

        [JsonProperty("daily_profit")]
        public int DailyProfit { get; set; }

        [JsonProperty("weekly_profit")]
        public int WeeklyProfit { get; set; }

        [JsonProperty("daily_customers")]
        public int DailyCustomers { get; set; }

        [JsonProperty("weekly_customers")]
        public int WeeklyCustomers { get; set; }

        [JsonProperty("days_old")]
        public int DaysOld { get; set; }

        [JsonProperty("employees")]
        public Dictionary<string, Employee> Employees { get; set; }
    }

    public class Employee
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("days_in_company")]
        public int DaysInCompany { get; set; }
    }
}
