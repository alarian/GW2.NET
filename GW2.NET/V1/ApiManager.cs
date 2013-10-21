﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiManager.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   This is the one and only class that is directly instantiated
//   by the caller. All functionality is accessed through the
//   properties of this object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using GW2DotNET.V1.Guilds.DataProviders;
using GW2DotNET.V1.Infrastructure;
using GW2DotNET.V1.Items.DataProvider;
using GW2DotNET.V1.Maps.DataProvider;
using GW2DotNET.V1.World.DataProviders;

namespace GW2DotNET.V1
{
    using System.Collections.Generic;
    using System.Linq;

    using GW2DotNET.V1.Infrastructure.Logging;

    /// <summary>
    /// This is the one and only class that is directly instantiated
    /// by the caller. All functionality is accessed through the
    /// properties of this object.
    /// </summary>
    public class ApiManager : IApiManager
    {
        /// <summary>Backing field for the event logger.</summary>
        private readonly EventLogger logger;

        /// <summary>The build.</summary>
        private int build = -1;

        /// <summary>Backing field for the continent data.</summary>
        private ContinentData continentDataOld;

        /// <summary>Backing field for the map data.</summary>
        private MapsData mapDataOld;

        /// <summary>
        /// Backing field for Colours property
        /// </summary>
        private ColourData colourDataOld;

        /// <summary>
        /// Backing field for Events property
        /// </summary>
        private EventData eventDataOld;

        /// <summary>The floor data.</summary>
        private MapFloorData floorDataOld;

        /// <summary>
        /// Backing field for Guilds property
        /// </summary>
        private GuildData guildDataOld;

        /// <summary>
        /// Backing field for Items property
        /// </summary>
        private ItemData itemDataOld;

        /// <summary>
        /// Backing field for wvwMatches property
        /// </summary>
        private WvW.DataProvider matchData;

        /// <summary>
        /// Backing field for Recipes property
        /// </summary>
        private RecipeData recipeDataOld;

        /// <summary>
        /// Backing field for Worlds property
        /// </summary>
        private WorldData worldDataOld;

        /// <summary>
        /// Stores the language set by the constructor
        /// </summary>
        private Language language;

        /// <summary>Stores the instance of the guild data provider.</summary>
        private Guilds.DataProvider guildData;

        /// <summary>Initializes a new instance of the <see cref="ApiManager"/> class.</summary>
        public ApiManager()
        {
            this.language = Language.En;
            this.logger = new EventLogger();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiManager"/> class.
        /// </summary>
        /// <param name="language">
        /// The language for things such as world names.
        /// </param>
        public ApiManager(Language language)
        {
            this.language = language;
            this.logger = new EventLogger();
        }

        /// <summary>Gets the build.</summary>
        public int Build
        {
            get
            {
                if (this.build <= 0)
                {
                    this.GetLatestBuild();
                }

                return this.build;
            }
        }

        /// <summary>Gets or sets the language.</summary>
        /// <remarks>This property sets the language.
        /// This will also clear the complete cache
        /// so the user will get the data from the api in the set language.</remarks>
        public Language Language
        {
            get
            {
                return this.language;
            }

            set
            {
                this.ClearCache();

                this.language = value;
            }
        }

        /// <summary>Gets the logger.</summary>
        public EventLogger Logger
        {
            get
            {
                return this.logger;
            }
        }

        /// <summary>Gets the continent data.</summary>
        public ContinentData Continents
        {
            get
            {
                return this.continentDataOld ?? (this.continentDataOld = new ContinentData(this));
            }
        }



        /// <summary>Gets the floor data.</summary>
        public MapFloorData FloorData
        {
            get
            {
                return this.floorDataOld ?? (this.floorDataOld = new MapFloorData(this));
            }
        }

        /// <summary>Gets the maps data.</summary>
        public MapsData Maps
        {
            get
            {
                return this.mapDataOld ?? (this.mapDataOld = new MapsData(this));
            }
        }

        /// <summary>
        /// Gets the ColourData object.
        /// </summary>
        public ColourData Colours
        {
            get
            {
                return this.colourDataOld ?? (this.colourDataOld = new ColourData(this));
            }
        }

        /// <summary>
        /// Gets the EventData object.
        /// </summary>
        public EventData Events
        {
            get
            {
                return this.eventDataOld ?? (this.eventDataOld = new EventData(this));
            }
        }

        /// <summary>Gets the instance of the guild data provider.</summary>
        /// <remarks>This property is the entry point to the guild api.
        /// From here the user can access all the information the guild api has to offer.</remarks>
        /// <seealso cref="V1.Guilds.DataProvider"/>
        public Guilds.DataProvider GuildData
        {
            get
            {
                return this.guildData ?? (this.guildData = new Guilds.DataProvider(this));
            }
        }

        /// <summary>
        /// Gets the GuildData object.
        /// </summary>
        [Obsolete("This implementation of the guild api is obsolete. Please use the new GuildData property.")]
        public GuildData Guilds
        {
            get
            {
                return this.guildDataOld ?? (this.guildDataOld = new GuildData(this));
            }
        }

        /// <summary>
        /// Gets the ItemData object.
        /// </summary>
        [Obsolete("This implementation is currently broken and will be fixed in a future release.", true)]
        public ItemData Items
        {
            get
            {
                return this.itemDataOld ?? (this.itemDataOld = new ItemData(this));
            }
        }

        /// <summary>
        /// Gets the RecipeData object.
        /// </summary>
        public RecipeData Recipes
        {
            get
            {
                return this.recipeDataOld ?? (this.recipeDataOld = new RecipeData());
            }
        }

        /// <summary>Gets the instance of the world versus world data provider.</summary>
        /// /// <remarks>This property is the entry point to the world versus world api.
        /// From here the user can access all the information the world versus world api has to offer.</remarks>
        /// <seealso cref="V1.WvW.DataProvider"/>
        public WvW.DataProvider WvWMatchData
        {
            get
            {
                return this.matchData ?? (this.matchData = new WvW.DataProvider());
            }
        }

        /// <summary>
        /// Gets the WorldData object.
        /// </summary>
        public WorldData Worlds
        {
            get
            {
                return this.worldDataOld ?? (this.worldDataOld = new WorldData(this));
            }
        }

        /// <summary>
        /// Clears the cache for all data providers.
        /// WARNING! there is  no undo!
        /// </summary>
        public void ClearCache()
        {
            // Old way to clear the cache.
            this.colourDataOld = null;
            this.eventDataOld = null;
            this.itemDataOld = null;
            this.continentDataOld = null;
            this.floorDataOld = null;
            this.mapDataOld = null;
            this.recipeDataOld = null;
            this.worldDataOld = null;

            // New way
            this.WvWMatchData.ClearCache();
            this.GuildData.ClearCache();
        }

        /// <summary>Gets the latest build from the server.</summary>
        /// <remarks>
        /// This function will query the server for the current build. 
        /// After a query this method will return the current build to the user.
        /// It will also store the new build in the <see cref="Build"/> property and therefore cache it.
        /// </remarks>
        /// <returns>
        /// The latest build.
        /// </returns>
        public int GetLatestBuild()
        {
            this.build = ApiCall.GetContent<Dictionary<string, int>>("build.json", null, ApiCall.Categories.Miscellaneous).Values.Single();

            return this.build;
        }
    }
}