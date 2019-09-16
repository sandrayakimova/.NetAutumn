using System;
namespace conproj
{
    public class Data
    {
        public int day, month, year;
        public Data(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            string datstr=null;
            datstr += year;
            datstr += ".";
            if (month<10) { datstr += "0"; }
            datstr += month;
            datstr += ".";
            if (day < 10) { datstr += "0"; }
            datstr += day;
            return datstr;
        }
        
        public  static Data Unstring(string d)
        {
            string y = d.Substring(0, 4);
            string m = d.Substring(5, 2);
            string dy = d.Substring(8);
            int iday, im=0, iy=0;
            if (!Int32.TryParse(dy, out iday)) { throw new ArgumentException("invalid entry form"); }
            if (!Int32.TryParse(m, out im)) { throw new ArgumentException("invalid entry form"); }
            if (!Int32.TryParse(y, out iy)) { throw new ArgumentException("invalid entry form"); }
            Data dat = new Data(iday, im, iy);
            return dat;
        }
    }
}
