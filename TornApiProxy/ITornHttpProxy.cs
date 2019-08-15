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

﻿namespace TornApiProxy
{
    using Contract.Company;
    using Contract.Faction;
    using Contract.Item;
    using Contract.Properties;
    using Contract.Torn;
    using Contract.User;
    using System.Threading.Tasks;

    public interface ITornHttpProxy
    {
        Task<CompanyPropertyBag> GetCompanyPropertiesAsync(string companyId, params CompanyField[] fields);
        Task<FactionPropertyBag> GetFactionPropertiesAsync(string factionId, params FactionField[] fields);
        Task<ItemMarketPropertyBag> GetItemMarketListings(string itemId, params ItemField[] fields);
        Task<PropertyPropertyBag> GetPropertyPropertiesAsync(string propertyId, params PropertyField[] fields);
        Task<TornPropertyBag> GetTornPropertiesAsync(string id, params TornField[] fields);
        Task<UserPropertyBag> GetUserProperties(string userId, params UserField[] fields);
    }
}