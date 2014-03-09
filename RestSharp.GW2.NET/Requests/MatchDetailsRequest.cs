﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MatchDetailsRequest.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a request for details regarding the specified match, including the total score and further details for
//   each map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RestSharp.GW2DotNET.Requests
{
    using System.Threading;
    using System.Threading.Tasks;

    using global::GW2DotNET.V1.Core;

    using global::GW2DotNET.V1.Core.WorldVersusWorldInformation.Details;

    /// <summary>
    ///     Represents a request for details regarding the specified match, including the total score and further details for
    ///     each map.
    /// </summary>
    /// <remarks>
    ///     See <a href="http://wiki.guildwars2.com/wiki/API:1/wvw/match_details" /> for more information.
    /// </remarks>
    public class MatchDetailsRequest : ServiceRequest
    {
        #region Constructors and Destructors

        /// <summary>Initializes a new instance of the <see cref="MatchDetailsRequest"/> class.</summary>
        /// <param name="matchId">The match ID.</param>
        public MatchDetailsRequest(string matchId)
            : base(Resources.MatchDetails)
        {
            this.AddParameter("match_id", matchId);
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>Sends the current request and returns a response.</summary>
        /// <param name="serviceClient">The service client.</param>
        /// <returns>The response.</returns>
        public IServiceResponse<MatchDetails> GetResponse(IServiceClient serviceClient)
        {
            return this.GetResponse<MatchDetails>(serviceClient);
        }

        /// <summary>Sends the current request and returns a response.</summary>
        /// <param name="serviceClient">The service client.</param>
        /// <returns>The response.</returns>
        public Task<IServiceResponse<MatchDetails>> GetResponseAsync(IServiceClient serviceClient)
        {
            return this.GetResponseAsync<MatchDetails>(serviceClient);
        }

        /// <summary>Sends the current request and returns a response.</summary>
        /// <param name="serviceClient">The service client.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that provides cancellation support.</param>
        /// <returns>The response.</returns>
        public Task<IServiceResponse<MatchDetails>> GetResponseAsync(IServiceClient serviceClient, CancellationToken cancellationToken)
        {
            return this.GetResponseAsync<MatchDetails>(serviceClient, cancellationToken);
        }

        #endregion
    }
}