using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
//  @PlaceNumber int,
//	@PlaceName nvarchar(100),
//	@PrizeAmount money,
//  @PrizePercentage float,
//	@id int = 0 output
namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //TODO - Error handling for SQL connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);//var in database, var in PrizeModel
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                //System.Collections.Generic.KeyNotFoundException - connection direction was not setted for id parameter,
                //variable @Id should start from lowercase @id 
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id"); //assing ID after execution of stored procedure

                return model;
            }
        }
    }
}
