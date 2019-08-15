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

    public class Merits
    {
        [JsonProperty("Nerve Bar")]
        public int NerveBar { get; set; }

        [JsonProperty("Critical Hit Rate")]
        public int CriticalHitRate { get; set; }

        [JsonProperty("Life Points")]
        public int LifePoints { get; set; }

        [JsonProperty("Crime Experience")]
        public int CrimeExperience { get; set; }

        [JsonProperty("Education Length")]
        public int EducationLength { get; set; }

        [JsonProperty("Awareness")]
        public int Awareness { get; set; }

        [JsonProperty("Bank Interest")]
        public int BankInterest { get; set; }

        [JsonProperty("Masterful Looting")]
        public int MasterfulLooting { get; set; }

        [JsonProperty("Stealth")]
        public int Stealth { get; set; }

        [JsonProperty("Hospitalizing")]
        public int Hospitalizing { get; set; }

        [JsonProperty("Brawn")]
        public int Brawn { get; set; }

        [JsonProperty("Protection")]
        public int Protection { get; set; }

        [JsonProperty("Sharpness")]
        public int Sharpness { get; set; }

        [JsonProperty("Evasion")]
        public int Evasion { get; set; }

        [JsonProperty("Heavy Artillery Mastery")]
        public int HeavyArtilleryMastery { get; set; }

        [JsonProperty("Machine Gun Mastery")]
        public int MachineGunMastery { get; set; }

        [JsonProperty("Rifle Mastery")]
        public int RifleMastery { get; set; }

        [JsonProperty("SMG Mastery")]
        public int SMGMastery { get; set; }

        [JsonProperty("Shotgun Mastery")]
        public int ShotgunMastery { get; set; }

        [JsonProperty("Pistol Mastery")]
        public int PistolMastery { get; set; }

        [JsonProperty("Club Mastery")]
        public int ClubMastery { get; set; }

        [JsonProperty("Piercing Mastery")]
        public int PiercingMastery { get; set; }

        [JsonProperty("Slashing Mastery")]
        public int SlashingMastery { get; set; }

        [JsonProperty("Mechanical Mastery")]
        public int MechanicalMastery { get; set; }

        [JsonProperty("Temporary Mastery")]
        public int TemporaryMastery { get; set; }
    }
}
