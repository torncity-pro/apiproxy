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

﻿namespace TornApiProxy.Contract.Shared
{
    /*
     * 0 => 'Unknown error' : Unhandled error, should not occur.
     * 1 => 'Key is empty' : Private key is empty in current request.
     * 2 => 'Incorrect Key' : Private key is wrong/incorrect format.
     * 3 => 'Wrong type' : Requesting an incorrect basic type.
     * 4 => 'Wrong fields' : Requesting incorrect selection fields.
     * 5 => 'Too many requests' : Current private key is banned for a small period of time because of too many requests(max 100 per minute).
     * 6 => 'Incorrect ID' : Wrong ID value.
     * 7 => 'Incorrect ID-entity relation' : A requested selection is private (For example, personal data of another user / faction).
     * 8 => 'IP block' : Current IP is banned for a small period of time because of abuse.
     * 9 => 'API disabled' : Api system is currently disabled.
     * 10 => 'Key owner is in federal jail' : Current key can't be used because owner is in federal jail.
     * 11 => 'Key change error: You can only change your API key once every 60 seconds'.
     * 12 => 'Key read error: Error reading key from Database'. 
     */
    using Newtonsoft.Json;

    public class ExceptionInfo
    {
        [JsonProperty("code")]
        public short ErrorCode { get; set; }

        [JsonProperty("error")]
        public string ErrorMessage { get; set; }
    }
}