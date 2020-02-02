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

namespace TornApiProxy.Contract.Shared
{
	using System;

	[Flags]
	public enum Company
	{
		lookup = 0,
		timestamp = 1,
		detailed,
		employees,
		news,
		newsfull,
		profile,
		stock,
	}

	[Flags]
	public enum Faction
	{
		lookup = 0,
		timestamp = 1,
		armor,
		armorynews,
		armorynewsfull,
		attacknews,
		attacknewsfull,
		attacks,
		attacksfull,
		basic,
		boosters,
		cesium,
		chain,
		chains,
		contributors,
		crimenews,
		crimenewsfull,
		crimes,
		currency,
		donations,
		drugs,
		fundsnews,
		fundsnewsfull,
		mainnews,
		mainnewsfull,
		medical,
		membershipnews,
		membershipnewsfull,
		revives,
		revivesfull,
		stats,
		temporary,
		territory,
		upgrades,
		weapons,
	}

	[Flags]
	public enum Item
	{
		lookup = 0,
		timestamp = 1,
		bazaar,
		itemmarket,
		pointsmarket,
	}

	[Flags]
	public enum Property
	{
		lookup = 0,
		timestamp = 1,
		property,
	}

	[Flags]
	public enum Torn
	{
		lookup = 0,
		timestamp = 1,
		bank,
		companies,
		education,
		factiontree,
		gyms,
		honors,
		items,
		medals,
		organisedcrimes,
		properties,
		rackets,
		stats,
		stocks,
		territory,
	}

	[Flags]
	public enum User
	{
		lookup = 0,
		timestamp = 1,
		ammo,
		attacks,
		attacksfull,
		bars,
		basic,
		battlestats,
		bazaar,
		cooldowns,
		crimes,
		discord,
		display,
		education,
		events,
		gym,
		hof,
		honors,
		icons,
		inventory,
		jobpoints,
		medals,
		merits,
		messages,
		money,
		networth,
		notifications,
		perks,
		personalstats,
		profile,
		properties,
		refills,
		revives,
		revivesfull,
		stocks,
		travel,
		weaponexp,
		workstats,
	}

}
