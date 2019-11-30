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

﻿namespace TornApiProxy.Fields
{
    public class UserField : ApiField
    {
        protected UserField(string fieldName) : base(fieldName) { }

        public static readonly UserField Networth = new UserField("networth");
        public static readonly UserField Bazaar = new UserField("bazaar");
        public static readonly UserField Display = new UserField("display");
        public static readonly UserField Inventory = new UserField("inventory");
        public static readonly UserField Hof = new UserField("hof");
        public static readonly UserField Travel = new UserField("travel");
        public static readonly UserField Events = new UserField("events");
        public static readonly UserField Messages = new UserField("messages");
        public static readonly UserField Education = new UserField("education");
        public static readonly UserField Medals = new UserField("medals");
        public static readonly UserField Honors = new UserField("honors");
        public static readonly UserField Notifications = new UserField("notifications");
        public static readonly UserField Personalstats = new UserField("personalstats");
        public static readonly UserField Workstats = new UserField("workstats");
        public static readonly UserField Crimes = new UserField("crimes");
        public static readonly UserField Icons = new UserField("icons");
        public static readonly UserField Cooldowns = new UserField("cooldowns");
        public static readonly UserField Money = new UserField("money");
        public static readonly UserField Perks = new UserField("perks");
        public static readonly UserField Battlestats = new UserField("battlestats");
        public static readonly UserField Bars = new UserField("bars");
        public static readonly UserField Profile = new UserField("profile");
        public static readonly UserField Basic = new UserField("basic");
        public static readonly UserField Attacks = new UserField("attacks");
        public static readonly UserField Attacksfull = new UserField("attacksfull");
        public static readonly UserField Revives = new UserField("revives");
        public static readonly UserField Revivesfull = new UserField("revivesfull");
        public static readonly UserField Stocks = new UserField("stocks");
        public static readonly UserField Properties = new UserField("properties");
        public static readonly UserField Jobpoints = new UserField("jobpoints");
        public static readonly UserField Merits = new UserField("merits");
        public static readonly UserField Refills = new UserField("refills");
        public static readonly UserField Discord = new UserField("discord");
        public static readonly UserField Gym = new UserField("gym");
    }
}
