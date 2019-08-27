using System;
namespace BOOK
{
    public class Book
    {
        public  int ISBN;
        public string author;
        public string name;
        public string publisher;
        public int year;
        public int pages;
        public int price;

     


        public Book(int ISBN,string author,string name,string publisher,int year,int pages,int price)
        {

            this.ISBN = ISBN;    
            this.author = author;
            this.name = name;
            this.publisher = publisher;
            this.year = year;
            this.pages = pages;
            this.price = price;

        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Book m = obj as Book; // возвращает null если объект нельзя привести к типу Book
            if (m as Book == null)
                return false;

            return (m.ISBN == this.ISBN) && (m.author == this.author) && (m.name == this.name) && (m.publisher==this.publisher)&& (m.year==this.year) &&(m.pages==this.pages) && (m.price==this.price);
        }

        public override string ToString()
        {
            string str;
            str = "ISBN:" + ISBN +
                "/n Author:" + author +
                "/n Name:" + name +
                "/n Publisher" + publisher +
                "/n Publication year:" + year+
                 "/n Pages:" + pages +
                "/n Price:" + price;
            return str;
        }
    }
}
