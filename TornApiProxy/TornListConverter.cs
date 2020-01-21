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

namespace TornApiProxy
{
    using Newtonsoft.Json;
    using Contract.Shared;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a converter that can convert those weird api results into a list
    /// </summary>
    /// <typeparam name="T">The base object of the weird list to be used in the new list</typeparam>
    public class TornListConverter<T> : JsonConverter<List<T>> where T : ApiListItem, new()
    {
        public override List<T> ReadJson(JsonReader reader, Type objectType, List<T> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (existingValue == null)
            {
                existingValue = new List<T>();
            }

            int StartingDepth = reader.Depth;
            while (reader.Read() && reader.Depth > StartingDepth)
            {
                T entry = new T();
                entry.Id = (string)reader.Value;
                reader.Read();
                serializer.Populate(reader, entry);
                existingValue.Add(entry);
            }

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, List<T> value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            foreach (var name in value)
            {
                writer.WritePropertyName(name.Id);
                serializer.Serialize(writer, name);
            }
            writer.WriteEndObject();
        }
    }
}
