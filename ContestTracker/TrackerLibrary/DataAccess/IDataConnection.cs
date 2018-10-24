using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    //We need to specify what items need to be in this "contract"
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
