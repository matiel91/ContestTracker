using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); //new in c#6- we can initialize property here
        /// <summary>
        /// Represents name of team
        /// </summary>
        public string TeamName { get; set; }
    }
}
