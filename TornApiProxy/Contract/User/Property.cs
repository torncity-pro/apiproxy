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

    public class Modifications
    {
        [JsonProperty("interior")]
        public byte Interior { get; set; }

        [JsonProperty("hot_tub")]
        public bool HotTub { get; set; }

        [JsonProperty("sauna")]
        public bool Sauna { get; set; }

        [JsonProperty("pool")]
        public byte Pool { get; set; }

        [JsonProperty("open_bar")]
        public bool OpenBar { get; set; }

        [JsonProperty("shooting_range")]
        public bool ShootingRange { get; set; }

        [JsonProperty("vault")]
        public byte Vault { get; set; }

        [JsonProperty("medical_facility")]
        public bool MedicalFacility { get; set; }

        [JsonProperty("airstrip")]
        public bool Airstrip { get; set; }

        [JsonProperty("yacht")]
        public bool Yacht { get; set; }
    }

    public class Staff
    {
        [JsonProperty("maid")]
        public byte Maid { get; set; }

        [JsonProperty("guard")]
        public byte Guard { get; set; }

        [JsonProperty("pilot")]
        public byte Pilot { get; set; }

        [JsonProperty("butler")]
        public byte Butler { get; set; }

        [JsonProperty("doctor")]
        public byte Doctor { get; set; }
    }

    public class Property
    {
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("property_type")]
        public int PropertyType { get; set; }

        [JsonProperty("property")]
        public string PropertyName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("happy")]
        public short Happy { get; set; }

        [JsonProperty("upkeep")]
        public int Upkeep { get; set; }

        [JsonProperty("staff_cost")]
        public int Staff_cost { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("marketprice")]
        public int Marketprice { get; set; }

        [JsonProperty("modifications")]
        public Modifications Modifications { get; set; }

        [JsonProperty("staff")]
        public Staff Staff { get; set; }
    }
}