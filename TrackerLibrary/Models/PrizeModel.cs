using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Id for the prize.
        /// </summary>
        public int Id { get; set; }
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
        public PrizeModel() { }
        public PrizeModel(string placeName,string placeNumber,string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercantageValue = 0;
            double.TryParse(prizePercentage, out prizePercantageValue);
            PrizePercentage = prizePercantageValue;

        }
    }
}
