using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Fee that single contestant brings to the pot.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of enterned teams.
        /// </summary>
        public List<TeamModel> EnternedTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes in the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Rounds of the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
