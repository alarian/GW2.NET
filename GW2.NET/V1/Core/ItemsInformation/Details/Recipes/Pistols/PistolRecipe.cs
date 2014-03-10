﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PistolRecipe.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about a pistol crafting recipe.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Recipes.Pistols
{
    using GW2DotNET.V1.Core.Converters;

    using Newtonsoft.Json;

    /// <summary>
    ///     Represents detailed information about a pistol crafting recipe.
    /// </summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class PistolRecipe : Recipe
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PistolRecipe" /> class.
        /// </summary>
        public PistolRecipe()
            : base(RecipeType.Pistol)
        {
        }
    }
}