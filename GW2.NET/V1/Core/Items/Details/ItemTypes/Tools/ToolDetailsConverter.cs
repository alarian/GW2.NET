﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToolDetailsConverter.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts an instance of a class that extends  from its
//   representation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Core.Items.Details.ItemTypes.Tools
{
    using System;
    using System.Collections.Generic;

    using GW2DotNET.V1.Core.Common.Converters;
    using GW2DotNET.V1.Core.Items.Details.ItemTypes.Tools.ToolTypes;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>Converts an instance of a class that extends <see cref="ToolDetails" /> from its <see cref="System.String" />
    /// representation.</summary>
    public class ToolDetailsConverter : ContentBasedTypeCreationConverter
    {
        /// <summary>Backing field. Holds a dictionary of known JSON values and their corresponding type.</summary>
        private static readonly IDictionary<ToolType, Type> KnownTypes = new Dictionary<ToolType, Type>();

        /// <summary>Initializes static members of the <see cref="ToolDetailsConverter" /> class.</summary>
        static ToolDetailsConverter()
        {
            KnownTypes.Add(ToolType.Unknown, typeof(UnknownToolDetails));
            KnownTypes.Add(ToolType.Salvage, typeof(SalvageToolDetails));
        }

        /// <summary>Determines whether this instance can convert the specified object type.</summary>
        /// <param name="objectType">ToolType of the object.</param>
        /// <returns>Returns <c>true</c> if this instance can convert the specified object type; otherwise <c>false</c>.</returns>
        public override bool CanConvert(Type objectType)
        {
            return KnownTypes.Values.Contains(objectType);
        }

        /// <summary>Gets the object type that will be used by the serializer.</summary>
        /// <param name="objectType">The type of the object.</param>
        /// <param name="content">The JSON content.</param>
        /// <returns>Returns the target type.</returns>
        public override Type GetTargetType(Type objectType, JObject content)
        {
            var jsonToken = content["type"];

            if (jsonToken == null)
            {
                return typeof(UnknownToolDetails);
            }

            var jsonValue = jsonToken.Value<string>();

            try
            {
                ToolType type;

                if (!Enum.TryParse(jsonValue, true, out type))
                {
                    type = JsonSerializer.Create().Deserialize<ToolType>(jsonToken.CreateReader());
                }

                Type targetType;

                if (!KnownTypes.TryGetValue(type, out targetType))
                {
                    return typeof(UnknownToolDetails);
                }

                return targetType;
            }
            catch (JsonSerializationException)
            {
                return typeof(UnknownToolDetails);
            }
            finally
            {
                content.Remove("type");
            }
        }
    }
}