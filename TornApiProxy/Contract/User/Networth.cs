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

    public class NetworthData
    {
        [JsonProperty("pending")]
        public double Pending { get; set; }

        [JsonProperty("wallet")]
        public double Wallet { get; set; }

        [JsonProperty("bank")]
        public double Bank { get; set; }

        [JsonProperty("points")]
        public double Points { get; set; }

        [JsonProperty("cayman")]
        public double Cayman { get; set; }

        [JsonProperty("vault")]
        public double Vault { get; set; }

        [JsonProperty("piggybank")]
        public double? PiggyBank { get; set; }

        [JsonProperty("items")]
        public double Items { get; set; }

        [JsonProperty("displaycase")]
        public double DisplayCase { get; set; }

        [JsonProperty("bazaar")]
        public double Bazaar { get; set; }

        [JsonProperty("properties")]
        public double Properties { get; set; }

        [JsonProperty("stockmarket")]
        public double StockMarket { get; set; }

        [JsonProperty("auctionhouse")]
        public double AuctionHouse { get; set; }

        [JsonProperty("company")]
        public double Company { get; set; }

        [JsonProperty("bookie")]
        public double Bookie { get; set; }

        [JsonProperty("loan")]
        public double Loan { get; set; }

        [JsonProperty("unpaidfees")]
        public double UnpaidFees { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("parsetime")]
        public double ParseTime { get; set; }
    }
}
