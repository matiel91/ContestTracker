using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
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
    }
}