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
    using Contract.Torn;
    using Contract.User;
    using Fields;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines methods to be implemented by a class which can query for game data
    /// </summary>
    public interface ITornHttpProxy
    {
        /// <summary>
        /// Gets data related to player run companies
        /// </summary>
        /// <param name="companyId">The Id of the company to query. Can be string.Empty for self querying against the current user api key</param>
        /// <param name="fields">The data to be retrieved as see in the api docs</param>
        /// <returns>Return a property bag object populated with the data fields specified</returns>
        Task<CompanyPropertyBag> GetCompanyPropertiesAsync(string companyId, params CompanyField[] fields);

        /// <summary>
        /// Gets data related to a faction
        /// </summary>
        /// <param name="factionId">The Id for the faction to query. Can be string.Empty for self querying against the current user api key</param>
        /// <param name="fields">The data to be retrieved as see in the api docs</param>
        /// <returns>Return a property bag object populated with the data fields specified</returns>
        Task<FactionPropertyBag> GetFactionPropertiesAsync(string factionId, params FactionField[] fields);

        /// <summary>
        /// Gets data related to items on the item market
        /// </summary>
        /// <param name="itemId">The Id of the item type to query. If left blank defaults to 1</param>
        /// <param name="fields">The data to be retrieved as see in the api docs</param>
        /// <returns>Return a property bag object populated with the data fields specified</returns>
        Task<ItemMarketPropertyBag> GetItemMarketListingsAsync(string itemId, params ItemField[] fields);

        /// <summary>
        /// Gets data related to a property
        /// </summary>
        /// <param name="propertyId">The Id of the property to query.</param>
        /// <param name="fields">The data to be retrieved as see in the api docs</param>
        /// <returns>Return a property bag object populated with the data fields specified</returns>
        Task<PropertyPropertyBag> GetPropertyPropertiesAsync(string propertyId, params PropertyField[] fields);

        /// <summary>
        /// Gets data related to game objects such as medals, honors, items, etc.
        /// </summary>
        /// <param name="id">Can be speicified when querying for a particular item or string.Empty</param>
        /// <param name="fields">The data to be retrieved as see in the api docs</param>
        /// <returns>Return a property bag object populated with the data fields specified</returns>
        Task<TornPropertyBag> GetTornPropertiesAsync(string id, params TornField[] fields);

        /// <summary>
        /// Gets data related to a player
        /// </summary>
        /// <param name="userId">The Id of the user to query. Can be set to string.Empty to query against the api key owner</param>
        /// <param name="fields">The data to be retrieved as see in the api docs</param>
        /// <returns>Return a property bag object populated with the data fields specified</returns>
        Task<UserPropertyBag> GetUserPropertiesAsync(string userId, params UserField[] fields);
    }
}