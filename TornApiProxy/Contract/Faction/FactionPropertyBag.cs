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

        [JsonProperty("wars")]
        public Dictionary<string, int> Wars { get; set; }

        [JsonProperty("members")]
        public Dictionary<string, FactionMember> Members { get; set; }

        [JsonProperty("peace")]
        public Dictionary<string, int> Peace { get; set; }

        [JsonProperty("territory")]
        public Dictionary<string, Territory> Territory { get; set; }

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
        public Dictionary<string, News> MainNews { get; set; }

        [JsonProperty("attacknews")]
        public Dictionary<string, News> AttackNews { get; set; }

        [JsonProperty("fundsnews")]
        public Dictionary<string, News> FundsNews { get; set; }

        [JsonProperty("armorynews")]
        public Dictionary<string, News> ArmoryNews { get; set; }

        [JsonProperty("crimesnews")]
        public Dictionary<string, News> CrimesNews { get; set; }

        [JsonProperty("membershipnews")]
        public Dictionary<string, News> MembershipNews { get; set; }

        [JsonProperty("crimes")]
        public Dictionary<string, Crime> Crimes { get; set; }

        [JsonProperty("attacks")]
        public Dictionary<string, AttackDetailed> Attacks { get; set; }

        [JsonProperty("revives")]
        [JsonConverter(typeof(TornListConverter<ReviveDetailed>))]
        public List<ReviveDetailed> Revives { get; set; }

        [JsonProperty("upgrades")]
        public Dictionary<string, Upgrade> Upgrades { get; set; }

        [JsonProperty("stats")]
        public FactionStats Stats { get; set; }

        [JsonProperty("donations")]
        public Dictionary<string, UserBalance> Donations { get; set; }

        [JsonProperty("chains")]
        public Dictionary<string, Chain> Chains { get; set; }
    }
}
