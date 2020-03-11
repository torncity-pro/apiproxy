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

﻿namespace TornApiProxy.Contract.Faction
{
    using Newtonsoft.Json;
    using Shared;
    using System.Collections.Generic;

    public class FactionPropertyBag : PropertyBagBase
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("leader")]
        public int Leader { get; set; }

        [JsonProperty("co-leader")]
        public int CoLeader { get; set; }

        [JsonProperty("respect")]
        public int Respect { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("best_chain")]
        public int BestChain { get; set; }

        [JsonProperty("members")]
        [JsonConverter(typeof(TornListConverter<FactionMember>))]
        public List<FactionMember> Members { get; set; }

        //[JsonProperty("peace")]
        //public Dictionary<string, int> Peace { get; set; }

        [JsonProperty("territory")]
        [JsonConverter(typeof(TornListConverter<Territory>))]
        public List<Territory> Territory { get; set; }

        [JsonProperty("chain")]
        public ActiveChain Chain { get; set; }

        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("money")]
        public long Money { get; set; }

        [JsonProperty("weapons")]
        public List<LoanableArmoryItem> Weapons { get; set; }

        [JsonProperty("armor")]
        public List<LoanableArmoryItem> Armor { get; set; }

        [JsonProperty("temporary")]
        public List<ArmoryItem> TemporaryItems { get; set; }

        [JsonProperty("medical")]
        public List<ArmoryItem> MedicalItems { get; set; }

        [JsonProperty("drugs")]
        public List<ArmoryItem> Drugs { get; set; }

        [JsonProperty("boosters")]
        public List<ArmoryItem> Boosters { get; set; }

        [JsonProperty("mainnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> MainNews { get; set; }

        [JsonProperty("attacknews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> AttackNews { get; set; }

        [JsonProperty("fundsnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> FundsNews { get; set; }

        [JsonProperty("armorynews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> ArmoryNews { get; set; }

        [JsonProperty("crimesnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> CrimesNews { get; set; }

        [JsonProperty("membershipnews")]
        [JsonConverter(typeof(TornListConverter<News>))]
        public List<News> MembershipNews { get; set; }

        [JsonProperty("crimes")]
        [JsonConverter(typeof(TornListConverter<Crime>))]
        public List<Crime> Crimes { get; set; }

        [JsonProperty("attacks")]
        [JsonConverter(typeof(TornListConverter<AttackDetailed>))]
        public List<AttackDetailed> Attacks { get; set; }

        [JsonProperty("revives")]
        [JsonConverter(typeof(TornListConverter<ReviveDetailed>))]
        public List<ReviveDetailed> Revives { get; set; }

        [JsonProperty("upgrades")]
        [JsonConverter(typeof(TornListConverter<Upgrade>))]
        public List<Upgrade> Upgrades { get; set; }

        [JsonProperty("stats")]
        public FactionStats Stats { get; set; }

        [JsonProperty("donations")]
        [JsonConverter(typeof(TornListConverter<UserBalance>))]
        public List<UserBalance> Donations { get; set; }

        [JsonProperty("chains")]
        [JsonConverter(typeof(TornListConverter<Chain>))]
        public List<Chain> Chains { get; set; }

        [JsonProperty("cesium")]
        public int Cesium { get; set; }

        //[JsonProperty("territory_wars")]
        //public List<TerritoryWar> TerritoryWars { get; set; }

        //[JsonProperty("raid_wars")]
        //public List<RaidWar> RaidWars { get; set; }
    }
}
