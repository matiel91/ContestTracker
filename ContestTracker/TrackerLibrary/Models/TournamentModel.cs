using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents name of tournament e.g "Office Cricet Tournament"
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents entry fee for take a part in tournament
        /// </summary>
        public decimal EntryFee { get; set; } //decimal type to be used for $$$
        /// <summary>
        /// Represents List of team which take a part in tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents prize list in tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represnet List of rounds which contain list of "match" for every round e.g.
        /// Round 1: (team1 :: team2), (team3 ::team4)
        /// Round 2: (team2 :: team 3)
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
