using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;


namespace conproj
{
    public class filecabinet
    {
       List<File> store = new List<File>();
        public  List<File>Store { get; set; }

        public filecabinet()
        {
        }
        /// <summary>
        /// add new file to List
        /// </summary>
        public void create()
        {
            Console.Write("First name:");
            string n = Console.ReadLine();
            Console.Write("Last name:");
            string l = Console.ReadLine();
            Console.Write("Date of birth(yyyy.mm.dd):");
            string d = Console.ReadLine();
            Data dat = Data.Unstring(d);
            int i = store.Count;
            File f = new File(i, n, l, dat);
            Console.WriteLine($"Record #{i + 1} is created.");
            
            store.Add(f);
            
        }
        /// <summary>
        /// shows all Files at List
        /// </summary>
        public void list()
        {
            foreach (File f in store)
            {
                Console.WriteLine(f);
            }

        }
        /// <summary>
        /// Count how many Files at List
        /// </summary>
        public void stat()
        {
            int i  = store.Count;
            Console.WriteLine($"{i} records.");
        }
        /// <summary>
        /// private merhod
        /// finding with 1 param
        /// </summary>
        /// <param name="findstr"></param>
           void findsingl(string findstr)//сделать
        {
            
            string[] findmas = findstr.Split(' ');
            string Where = findmas[0];
            string What = findmas[1];
            What = What.Substring(1, What.Length - 2);
            List<File> findlist = new List<File>();
            switch (Where)
            {
                case "name":

                    findlist = store.FindAll(x => x.name.Contains(What));
                    break;
                    
                case "lastname":

                    findlist = store.FindAll(x => x.lastname.Contains(What));
                    break;
                case "date":

                    findlist = store.FindAll(x => x.date.ToString().Contains(What));
                    break;
                default:
                    Console.WriteLine("Something goes wrong");
                    break;

            }

            foreach (File l in findlist)
            {
                Console.WriteLine(l);
            }


        }
        /// <summary>
        /// finds with all entry params
        /// </summary>
        public void find()
        {
            string fin = Console.ReadLine();
            string[] finds = fin.Split(',');
            foreach (string fs in finds)
            {
                findsingl(fs);
            }

        }
        /// <summary>
        /// edit file when you entry it's id
        /// </summary>
        public void edit()
        {
            string ids = Console.ReadLine();
            ids = ids.Substring(1);
            int ided = 0;
            if (!Int32.TryParse(ids, out ided)) { throw new ArgumentException("invalid entry form"); }
            Console.Write("First name:");
            string n = Console.ReadLine();
            Console.Write("Last name:");
            string l = Console.ReadLine();
            Console.Write("Date of birth(yyyy.mm.dd):");
            string d = Console.ReadLine();
            Data dat = Data.Unstring(d);
            File f = new File(ided - 1, n, l, dat);
            store[ided - 1] = f;
        }
 /// <summary>
 /// delete file with entry id
 /// </summary>
        public  void remove()
        {
            string ids = Console.ReadLine();
            ids = ids.Substring(1);
            int ided = 0;
            if (!Int32.TryParse(ids, out ided)) { throw new ArgumentException("invalid entry form"); }
            store.Remove(store[ided - 1]);
          
        }
        /// <summary>
        /// delete all storage
        /// </summary>
       public void purge()
        {
            foreach (File f in store)
            {
                store.Remove(f);
            }
        }
      /// <summary>
      /// lis with params
      /// </summary>
        public void list1()
        {
            string l = Console.ReadLine();
            string[] par = l.Split(',');
            foreach (File f in store)
            {
                string str="";
                for (int j = 0; j < par.Length; j++)
                {
                    switch (par[j])
                    {
                        case "id":
                            str += $"#{f.id} ";
                            break;

                        case "name":
                            str += f.name + " ";
                            break;

                        case "lastname":
                            str += f.lastname + " ";

                            break;
                        case "date":
                            str += f.date.ToString() + " ";
                            break;
                        default:
                            Console.WriteLine("Something goes wrong");
                            break;
                    }
                    Console.WriteLine(str);
                }
                }
        }
       
    }

}
