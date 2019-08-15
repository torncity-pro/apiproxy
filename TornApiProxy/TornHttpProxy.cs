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
    using Contract.Shared;
    using Contract.Torn;
    using Contract.User;
    using Exceptions;
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class TornHttpProxy : ITornHttpProxy
    {
        private string apiKey;
        private HttpClient httpClient;

        public const string COMPANY = "company";
        public const string FACTION = "faction";
        public const string ITEM = "market";
        public const string PROPERTY = "property";
        public const string TORN = "torn";
        public const string USER = "user";

        public TornHttpProxy()
        {
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.torn.com/")
            };
        }

        public TornHttpProxy(string apiKey) : this()
        {
            this.apiKey = apiKey;
        }

        public async Task<UserPropertyBag> GetUserProperties(string userId, params UserField[] fields)
        {
            return await this.GetPropertiesAsync<UserPropertyBag>(USER, userId, fields);
        }

        public async Task<ItemMarketPropertyBag> GetItemMarketListings(string itemId, params ItemField[] fields)
        {
            return await this.GetPropertiesAsync<ItemMarketPropertyBag>(ITEM, itemId, fields);
        }
        public async Task<CompanyPropertyBag> GetCompanyPropertiesAsync(string companyId, params CompanyField[] fields)
        {
            return await this.GetPropertiesAsync<CompanyPropertyBag>(COMPANY, companyId, fields);
        }

        public async Task<PropertyPropertyBag> GetPropertyPropertiesAsync(string propertyId, params PropertyField[] fields)
        {
            return await this.GetPropertiesAsync<PropertyPropertyBag>(PROPERTY, propertyId, fields);
        }

        public async Task<FactionPropertyBag> GetFactionPropertiesAsync(string factionId, params FactionField[] fields)
        {
            return await this.GetPropertiesAsync<FactionPropertyBag>(FACTION, factionId, fields);
        }

        public async Task<TornPropertyBag> GetTornPropertiesAsync(string id, params TornField[] fields)
        {
            return await this.GetPropertiesAsync<TornPropertyBag>(TORN, id, fields);
        }

        private async Task<T> GetPropertiesAsync<T>(string resourceName, string id, params ApiField[] fields) where T : PropertyBagBase
        {
            return await this.GetResource<T>(string.Format("{0}/{1}?key={2}&selections={3}", resourceName, id, this.apiKey, string.Join(",", fields.Select(i => i.fieldName))));
        }

        private async Task<T> GetResource<T>(string resource) where T : PropertyBagBase
        {
            var request = new HttpRequestMessage(HttpMethod.Get, resource);
            var response = await this.httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var payload = JsonConvert.DeserializeObject<T>(content);

                if (payload.ErrorInfo != null)
                {
                    throw ApiException.CreateExceptionFromExceptionInfo(payload.ErrorInfo);
                }

                return payload;
            }

            return default(T);
        }
    }
}
