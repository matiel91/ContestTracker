using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents list of two competiting teams "match"
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents number of matchup round
        /// </summary>
        public int MatchupRound { get; set; }
    }
}