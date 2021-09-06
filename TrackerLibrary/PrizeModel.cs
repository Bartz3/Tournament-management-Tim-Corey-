using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Number of place taken by the team.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of the place taken by the team.
        /// </summary>
        public string  PlaceName { get; set; }
        /// <summary>
        /// Prize that team won from tournament.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// A percentage of the money in the pot that teams will split.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
