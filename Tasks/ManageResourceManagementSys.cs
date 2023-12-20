using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDnataApp.Tasks
{
    public class ManageResourceManagementSys
    {
        public bool AsciiDataSource()
        {
            var dir = Directory.GetCurrentDirectory();
            var rtnData = File.ReadAllText(dir + "\\DataSource\\fileData.txt");
            //Implement store data location TODO

            return true;
        }
    }
}
