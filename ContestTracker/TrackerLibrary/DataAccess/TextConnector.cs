using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModel.csv"; //name of file as const - first name letter UPPERCASE
        
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file
            //Convert the list to List<PrizeModel>
            //below use the extension method. Read last record from file
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            //Find the max ID
            int currentId = 1; //initial id (0+1) (same like in if statement below)
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;//Order by descending, select first PrizeModel.Id and add 1 = new id record.
            }
            //assing new id to new model
            model.Id = currentId;
            //increase current id by one in case adding more then one item to database
            //currentId += 1;
            //Add the new record with the new ID
            prizes.Add(model);
            //Convert the prizes to list<string>
            //Save the list<string> to the text file     
            prizes.SaveToPrizeModel(PrizesFile); // it's overrideng existing file
            return model;
        }
    }
}
