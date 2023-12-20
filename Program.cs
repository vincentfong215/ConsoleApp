using ConsoleDnataApp.Tasks;
using System;
using System.Threading;

namespace ConsoleDnataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Dnata!");

            Console.WriteLine("Press any key to continue.");
            var conInput = Console.ReadLine();

            Console.WriteLine("Enter options here for selection");
            Console.WriteLine("1. Catering, enter 1");
            Console.WriteLine("2. Ground Services, enter 2");
            Console.WriteLine("3. Cargo Applications, enter 3");
            Console.WriteLine("4. Resource Management System, enter 4");
            Console.WriteLine("5. Safety Applications, enter 5");

            var getDataSource = Console.ReadLine();

            if(!string.IsNullOrEmpty(getDataSource))
            {
                bool continueTask = false;
                if(getDataSource.Trim() == "1")
                {
                    //Implement task 1
                    var obj = new Catering();

                    do
                    {
                        Console.WriteLine("Enter options here for data source");
                        Console.WriteLine("1. MSSQL, enter 1");
                        Console.WriteLine("2. Oracle, enter 2");

                        var dataSourceSelected = Console.ReadLine();
                        bool mssqlSelected = false;

                        if (!string.IsNullOrEmpty(dataSourceSelected))
                        {
                            if (dataSourceSelected.Trim() == "1")
                            {
                                mssqlSelected = true;
                            }
                            else if (dataSourceSelected.Trim() == "2")
                            {
                                mssqlSelected = false;
                            }
                            else
                            {
                                Console.WriteLine("Input was wrong, exit program to retry");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadLine();
                            }

                            continueTask = obj.DirectConnectSAP(mssqlSelected);
                        }

                        if (continueTask == false)
                        {                       
                            break;
                        }
                        else
                        {
                            Thread.Sleep(10000); // Assumption 1 milisecond = 10 minutes
                            continueTask = obj.DirectConnectSAP(mssqlSelected);
                        }
                    } while (continueTask);                   
                }
                else if (getDataSource.Trim() == "2")
                {
                    do
                    {
                        //Implement task 2
                        var obj = new GroundServices();
                        continueTask = obj.XmlDataSource();

                        if (continueTask == false)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(5000); // Assumption 5 milisecond = 5 minutes
                            continueTask = obj.XmlDataSource();
                        }
                    } while (continueTask);                   
                }
                else if (getDataSource.Trim() == "3")
                {
                    do
                    {
                        //Implement task 3
                        var obj = new CargoApp();
                        continueTask = obj.ApiDataSource();

                        if (continueTask == false)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(5000); // Assumption 5 milisecond = 5 minutes
                            continueTask = obj.ApiDataSource();
                        }
                    } while (continueTask);
                }
                else if (getDataSource.Trim() == "4")
                {
                    do
                    {
                        //Implement task 4
                        var obj = new ManageResourceManagementSys();
                        continueTask = obj.AsciiDataSource();

                        if (continueTask == false)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(2000); // Assumption 2 milisecond = 2 minutes
                            continueTask = obj.AsciiDataSource();
                        }
                    } while (continueTask);
                }
                else if (getDataSource.Trim() == "5")
                {
                    do
                    {
                        //Implement task 5
                        var obj = new SafetyApps();
                        continueTask = obj.AsciiDataSource();
                        if (continueTask == false)
                        {
                            break;
                        }
                        else
                        {
                            Thread.Sleep(6000); // Assumption 6 milisecond = 6 hours
                            continueTask = obj.AsciiDataSource();
                        }
                    } while (continueTask);
                }
                else
                {
                    Console.WriteLine("Input was wrong, exit program to retry");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                }
            }
            
        }
    }
}
