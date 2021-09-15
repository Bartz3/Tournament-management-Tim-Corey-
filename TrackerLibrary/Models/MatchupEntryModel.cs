using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// One team in Matchup 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Score for particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Matchup that this team came from as the winner. (Matchup from previous round)
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        
    }
}
