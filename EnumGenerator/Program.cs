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

namespace EnumGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using TornApiProxy;
    using TornApiProxy.Contract.Shared;
    using TornApiProxy.Fields;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var proxy = new TornHttpProxy(args[0]);
            var userLookup = await proxy.GetUserPropertiesAsync(string.Empty, UserField.Lookup).ConfigureAwait(false);
            var factionLookup = await proxy.GetFactionPropertiesAsync(string.Empty, FactionField.Lookup).ConfigureAwait(false);
            var itemLookup = await proxy.GetItemMarketListingsAsync(string.Empty, ItemField.Lookup).ConfigureAwait(false);
            var tornLookup = await proxy.GetTornPropertiesAsync(string.Empty, TornField.Lookup).ConfigureAwait(false);
            var propertyLookup = await proxy.GetPropertyPropertiesAsync(string.Empty, PropertyField.Lookup).ConfigureAwait(false);
            var companyLookup = await proxy.GetCompanyPropertiesAsync(string.Empty, CompanyField.Lookup).ConfigureAwait(false);

            var lookups = new Dictionary<string, PropertyBagBase>();
            lookups["User"] = userLookup;
            lookups["Faction"] = factionLookup;
            lookups["Item"] = itemLookup;
            lookups["Torn"] = tornLookup;
            lookups["Property"] = propertyLookup;
            lookups["Company"] = companyLookup;

            string license;
            using (StreamReader licenseFile = new StreamReader("..\\..\\..\\..\\license_header.txt"))
            {
                license = await licenseFile.ReadToEndAsync();
            }

            using (StreamWriter enumFile = new StreamWriter("..\\..\\..\\..\\TornApiProxy\\Contract\\Shared\\SelectionEnums.cs", false))
            {
                enumFile.Write(license);
                enumFile.WriteLine("namespace TornApiProxy.Contract.Shared");
                enumFile.WriteLine("{");
                enumFile.WriteLine("\tusing System;");
                enumFile.WriteLine("");

                foreach (var lookup in lookups.OrderBy(i => i.Key))
                {
                    enumFile.WriteLine("\t[Flags]");
                    enumFile.WriteLine("\tpublic enum {0}", lookup.Key);
                    enumFile.WriteLine("\t{");
                    enumFile.WriteLine("\t\tlookup = 0,");
                    enumFile.WriteLine("\t\ttimestamp = 1,");

                    foreach (var selection in lookup.Value.Selections.OrderBy(i => i).Where(i => !"timestamp".Equals(i, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        enumFile.WriteLine("\t\t{0},", selection);
                    }

                    enumFile.WriteLine("\t}");
                    enumFile.WriteLine();
                }
                enumFile.WriteLine("}");
            }
        }
    }
}
