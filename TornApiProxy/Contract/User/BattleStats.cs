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

﻿using Newtonsoft.Json;

namespace TornApiProxy.Contract.User
{
    public class BattleStats
    {
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
    }
}
