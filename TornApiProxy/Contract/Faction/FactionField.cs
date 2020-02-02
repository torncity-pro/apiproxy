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
    public class FactionField : ApiField
    {
        protected FactionField(string fieldName) : base(fieldName) { }

        public static readonly FactionField Basic = new FactionField("basic");
        public static readonly FactionField Territory = new FactionField("territory");
        public static readonly FactionField Chain = new FactionField("chain");
        public static readonly FactionField Currency = new FactionField("currency");
        public static readonly FactionField Weapons = new FactionField("weapons");
        public static readonly FactionField Armor = new FactionField("armor");
        public static readonly FactionField Temporary = new FactionField("temporary");
        public static readonly FactionField Medical = new FactionField("medical");
        public static readonly FactionField Drugs = new FactionField("drugs");
        public static readonly FactionField Boosters = new FactionField("boosters");
        public static readonly FactionField Cesium = new FactionField("cesium");
        public static readonly FactionField MainNews = new FactionField("mainnews");
        public static readonly FactionField MainNewsFull = new FactionField("mainnewsfull");
        public static readonly FactionField AttackNews = new FactionField("attacknews");
        public static readonly FactionField AttackNewsFull = new FactionField("attacknewsfull");
        public static readonly FactionField FundsNews = new FactionField("fundsnews");
        public static readonly FactionField FundsNewsFull = new FactionField("fundsnewsfull");
        public static readonly FactionField ArmoryNews = new FactionField("armorynews");
        public static readonly FactionField ArmoryNewsFull = new FactionField("armorynewsfull");
        public static readonly FactionField CrimeNews = new FactionField("crimenews");
        public static readonly FactionField CrimeNewsFull = new FactionField("crimenewsfull");
        public static readonly FactionField MembershipNews = new FactionField("membershipnews");
        public static readonly FactionField MembershipNewsFull = new FactionField("membershipnewsfull");
        public static readonly FactionField Crimes = new FactionField("crimes");
        public static readonly FactionField Attacks = new FactionField("attacks");
        public static readonly FactionField AttacksFull = new FactionField("attacksfull");
        public static readonly FactionField Revives = new FactionField("revives");
        public static readonly FactionField RevivesFull = new FactionField("revivesfull");
        public static readonly FactionField Upgrades = new FactionField("upgrades");
        public static readonly FactionField Stats = new FactionField("stats");
        public static readonly FactionField Donations = new FactionField("donations");
        public static readonly FactionField Chains = new FactionField("chains");
        public static readonly FactionField Lookup = new FactionField("lookup");
        public static readonly FactionField Timestamp = new FactionField("timestamp");
    }
}
