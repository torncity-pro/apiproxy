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
    using System.Collections.Generic;

    public class Crime
    {
        [JsonProperty("crime_id")]
        public int CrimeId { get; set; }

        [JsonProperty("crime_name")]
        public string CrimeName { get; set; }

        [JsonProperty("participants")]
        public Dictionary<string, List<string>> Participants { get; set; }

        [JsonProperty("time_started")]
        public int TimeStarted { get; set; }

        [JsonProperty("time_ready")]
        public int TimeReady { get; set; }

        [JsonProperty("time_left")]
        public int TimeLeft { get; set; }

        [JsonPropertyAttribute("time_completed")]
        public int TimeCompleted { get; set; }

        [JsonProperty("initiated")]
        public bool Initiated { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("money_gain")]
        public int MoneyGain { get; set; }

        [JsonProperty("respect_gain")]
        public int RespectGain { get; set; }
    }
}