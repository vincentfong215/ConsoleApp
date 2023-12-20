using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDnataApp.Tasks
{
    public class CargoApp
    {
        public bool ApiDataSource()
        {
            HttpClient httpClient = new HttpClient();

            var responseData = httpClient.GetAsync("https://www.dnata.com/en").Result;
            var rtnData = responseData.Content.ReadAsStringAsync();
            //Implement store data location TODO

            return true;
        }
    }
}
