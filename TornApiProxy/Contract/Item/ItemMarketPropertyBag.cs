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

﻿namespace TornApiProxy.Contract.Item
{
    using Newtonsoft.Json;
    using Shared;
    using System.Collections.Generic;

    /// <summary>
    /// A root level object to hold all the object values returned by the api
    /// </summary>
    public class ItemMarketPropertyBag : PropertyBagBase
    {
        /// <summary>
        /// A dictionary of points for sale on the market
        /// </summary>
        [JsonProperty("pointsmarket")]
        public Dictionary<string, PointsListing> PointsMarket { get; set; }

        /// <summary>
        /// A dictionary of the item for sale in bazaars
        /// </summary>
        [JsonProperty("bazaar")]
        public Dictionary<string, MarketListing> Bazaars { get; set; }

        /// <summary>
        /// A dictionary of the item for sale on the item market
        /// </summary>
        [JsonProperty("itemmarket")]
        public Dictionary<string, MarketListing> ItemMarket { get; set; }
    }
}
