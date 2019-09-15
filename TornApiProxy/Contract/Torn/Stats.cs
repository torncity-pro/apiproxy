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

﻿namespace TornApiProxy.Contract.Torn
{
    using Newtonsoft.Json;

    public class Stats
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("users_total")]
        public int TotalUsers { get; set; }

        [JsonProperty("users_male")]
        public int MaleUsers { get; set; }

        [JsonProperty("users_female")]
        public int FemaleUsers { get; set; }

        [JsonProperty("users_marriedcouples")]
        public int MarriedUsers { get; set; }

        [JsonProperty("users_daily")]
        public int DailyUsers { get; set; }

        [JsonProperty("total_users_logins")]
        public int TotalUserLogins { get; set; }

        [JsonProperty("total_users_playtime")]
        public string TotalUserPlaytime { get; set; }

        [JsonProperty("job_army")]
        public int TotalArmyJobs { get; set; }

        [JsonProperty("job_grocer")]
        public int TotalGrocerJobs { get; set; }

        [JsonProperty("job_medical")]
        public int TotalMedicalJobs { get; set; }

        [JsonProperty("job_casino")]
        public int TotalCasinoJobs { get; set; }

        [JsonProperty("job_education")]
        public int TotalEducationJobs { get; set; }

        [JsonProperty("job_law")]
        public int TotalLawJobs { get; set; }

        [JsonProperty("job_company")]
        public int TotalCompanyJobs { get; set; }

        [JsonProperty("job_none")]
        public int TotalUnemployed { get; set; }

        [JsonProperty("crimes")]
        public int TotalCrimes { get; set; }

        [JsonProperty("jailed")]
        public int Jailed { get; set; }

        [JsonProperty("money_onhand")]
        public long TotalMoneyOnHand { get; set; }

        [JsonProperty("money_average")]
        public int AverageMoneyOnHand { get; set; }

        [JsonProperty("money_citybank")]
        public long TotalMoneyBanked { get; set; }

        [JsonProperty("items")]
        public int TotalItems { get; set; }

        [JsonProperty("events")]
        public int TotalEvents { get; set; }

        [JsonProperty("points_total")]
        public int TotalPoints { get; set; }

        [JsonProperty("points_market")]
        public int TotalPointsOnMarket { get; set; }

        [JsonProperty("points_averagecost")]
        public int AveragePointsCost { get; set; }

        [JsonProperty("points_bought")]
        public int TotalPointsBought { get; set; }

        [JsonProperty("total_points_boughttotal")]
        public int TotalMoneySpentOnPoints { get; set; }

        [JsonProperty("total_attacks_won")]
        public int TotalAttacksWon { get; set; }

        [JsonProperty("total_attacks_lost")]
        public int TotalAttacksLost { get; set; }

        [JsonProperty("total_attacks_stalemated")]
        public int TotalAttacksStalemated { get; set; }

        [JsonProperty("total_attacks_runaway")]
        public int TotalAttacksEscaped { get; set; }

        [JsonProperty("total_attacks_hits")]
        public int TotalCombatHits { get; set; }

        [JsonProperty("total_attacks_misses")]
        public int TotalCombatMisses { get; set; }

        [JsonProperty("total_attacks_criticalhits")]
        public int TotalCombatCriticalHits { get; set; }

        [JsonProperty("total_attacks_roundsfired")]
        public int TotalCombatRoundsFired { get; set; }

        [JsonProperty("total_attacks_stealthed")]
        public int TotalAttacksStealthed { get; set; }

        [JsonProperty("total_attacks_moneymugged")]
        public long TotalMoneyMugged { get; set; }

        [JsonProperty("total_attacks_respectgained")]
        public int TotalRespectGainedByAttacking { get; set; }

        [JsonProperty("total_items_marketbought")]
        public int TotalItemsBoughtFromItemMarket { get; set; }

        [JsonProperty("total_items_bazaarbought")]
        public int TotalItemsBoughtFromBazaars { get; set; }

        [JsonProperty("total_items_auctionswon")]
        public int TotalItemAuctionsWon { get; set; }

        [JsonProperty("total_items_sent")]
        public int TotalItemsSends { get; set; }

        [JsonProperty("total_trades")]
        public int TotalTrades { get; set; }

        [JsonProperty("total_items_bazaarincome")]
        public long TotalBazaarIncome { get; set; }

        [JsonProperty("total_items_cityfinds")]
        public int TotalItemsFoundInCity { get; set; }

        [JsonProperty("total_items_dumpfinds")]
        public int TotalItemsFoundInDump { get; set; }

        [JsonProperty("total_items_dumped")]
        public int TotalItemsDumped { get; set; }

        [JsonProperty("total_jail_jailed")]
        public int TotalJailings { get; set; }

        [JsonProperty("total_jail_busted")]
        public int TotalJailBusts { get; set; }

        [JsonProperty("total_jail_busts")]
        public int TotalJailBustsFailed { get; set; }

        [JsonProperty("total_jail_bailed")]
        public int TotalJailBailings { get; set; }

        [JsonProperty("total_jail_bailcosts")]
        public long TotalJailBailCosts { get; set; }

        [JsonProperty("total_hospital_trips")]
        public int TotalHospitalizations { get; set; }

        [JsonProperty("total_hospital_medicalitemsused")]
        public int TotalMedicalItemsUsed { get; set; }

        [JsonProperty("total_hospital_revived")]
        public int TotalRevives { get; set; }

        [JsonProperty("total_mails_sent")]
        public int TotalMailsSent { get; set; }

        [JsonProperty("total_mails_sent_friends")]
        public int TotalMailsSentToFriends { get; set; }

        [JsonProperty("total_mails_sent_faction")]
        public int TotalMailsSentToFaction { get; set; }

        [JsonProperty("total_mails_sent_company")]
        public int TotalMailsSentToCompany { get; set; }

        [JsonProperty("total_mails_sent_spouse")]
        public int TotalMailsSentToSpouse { get; set; }

        [JsonProperty("total_classifiedads_placed")]
        public int TotalClassifiedAdsPlaced { get; set; }

        [JsonProperty("total_bounty_placed")]
        public int TotalBountiesPlaced { get; set; }

        [JsonProperty("total_bounty_rewards")]
        public long TotalBountyRewards { get; set; }

        [JsonProperty("total_travel_all")]
        public int TotalTimesTraveled { get; set; }

        [JsonProperty("total_travel_argentina")]
        public int TotalTimesTraveledToArgentina { get; set; }

        [JsonProperty("total_travel_mexico")]
        public int TotalTimesTraveledToMexico { get; set; }

        [JsonProperty("total_travel_dubai")]
        public int TotalTimesTraveledToDubai { get; set; }

        [JsonProperty("total_travel_hawaii")]
        public int TotalTimesTraveledToHawaii { get; set; }

        [JsonProperty("total_travel_japan")]
        public int TotalTimesTraveledToJapan { get; set; }

        [JsonProperty("total_travel_unitedkingdom")]
        public int TotalTimesTraveledToUnitedKingdom { get; set; }

        [JsonProperty("total_travel_southafrica")]
        public int TotalTimesTraveledToSouthAfrica { get; set; }

        [JsonProperty("total_travel_switzerland")]
        public int TotalTimesTraveledToSwitzerland { get; set; }

        [JsonProperty("total_travel_china")]
        public int TotalTimesTraveledToChina { get; set; }

        [JsonProperty("total_travel_canada")]
        public int TotalTimesTraveledToCanada { get; set; }

        [JsonProperty("total_travel_caymanislands")]
        public int TotalTimesTraveledToCaymanIslands { get; set; }

        [JsonProperty("total_drugs_used")]
        public int TotalDrugsUsed { get; set; }

        [JsonProperty("total_drugs_overdosed")]
        public int TotalDrugOverdoses { get; set; }

        [JsonProperty("total_drugs_cannabis")]
        public int TotalCannabisUsed { get; set; }

        [JsonProperty("total_drugs_ecstacy")]
        public int TotalEcstacyUsed { get; set; }

        [JsonProperty("total_drugs_ketamine")]
        public int TotalKetamineUsed { get; set; }

        [JsonProperty("total_drugs_lsd")]
        public int TotalLsdUsed { get; set; }

        [JsonProperty("total_drugs_opium")]
        public int TotalOpiumUsed { get; set; }

        [JsonProperty("total_drugs_shrooms")]
        public int TotalShroomsUsed { get; set; }

        [JsonProperty("total_drugs_speed")]
        public int TotalSpeedUsed { get; set; }

        [JsonProperty("total_drugs_pcp")]
        public int TotalPcpUsed { get; set; }

        [JsonProperty("total_drugs_xanax")]
        public int TotalXanaxUsed { get; set; }

        [JsonProperty("total_drugs_vicodin")]
        public int TotalVicodinUsed { get; set; }

        [JsonProperty("total_merits_bought")]
        public int TotalMeritsBought { get; set; }

        [JsonProperty("total_refills_bought")]
        public int TotalRefillsBought { get; set; }

        [JsonProperty("total_company_trains")]
        public int TotalCompanyTrainsDone { get; set; }

        [JsonProperty("total_statenhancers_used")]
        public int TotalStatEnhancersUsed { get; set; }
    }
}
