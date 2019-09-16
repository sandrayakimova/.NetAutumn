using System;
namespace conproj
{
    public class File
    {
         int _id;
         string _name;
         string _lastname;
        Data _date;// год - месяц - день


        public File(int id,string name,string lastname,Data date)
        {
            this._id = id;
            this._name = name;
            this._lastname= lastname;
            this._date = date;

        }
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string date { get; set; }


        public File()
        { }
        public override string ToString()
        {
            return "#" + (_id + 1) + ", " + _name + ", " + _lastname;
        }
        /// <summary>
        /// converts String to File
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static File Unstring(string s)
        {
            string[] strmas = s.Split('#', ',', ' ');

            int id;
            if (!Int32.TryParse(strmas[1], out id)) { throw new ArgumentException("invalid entry form"); }
            string name = strmas[3];
            string lastname = strmas[5];
            Data d = Data.Unstring(strmas[6]);
            File f = new File(id, name, lastname, d);
            return f;
        }
        /// <summary>
        /// method for saving information of the File to the documents
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static  string StringRow (File f)
        {
            return f + " " + f._date;
        }
        
    }
}
