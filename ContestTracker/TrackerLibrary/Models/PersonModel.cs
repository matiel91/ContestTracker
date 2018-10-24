using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents first name of the person/player
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents last name of the person/player
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents email adress of person/player,
        /// which can be used for further communication
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// Represents cellphone number of the player,
        /// can be used for further texting
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
