using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// List of matchups which have taken place in the tournament.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Winner of the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Number of the round in which the match is played 
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
