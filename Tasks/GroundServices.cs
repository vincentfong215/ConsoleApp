using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleDnataApp.Tasks
{
    public class GroundServices
    {
        public bool XmlDataSource()
        {
            var dir = Directory.GetCurrentDirectory();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dir + "\\DataSource\\data.xml");

            var rtnData = xmlDoc.InnerText;
            //Implement store data location TODO

            return true;
        }
    }
}
