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

    public class CriminalRecord
    {
        [JsonProperty("selling_illegal_products")]
        public int SellingIllegalProducts { get; set; }

        [JsonProperty("theft")]
        public int Theft { get; set; }

        [JsonProperty("auto_theft")]
        public int AutoTheft { get; set; }

        [JsonProperty("drug_deals")]
        public int DrugDeals { get; set; }

        [JsonProperty("computer_crimes")]
        public int ComputerCrimes { get; set; }

        [JsonProperty("murder")]
        public int Murder { get; set; }

        [JsonProperty("fraud_crimes")]
        public int FraudCrimes { get; set; }

        [JsonProperty("other")]
        public int Other { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}