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
        public long Pending { get; set; }

        [JsonProperty("wallet")]
        public long Wallet { get; set; }

        [JsonProperty("bank")]
        public long Bank { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("cayman")]
        public long Cayman { get; set; }

        [JsonProperty("vault")]
        public long Vault { get; set; }

        [JsonProperty("piggybank")]
        public long? PiggyBank { get; set; }

        [JsonProperty("items")]
        public long Items { get; set; }

        [JsonProperty("displaycase")]
        public long DisplayCase { get; set; }

        [JsonProperty("bazaar")]
        public long Bazaar { get; set; }

        [JsonProperty("properties")]
        public long Properties { get; set; }

        [JsonProperty("stockmarket")]
        public long StockMarket { get; set; }

        [JsonProperty("auctionhouse")]
        public long AuctionHouse { get; set; }

        [JsonProperty("company")]
        public long Company { get; set; }

        [JsonProperty("bookie")]
        public long Bookie { get; set; }

        [JsonProperty("loan")]
        public long Loan { get; set; }

        [JsonProperty("unpaidfees")]
        public long UnpaidFees { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("parsetime")]
        public long ParseTime { get; set; }
    }
}
