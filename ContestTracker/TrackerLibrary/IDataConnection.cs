using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    //We need to specify what items need to be in this "contract"
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
