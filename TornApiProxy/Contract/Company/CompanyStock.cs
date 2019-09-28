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
    /// Represents a type of item stock in a company
    /// </summary>
    public class CompanyStock
    {
        /// <summary>
        /// The cost to order the item for the company stock
        /// </summary>
        [JsonProperty("cost")]
        public int Cost { get; set; }

        /// <summary>
        /// The recommended retail price to sell the item in the company
        /// </summary>
        [JsonProperty("rrp")]
        public int RecommendedRetailPrice { get; set; }

        /// <summary>
        /// The currently set item price
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// The current number of the item in stock
        /// </summary>
        [JsonProperty("in_stock")]
        public int InStock { get; set; }

        /// <summary>
        /// The number of items that have been ordered and are waiting to be delivered
        /// </summary>
        [JsonProperty("on_order")]
        public int OnOrder { get; set; }

        /// <summary>
        /// The total amount of this item sold
        /// </summary>
        [JsonProperty("sold_amount")]
        public int SoldAmount { get; set; }

        /// <summary>
        /// The total amount
        /// </summary>
        [JsonProperty("sold_worth")]
        public long SoldWorth { get; set; }
    }
}
