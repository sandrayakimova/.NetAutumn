using System;
using System.Collections;
using System.Collections.Generic;
namespace conproj
{
    class MainClass
    {
            
        public static void Main(string[] args)
        {
            int k = 0;
          
                Console.WriteLine("1->create \n" +
                                  "2->stat \n" +
                                  "3->list \n" +
                                  "4->find \n" +
                                  "5->edit \n" +
                                  "6->export csv \n" +
                                  "7->export xml" +
                                  "8->import csv \n" +
                                  "9->remove \n" +
                                  "10->purge \n" +
                                  "11->list with params \n" +
                                  "12->import xml \n" +
                                  "13->exit ");
          
                filecabinet Storage = new filecabinet();
            do
            {
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        {
                            Console.Write(">create ");
                            Storage.create();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine(">stat");
                            Storage.stat();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine(">list");
                            Storage.list();
                        }
                        break;
                    case 4:
                        {
                            Console.Write(">find");
                            Storage.find();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine(">edit");
                            Storage.edit();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine(">export csv");
                            Console.WriteLine("entry destfile");
                            string dest = Console.ReadLine();
                            CsvFileService cs = new CsvFileService();
                            cs.Export(dest,Storage.Store);
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine(">export csv");
                            Console.WriteLine("entry destfile");
                            string dest = Console.ReadLine();
                            CsvFileService cs = new CsvFileService();
                            Storage.Store=cs.Import(dest);
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine(">export xml");
                            Console.WriteLine("entry destfile");
                            string dest = Console.ReadLine();
                            XmlFileService xml = new XmlFileService();
                            xml.Export(dest, Storage.Store);
                        }
                        break;
                    case 9:
                        {
                            Console.Write(">remove");
                            Storage.remove();
                        }
                        break;
                    case 10:
                        {
                            Console.Write(">purge");
                            Storage.purge();
                        }
                        break;
                    case 11:
                        {
                            Console.Write(">list");
                            Storage.list1();
                        }
                        break;
                    case 12:
                        {
                            Console.Write(">importXml");
                            Console.WriteLine("entry destfile");
                            string dest = Console.ReadLine();
                            XmlFileService xml = new XmlFileService();
                            Storage.Store = xml.Import(dest);
                        }
                        break;
                    case 13:
                        {
                            Console.Write(">exit");
                        }
                        break;

                }

            } while (k != 13);
        }
    }
}
