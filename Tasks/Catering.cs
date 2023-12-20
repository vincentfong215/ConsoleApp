using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDnataApp.Tasks
{
    public class Catering
    {
        public bool DirectConnectSAP(bool mssql)
        {
            try
            {
                if (mssql)
                {
                    var rtnData = GetMSSQLData();
                    //Implement store data location TODO

                    return true;
                }
                else
                {
                    var rtnData = GetOracleData();
                    //Implement store data location TODO

                    return true;
                }
            }
            catch (Exception ex)
            {
            }
  

            return true;
        }

        public string GetMSSQLData()
        {
            List<List<string>> consolidatedData = new List<List<string>>();
            string conStr = @"Data Source=VINCENTCHFONG\SQLEXPRESS;Initial Catalog=FlightSchedule;Integrated Security=SSPI;TrustServerCertificate=True";
            using (var sqlconn = new SqlConnection(conStr))
            {
                var sqlQuery = "SELECT * FROM DailyFlight WHERE OriginAirport = 'SIN'";
                var command = new SqlCommand(sqlQuery, sqlconn);
                command.Connection.Open();
                var sqlDataReader = command.ExecuteReader();

                List<string> data = new List<string>();

                while (sqlDataReader.Read())
                {
                    var col2 = sqlDataReader.GetString(2);
                    data.Add(col2);
                    var col3 = sqlDataReader.GetDateTime(3);
                    data.Add(col3.ToString());

                    consolidatedData.Add(data);
                }
            }

            var rtnData = string.Join('|', consolidatedData);
            return rtnData;
        }

        public string GetOracleData()
        {
            return string.Empty; //Implement TODO
        }
    }
}
