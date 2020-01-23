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

    public class PersonalStats
    {
        [JsonProperty("useractivity")]
        public int UserActivity { get; set; }

        [JsonProperty("itemsbought")]
        public int ItemsNought { get; set; }

        [JsonProperty("pointsbought")]
        public int PointsBought { get; set; }

        [JsonProperty("itemsboughtabroad")]
        public int ItemsBoughtAbroad { get; set; }

        [JsonProperty("moneyinvested")]
        public long MoneyInvested { get; set; }

        [JsonProperty("investedprofit")]
        public long InvestedProfit { get; set; }

        [JsonProperty("trades")]
        public int Trades { get; set; }

        [JsonProperty("itemssent")]
        public int ItemsSent { get; set; }

        [JsonProperty("auctionsells")]
        public int ItemsAuctioned { get; set; }

        [JsonProperty("pointssold")]
        public int PointsSold { get; set; }

        [JsonProperty("attackswon")]
        public int AttacksWon { get; set; }

        [JsonProperty("attackslost")]
        public int AttacksLost { get; set; }

        [JsonProperty("attacksdraw")]
        public int AttacksStalemated { get; set; }

        [JsonProperty("bestkillstreak")]
        public int BestKillstreak { get; set; }

        [JsonProperty("killstreak")]
        public int CurrentKillStreak { get; set; }

        [JsonProperty("moneymugged")]
        public int MoneyMugged { get; set; }

        [JsonProperty("attacksstealthed")]
        public int AttacksStealthed { get; set; }

        [JsonProperty("attackhits")]
        public int attackhits { get; set; }

        [JsonProperty("attackmisses")]
        public int attackmisses { get; set; }

        [JsonProperty("attackdamage")]
        public int attackdamage { get; set; }

        [JsonProperty("attackcriticalhits")]
        public int attackcriticalhits { get; set; }

        [JsonProperty("respectforfaction")]
        public int respectforfaction { get; set; }

        [JsonProperty("onehitkills")]
        public int OneHitKills { get; set; }

        [JsonProperty("defendswon")]
        public int DefendsWon { get; set; }

        [JsonProperty("defendslost")]
        public int DefendsLost { get; set; }

        [JsonProperty("defendsstalemated")]
        public int DefendsStalemated { get; set; }

        [JsonProperty("bestdamage")]
        public int BestDamage { get; set; }

        [JsonProperty("roundsfired")]
        public int RoundsFired { get; set; }

        [JsonProperty("yourunaway")]
        public int yourunaway { get; set; }

        [JsonProperty("theyrunaway")]
        public int theyrunaway { get; set; }

        [JsonProperty("highestbeaten")]
        public int HighestLevelBeaten { get; set; }

        [JsonProperty("peoplebusted")]
        public int PeopleBusted { get; set; }

        [JsonProperty("failedbusts")]
        public int FailedBusts { get; set; }

        [JsonProperty("peoplebought")]
        public int PeopleBailed { get; set; }

        [JsonProperty("peopleboughtspent")]
        public int BailFees { get; set; }

        [JsonProperty("virusescoded")]
        public int VirusesCoded { get; set; }

        [JsonProperty("cityfinds")]
        public int CityFinds { get; set; }

        [JsonProperty("traveltimes")]
        public int TimesTraveled { get; set; }

        [JsonProperty("bountiesplaced")]
        public int BountiesPlaced { get; set; }

        [JsonProperty("bountiesreceived")]
        public int BountiesReceived { get; set; }

        [JsonProperty("revivesreceived")]
        public int RevivesReceived { get; set; }

        [JsonProperty("medicalitemsused")]
        public int MedicalItemsUsed { get; set; }

        [JsonProperty("trainsreceived")]
        public int trainsreceived { get; set; }

        [JsonProperty("totalbountyspent")]
        public int totalbountyspent { get; set; }

        [JsonProperty("meritsbought")]
        public int meritsbought { get; set; }

        [JsonProperty("logins")]
        public int logins { get; set; }

        [JsonProperty("mailssent")]
        public int mailssent { get; set; }

        [JsonProperty("friendmailssent")]
        public int friendmailssent { get; set; }

        [JsonProperty("factionmailssent")]
        public int factionmailssent { get; set; }

        [JsonProperty("companymailssent")]
        public int companymailssent { get; set; }

        [JsonProperty("spousemailssent")]
        public int spousemailssent { get; set; }

        [JsonProperty("largestmug")]
        public int largestmug { get; set; }

        [JsonProperty("rifhits")]
        public int rifhits { get; set; }

        [JsonProperty("piehits")]
        public int piehits { get; set; }

        [JsonProperty("slahits")]
        public int slahits { get; set; }

        [JsonProperty("mextravel")]
        public int mextravel { get; set; }

        [JsonProperty("soutravel")]
        public int soutravel { get; set; }

        [JsonProperty("chitravel")]
        public int chitravel { get; set; }

        [JsonProperty("cantravel")]
        public int cantravel { get; set; }

        [JsonProperty("dumpfinds")]
        public int dumpfinds { get; set; }

        [JsonProperty("dumpsearches")]
        public int dumpsearches { get; set; }

        [JsonProperty("itemsdumped")]
        public int itemsdumped { get; set; }

        [JsonProperty("daysbeendonator")]
        public int daysbeendonator { get; set; }

        [JsonProperty("jailed")]
        public int jailed { get; set; }

        [JsonProperty("hospital")]
        public int hospital { get; set; }

        [JsonProperty("bazaarcustomers")]
        public int bazaarcustomers { get; set; }

        [JsonProperty("bazaarsales")]
        public int bazaarsales { get; set; }

        [JsonProperty("bazaarprofit")]
        public int bazaarprofit { get; set; }

        [JsonProperty("revives")]
        public int revives { get; set; }

        [JsonProperty("grehits")]
        public int grehits { get; set; }

        [JsonProperty("caytravel")]
        public int caytravel { get; set; }

        [JsonProperty("smghits")]
        public int smghits { get; set; }

        [JsonProperty("networth")]
        public long networth { get; set; }

        [JsonProperty("auctionswon")]
        public int auctionswon { get; set; }

        [JsonProperty("missioncreditsearned")]
        public int missioncreditsearned { get; set; }

        [JsonProperty("contractscompleted")]
        public int contractscompleted { get; set; }

        [JsonProperty("dukecontractscompleted")]
        public int dukecontractscompleted { get; set; }

        [JsonProperty("argtravel")]
        public int argtravel { get; set; }

        [JsonProperty("japtravel")]
        public int japtravel { get; set; }

        [JsonProperty("missionscompleted")]
        public int missionscompleted { get; set; }

        [JsonProperty("hawtravel")]
        public int hawtravel { get; set; }

        [JsonProperty("bloodwithdrawn")]
        public int bloodwithdrawn { get; set; }

        [JsonProperty("dubtravel")]
        public int dubtravel { get; set; }

        [JsonProperty("classifiedadsplaced")]
        public int classifiedadsplaced { get; set; }

        [JsonProperty("axehits")]
        public int axehits { get; set; }

        [JsonProperty("weaponsbought")]
        public int weaponsbought { get; set; }

        [JsonProperty("shohits")]
        public int shohits { get; set; }

        [JsonProperty("drugsused")]
        public int drugsused { get; set; }

        [JsonProperty("cantaken")]
        public int cantaken { get; set; }

        [JsonProperty("exttaken")]
        public int exttaken { get; set; }

        [JsonProperty("opitaken")]
        public int opitaken { get; set; }

        [JsonProperty("consumablesused")]
        public int consumablesused { get; set; }

        [JsonProperty("candyused")]
        public int candyused { get; set; }

        [JsonProperty("alcoholused")]
        public int alcoholused { get; set; }

        [JsonProperty("energydrinkused")]
        public int energydrinkused { get; set; }

        [JsonProperty("nerverefills")]
        public int nerverefills { get; set; }

        [JsonProperty("organisedcrimes")]
        public int organisedcrimes { get; set; }

        [JsonProperty("xantaken")]
        public int xantaken { get; set; }

        [JsonProperty("stockpayouts")]
        public int stockpayouts { get; set; }

        [JsonProperty("overdosed")]
        public int overdosed { get; set; }

        [JsonProperty("traveltime")]
        public int traveltime { get; set; }

        [JsonProperty("boostersused")]
        public int boostersused { get; set; }

        [JsonProperty("territorytime")]
        public int territorytime { get; set; }

        [JsonProperty("victaken")]
        public int victaken { get; set; }

        [JsonProperty("h2hhits")]
        public int h2hhits { get; set; }

        [JsonProperty("bountiescollected")]
        public int bountiescollected { get; set; }

        [JsonProperty("totalbountyreward")]
        public int totalbountyreward { get; set; }

        [JsonProperty("attacksassisted")]
        public int attacksassisted { get; set; }

        [JsonProperty("lsdtaken")]
        public int lsdtaken { get; set; }

        [JsonProperty("pishits")]
        public int pishits { get; set; }

        [JsonProperty("switravel")]
        public int switravel { get; set; }

        [JsonProperty("rehabs")]
        public int rehabs { get; set; }

        [JsonProperty("rehabcost")]
        public int rehabcost { get; set; }

        [JsonProperty("booksread")]
        public int booksread { get; set; }

        [JsonProperty("heahits")]
        public int heahits { get; set; }

        [JsonProperty("awards")]
        public int awards { get; set; }

        [JsonProperty("spetaken")]
        public int spetaken { get; set; }

        [JsonProperty("lontravel")]
        public int lontravel { get; set; }

        [JsonProperty("chahits")]
        public int chahits { get; set; }

        [JsonProperty("refills")]
        public int refills { get; set; }

        [JsonProperty("racingpointsearned")]
        public int racingpointsearned { get; set; }

        [JsonProperty("raceswon")]
        public int raceswon { get; set; }
        
        [JsonProperty("racesentered")]
        public int racesentered { get; set; }
        
        [JsonProperty("racingskill")]
        public int racingskill { get; set; }
    }
}
