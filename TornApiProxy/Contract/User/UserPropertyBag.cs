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
    using Contract.Shared;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class UserPropertyBag : PropertyBagBase
    {
        [JsonProperty("level")]
        public byte Level { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public List<string> Status { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("dexterity")]
        public string Dexterity { get; set; }

        [JsonProperty("defense")]
        public string Defense { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("strength_modifier")]
        public int StrengthModifier { get; set; }

        [JsonProperty("defense_modifier")]
        public int DefenseModifier { get; set; }

        [JsonProperty("speed_modifier")]
        public int SpeedModifier { get; set; }

        [JsonProperty("dexterity_modifier")]
        public int DexterityModifier { get; set; }

        [JsonProperty("strength_info")]
        public string[] StrengthInfo { get; set; }

        [JsonProperty("defense_info")]
        public string[] DefenseInfo { get; set; }

        [JsonProperty("speed_info")]
        public string[] SpeedInfo { get; set; }

        [JsonProperty("dexterity_info")]
        public string[] DexterityInfo { get; set; }

        [JsonProperty("manual_labor")]
        public int ManualLabor { get; set; }

        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("endurance")]
        public int Endurance { get; set; }

        [JsonProperty("networth")]
        public NetworthData Networth { get; set; }

        [JsonProperty("stocks")]
        public Dictionary<string, Stock> Stocks { get; set; }

        [JsonProperty("honors_awarded")]
        public List<int> HonorsAwarded { get; set; }

        [JsonProperty("honors_time")]
        public List<int> HonorsTime { get; set; }

        [JsonProperty("medals_awarded")]
        public List<int> MedalsAwarded { get; set; }

        [JsonProperty("medals_time")]
        public List<int> MedalsTime { get; set; }

        [JsonProperty("display")]
        public List<DisplayCaseItem> DisplayCase { get; set; }

        [JsonProperty("inventory")]
        public List<InventoryItem> Inventory { get; set; }

        [JsonProperty("bazaar")]
        public List<BazaarItem> Bazaar { get; set; }

        [JsonProperty("halloffame")]
        public HallOfFame HallOfFame { get; set; }

        [JsonProperty("merits")]
        public Merits Mertis { get; set; }

        [JsonProperty("active_gym")]
        public byte ActiveGym { get; set; }

        [JsonProperty("refills")]
        public Refills Refills { get; set; }

        [JsonProperty("jobpoints")]
        public Jobpoints JobPoints { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, Property> Properties { get; set; }

        [JsonProperty("server_time")]
        public int ServerTime { get; set; }

        [JsonProperty("happy")]
        public Bar Happy { get; set; }

        [JsonProperty("life")]
        public Bar Life { get; set; }

        [JsonProperty("energy")]
        public Bar  Energy { get; set; }

        [JsonProperty("nerve")]
        public Bar Nerve { get; set; }

        [JsonProperty("chain")]
        public Bar Chain { get; set; }

        [JsonProperty("travel")]
        public Travel Travel { get; set; }

        [JsonProperty("criminalrecord")]
        public CriminalRecord CriminalRecord { get; set; }

        [JsonProperty("notifications")]
        public Notifications Notifications { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }

        [JsonProperty("signup")]
        public string Signup { get; set; }

        [JsonProperty("awards")]
        public int Awards { get; set; }

        [JsonProperty("friends")]
        public int Friends { get; set; }

        [JsonProperty("enemies")]
        public int Enemies { get; set; }

        [JsonProperty("forum_posts")]
        public int ForumPosts { get; set; }

        [JsonProperty("karma")]
        public int Karma { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("donator")]
        public int Donator { get; set; }

        [JsonProperty("property_id")]
        public int PropertyId { get; set; }

        [JsonProperty("job")]
        public Job Job { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }

        [JsonProperty("married")]
        public Married Married { get; set; }

        [JsonProperty("basicicons")]
        public Dictionary<string, string> BasicIcons { get; set; }

        [JsonProperty("icons")]
        public Dictionary<string, string> Icons { get; set; }

        [JsonProperty("states")]
        public States States { get; set; }

        [JsonProperty("last_action")]
        public LastAction LastAction { get; set; }

        [JsonProperty("cooldowns")]
        public Cooldowns Cooldowns { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("cayman_bank")]
        public int CaymanBank { get; set; }

        [JsonProperty("vault_amount")]
        public int VaultAmount { get; set; }

        //[JsonProperty("networth")]
        //public long Networth { get; set; }

        [JsonProperty("money_onhand")]
        public int MoneyOnhand { get; set; }

        [JsonProperty("city_bank")]
        public CityBank CityBank { get; set; }

        [JsonProperty("job_perks")]
        public List<string> JobPerks { get; set; }

        [JsonProperty("property_perks")]
        public List<string> PropertyPerks { get; set; }

        [JsonProperty("stock_perks")]
        public List<string> StockPerks { get; set; }

        [JsonProperty("merit_perks")]
        public List<string> MeritPerks { get; set; }

        [JsonProperty("education_perks")]
        public List<string> EducationPerks { get; set; }

        [JsonProperty("enhancer_perks")]
        public List<string> EnhancerPerks { get; set; }

        [JsonProperty("company_perks")]
        public List<string> CompanyPerks { get; set; }

        [JsonProperty("faction_perks")]
        public List<string> FactionPerks { get; set; }

        [JsonProperty("book_perks")] // Is this the correct value?
        public List<string> BookPerks { get; set; }

        [JsonProperty("mesages")]
        public Dictionary<string, Message> Messages { get; set; }

        [JsonProperty("events")]
        public Dictionary<string, Event> Events { get; set; }

        [JsonProperty("personalstats")]
        public PersonalStats PersonalStats { get; set; }

        [JsonProperty("education_current")]
        public int EducationCurrent { get; set; }

        [JsonProperty("education_timeleft")]
        public int EducationTimeLeft { get; set; }

        [JsonProperty("education_completed")]
        public List<int> EducationCompleted { get; set; }

        [JsonProperty("attacks")]
        public Dictionary<string, AttackDetailed> Attacks { get; set; }

        [JsonProperty("revives")]
        public Dictionary<string, ReviveDetailed> Revives { get; set; }

        [JsonProperty("discord")]
        public Discord Discord { get; set; }
    }
}
