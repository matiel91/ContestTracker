using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers //this .TextConnector allow use of extension method only after using this namespace
{
    public static class TextConnectorProcessor
    {
        
        /// <summary>
        /// Method will take file name (i.e. PrizeModel) and return full path
        /// </summary>
        /// <param name="fileName">Name of File</param>
        /// <returns>Full path to File</returns>
        public static string FullFilePath(this string fileName) //extension method
        {
            //i.e C:\WORK SPACE C#\Projekty\ContestTracker Repo\ContestTracker\Data\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        /// <summary>
        /// Loading file and save lines to List
        /// </summary>
        /// <param name="file">Full file path</param>
        /// <returns>List of lines in file</returns>
        public static List<string> LoadFile(this string file)
        {
            //check if the file exist
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        /// <summary>
        /// Convert List of lines from file to PrizeModel
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(','); //WHAT IF?? what if user enter coma separated data by mistake?
                //TODO - eliminate possibillities of mistakes for reading data enetered by USER
                PrizeModel p = new PrizeModel();
                //Id - if data is not correct then this will crus the application
                p.Id = int.Parse(columns[0]);
                p.PlaceNumber = int.Parse(columns[1]);
                p.PlaceName = columns[2];
                p.PrizeAmount = decimal.Parse(columns[3]);
                p.PrizePercentage = double.Parse(columns[4]);
                //Add to final PrizeModel data list
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeModel(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        //TextConnector
        //* Load the text file
        //*Convert the list to List<PrizeModel>
        //Find the max ID
        //Add the new record with the new ID
        //Convert the prizes to list<string>
        //Save the list<string> to the text file
    }
}
