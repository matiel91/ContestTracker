using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents place number, e.g place number 1, place number 2
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// String representation of place name e.g place number 1 - "Winner" or "first place"
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents prize for taken place in cash
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents percentage part of total prizes for taken place
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}