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
        public int timestamp { get; set; }

        [JsonProperty("users_total")]
        public int users_total { get; set; }

        [JsonProperty("users_male")]
        public int users_male { get; set; }

        [JsonProperty("users_female")]
        public int users_female { get; set; }

        [JsonProperty("users_marriedcouples")]
        public int users_marriedcouples { get; set; }

        [JsonProperty("users_daily")]
        public int users_daily { get; set; }

        [JsonProperty("total_users_logins")]
        public int total_users_logins { get; set; }

        [JsonProperty("total_users_playtime")]
        public string total_users_playtime { get; set; }

        [JsonProperty("job_army")]
        public int job_army { get; set; }

        [JsonProperty("job_grocer")]
        public int job_grocer { get; set; }

        [JsonProperty("job_medical")]
        public int job_medical { get; set; }

        [JsonProperty("job_casino")]
        public int job_casino { get; set; }

        [JsonProperty("job_education")]
        public int job_education { get; set; }

        [JsonProperty("job_law")]
        public int job_law { get; set; }

        [JsonProperty("job_company")]
        public int job_company { get; set; }

        [JsonProperty("job_none")]
        public int job_none { get; set; }

        [JsonProperty("crimes")]
        public int crimes { get; set; }

        [JsonProperty("jailed")]
        public int jailed { get; set; }

        [JsonProperty("money_onhand")]
        public long money_onhand { get; set; }

        [JsonProperty("money_average")]
        public int money_average { get; set; }

        [JsonProperty("money_citybank")]
        public long money_citybank { get; set; }

        [JsonProperty("items")]
        public int items { get; set; }

        [JsonProperty("events")]
        public int events { get; set; }

        [JsonProperty("points_total")]
        public int points_total { get; set; }

        [JsonProperty("points_market")]
        public int points_market { get; set; }

        [JsonProperty("points_averagecost")]
        public int points_averagecost { get; set; }

        [JsonProperty("points_bought")]
        public int points_bought { get; set; }

        [JsonProperty("total_points_boughttotal")]
        public int total_points_boughttotal { get; set; }

        [JsonProperty("total_attacks_won")]
        public int total_attacks_won { get; set; }

        [JsonProperty("total_attacks_lost")]
        public int total_attacks_lost { get; set; }

        [JsonProperty("total_attacks_stalemated")]
        public int total_attacks_stalemated { get; set; }

        [JsonProperty("total_attacks_runaway")]
        public int total_attacks_runaway { get; set; }

        [JsonProperty("total_attacks_hits")]
        public int total_attacks_hits { get; set; }

        [JsonProperty("total_attacks_misses")]
        public int total_attacks_misses { get; set; }

        [JsonProperty("total_attacks_criticalhits")]
        public int total_attacks_criticalhits { get; set; }

        [JsonProperty("total_attacks_roundsfired")]
        public int total_attacks_roundsfired { get; set; }

        [JsonProperty("total_attacks_stealthed")]
        public int total_attacks_stealthed { get; set; }

        [JsonProperty("total_attacks_moneymugged")]
        public long total_attacks_moneymugged { get; set; }

        [JsonProperty("total_attacks_respectgained")]
        public int total_attacks_respectgained { get; set; }

        [JsonProperty("total_items_marketbought")]
        public int total_items_marketbought { get; set; }

        [JsonProperty("total_items_bazaarbought")]
        public int total_items_bazaarbought { get; set; }

        [JsonProperty("total_items_auctionswon")]
        public int total_items_auctionswon { get; set; }

        [JsonProperty("total_items_sent")]
        public int total_items_sent { get; set; }

        [JsonProperty("total_trades")]
        public int total_trades { get; set; }

        [JsonProperty("total_items_bazaarincome")]
        public long total_items_bazaarincome { get; set; }

        [JsonProperty("total_items_cityfinds")]
        public int total_items_cityfinds { get; set; }

        [JsonProperty("total_items_dumpfinds")]
        public int total_items_dumpfinds { get; set; }

        [JsonProperty("total_items_dumped")]
        public int total_items_dumped { get; set; }

        [JsonProperty("total_jail_jailed")]
        public int total_jail_jailed { get; set; }

        [JsonProperty("total_jail_busted")]
        public int total_jail_busted { get; set; }

        [JsonProperty("total_jail_busts")]
        public int total_jail_busts { get; set; }

        [JsonProperty("total_jail_bailed")]
        public int total_jail_bailed { get; set; }

        [JsonProperty("total_jail_bailcosts")]
        public long total_jail_bailcosts { get; set; }

        [JsonProperty("total_hospital_trips")]
        public int total_hospital_trips { get; set; }

        [JsonProperty("total_hospital_medicalitemsused")]
        public int total_hospital_medicalitemsused { get; set; }

        [JsonProperty("total_hospital_revived")]
        public int total_hospital_revived { get; set; }

        [JsonProperty("total_mails_sent")]
        public int total_mails_sent { get; set; }

        [JsonProperty("total_mails_sent_friends")]
        public int total_mails_sent_friends { get; set; }

        [JsonProperty("total_mails_sent_faction")]
        public int total_mails_sent_faction { get; set; }

        [JsonProperty("total_mails_sent_company")]
        public int total_mails_sent_company { get; set; }

        [JsonProperty("total_mails_sent_spouse")]
        public int total_mails_sent_spouse { get; set; }

        [JsonProperty("total_classifiedads_placed")]
        public int total_classifiedads_placed { get; set; }

        [JsonProperty("total_bounty_placed")]
        public int total_bounty_placed { get; set; }

        [JsonProperty("total_bounty_rewards")]
        public long total_bounty_rewards { get; set; }

        [JsonProperty("total_travel_all")]
        public int total_travel_all { get; set; }

        [JsonProperty("total_travel_argentina")]
        public int total_travel_argentina { get; set; }

        [JsonProperty("total_travel_mexico")]
        public int total_travel_mexico { get; set; }

        [JsonProperty("total_travel_dubai")]
        public int total_travel_dubai { get; set; }

        [JsonProperty("total_travel_hawaii")]
        public int total_travel_hawaii { get; set; }

        [JsonProperty("total_travel_japan")]
        public int total_travel_japan { get; set; }

        [JsonProperty("total_travel_unitedkingdom")]
        public int total_travel_unitedkingdom { get; set; }

        [JsonProperty("total_travel_southafrica")]
        public int total_travel_southafrica { get; set; }

        [JsonProperty("total_travel_switzerland")]
        public int total_travel_switzerland { get; set; }

        [JsonProperty("total_travel_china")]
        public int total_travel_china { get; set; }

        [JsonProperty("total_travel_canada")]
        public int total_travel_canada { get; set; }

        [JsonProperty("total_travel_caymanislands")]
        public int total_travel_caymanislands { get; set; }

        [JsonProperty("total_drugs_used")]
        public int total_drugs_used { get; set; }

        [JsonProperty("total_drugs_overdosed")]
        public int total_drugs_overdosed { get; set; }

        [JsonProperty("total_drugs_cannabis")]
        public int total_drugs_cannabis { get; set; }

        [JsonProperty("total_drugs_ecstacy")]
        public int total_drugs_ecstacy { get; set; }

        [JsonProperty("total_drugs_ketamine")]
        public int total_drugs_ketamine { get; set; }

        [JsonProperty("total_drugs_lsd")]
        public int total_drugs_lsd { get; set; }

        [JsonProperty("total_drugs_opium")]
        public int total_drugs_opium { get; set; }

        [JsonProperty("total_drugs_shrooms")]
        public int total_drugs_shrooms { get; set; }

        [JsonProperty("total_drugs_speed")]
        public int total_drugs_speed { get; set; }

        [JsonProperty("total_drugs_pcp")]
        public int total_drugs_pcp { get; set; }

        [JsonProperty("total_drugs_xanax")]
        public int total_drugs_xanax { get; set; }

        [JsonProperty("total_drugs_vicodin")]
        public int total_drugs_vicodin { get; set; }

        [JsonProperty("total_merits_bought")]
        public int total_merits_bought { get; set; }

        [JsonProperty("total_refills_bought")]
        public int total_refills_bought { get; set; }

        [JsonProperty("total_company_trains")]
        public int total_company_trains { get; set; }

        [JsonProperty("total_statenhancers_used")]
        public int total_statenhancers_used { get; set; }
    }
}
