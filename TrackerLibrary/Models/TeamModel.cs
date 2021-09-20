using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Single team name.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Represents all team members from one team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    }
}
