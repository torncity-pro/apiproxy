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

namespace TornApiProxy
{
    using Contract.Company;
    using Contract.Faction;
    using Contract.Item;
    using Contract.Properties;
    using Contract.Shared;
    using Contract.Torn;
    using Contract.User;
    using Exceptions;
    using Fields;
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// An implementation of the ITornHttpProxy
    /// </summary>
    public class TornHttpProxy : ITornHttpProxy
    {
        /// <summary>
        /// The apiKey to use for http requests made by this proxy
        /// </summary>
        private readonly string apiKey;

        /// <summary>
        /// The HttpClient to use when making web requests
        /// </summary>
        private readonly HttpClient httpClient;

        #region url constants
        private const string COMPANY = "company";
        private const string FACTION = "faction";
        private const string ITEM = "market";
        private const string PROPERTY = "property";
        private const string TORN = "torn";
        private const string USER = "user";
        #endregion

        /// <summary>
        /// Creates a new TornHttpProxy
        /// </summary>
        /// <param name="httpClient">The HttpClient this proxy should use</param>
        /// <param name="apiKey">The apiKey to be used</param>
        public TornHttpProxy(HttpClient httpClient, string apiKey) : this(apiKey)
        {
            this.httpClient = httpClient;
        }

        /// <summary>
        /// Creates a TornHttpProxy
        /// </summary>
        /// <param name="apiKey">The apiKey to be used</param>
        public TornHttpProxy(string apiKey)
        {
            this.apiKey = apiKey;
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.torn.com/")
            };
        }

        /// <summary>
        /// Provides a nice wrapper for the api.torn.com/user/ endpoint
        /// </summary>
        /// <param name="id">The id to query</param>
        /// <param name="fields">The fields to query</param>
        /// <returns>A new propertybag with the given fields deserialized into it</returns>
        public async Task<UserPropertyBag> GetUserPropertiesAsync(object userId, params UserField[] fields)
        {
            try
            {
                return await this.GetPropertiesAsync<UserPropertyBag>(USER, userId.ToString(), fields).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Provides a nice wrapper for the api.torn.com/market/ endpoint
        /// </summary>
        /// <param name="id">The id to query</param>
        /// <param name="fields">The fields to query</param>
        /// <returns>A new propertybag with the given fields deserialized into it</returns>
        public async Task<ItemMarketPropertyBag> GetItemMarketListingsAsync(object itemId, params ItemField[] fields)
        {
            try
            {
                return await this.GetPropertiesAsync<ItemMarketPropertyBag>(ITEM, itemId.ToString(), fields).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Provides a nice wrapper for the api.torn.com/company/ endpoint
        /// </summary>
        /// <param name="id">The id to query</param>
        /// <param name="fields">The fields to query</param>
        /// <returns>A new propertybag with the given fields deserialized into it</returns>
        public async Task<CompanyPropertyBag> GetCompanyPropertiesAsync(object companyId, params CompanyField[] fields)
        {
            try
            {
                return await this.GetPropertiesAsync<CompanyPropertyBag>(COMPANY, companyId.ToString(), fields).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Provides a nice wrapper for the api.torn.com/property/ endpoint
        /// </summary>
        /// <param name="id">The id to query</param>
        /// <param name="fields">The fields to query</param>
        /// <returns>A new propertybag with the given fields deserialized into it</returns>
        public async Task<PropertyPropertyBag> GetPropertyPropertiesAsync(object propertyId, params PropertyField[] fields)
        {
            try
            {
                return await this.GetPropertiesAsync<PropertyPropertyBag>(PROPERTY, propertyId.ToString(), fields).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Provides a nice wrapper for the api.torn.com/faction/ endpoint
        /// </summary>
        /// <param name="id">The id to query</param>
        /// <param name="fields">The fields to query</param>
        /// <returns>A new propertybag with the given fields deserialized into it</returns>
        public async Task<FactionPropertyBag> GetFactionPropertiesAsync(object factionId, params FactionField[] fields)
        {
            try
            {
                return await this.GetPropertiesAsync<FactionPropertyBag>(FACTION, factionId.ToString(), fields).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Provides a nice wrapper for the api.torn.com/torn/ endpoint
        /// </summary>
        /// <param name="id">The id to query</param>
        /// <param name="fields">The fields to query</param>
        /// <returns>A new propertybag with the given fields deserialized into it</returns>
        public async Task<TornPropertyBag> GetTornPropertiesAsync(object id, params TornField[] fields)
        {
            try
            {
                return await this.GetPropertiesAsync<TornPropertyBag>(TORN, id.ToString(), fields).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Query the given url with the provided parameters and then deserializes it to return object T
        /// </summary>
        /// <typeparam name="T">The Object to deserialize</typeparam>
        /// <param name="resourceName">The url endpoint to query</param>
        /// <param name="id">The id of the resource to query, can sometimes be string.Empty</param>
        /// <param name="fields">The ApiFields to query.</param>
        /// <returns>A newly populated object T</returns>
        private async Task<T> GetPropertiesAsync<T>(string resourceName, string id, params ApiField[] fields) where T : PropertyBagBase
        {
            try
            {
                return await this.GetResourceAsync<T>(string.Format("{0}/{1}?key={2}&selections={3}", resourceName, id, this.apiKey, string.Join(",", fields.Select(i => i.fieldName)))).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the json response from the api endpoint and deserializes to the given type T
        /// </summary>
        /// <typeparam name="T">The type to deserialize</typeparam>
        /// <param name="resource">The web url to query</param>
        /// <returns>A new data object will be returned on success or an error will be thrown</returns>
        private async Task<T> GetResourceAsync<T>(string resource) where T : PropertyBagBase
        {
            var request = new HttpRequestMessage(HttpMethod.Get, resource);
            var response = await this.httpClient.SendAsync(request).ConfigureAwait(false);

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

            return default;
        }
    }
}
