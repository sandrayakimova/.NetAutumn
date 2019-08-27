using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace BOOK
{
    /// <summary>
    /// класс BoolListSrorage хранит в себе коллекию книг, добавляет, удаляет их, сортирует и находит нужные 
    /// </summary>
    public class BoolListStorage
    {
        public static  string fail = @"/Users/sandrayakimova/Projects/BOOK/BOOK";
         public  List<Book> bookstore= new List<Book>();

        
        public BoolListStorage(List<Book> bookstore) 
        {
            this.bookstore = bookstore;
        }

        public void AddBook(Book book)
        {
            if (exis(book)) { Console.WriteLine("эта книга уже есть в библиотеке"); }
            else
            {
                bookstore.Add(book);
            }
        }

        public void RemoveBook(Book book)
        {
            if (exis(book)==false) { Console.WriteLine("этой книги нет в библиотеке"); }
            else
            {
                bookstore.Remove(book);
            }
        }

        public void SortByTag()
        {

            Console.WriteLine("1->ISBN /n 2->автор /n 3->название /n 4->издательство /n 5->год изания /n 6->количество страниц /n 7-> цена");
            int k =Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    {
                        Console.WriteLine("книги отсортирован по ID");
                        var result = from book in bookstore
                                     orderby book.ISBN
                                     select book;
                        bookstore = (System.Collections.Generic.List<BOOK.Book>)result;
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("книги отсортирован по автору");
                        var result = from book in bookstore
                                     orderby book.author
                                     select book;
                        bookstore = (System.Collections.Generic.List<BOOK.Book>)result;
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("книги отсортированы по названию");
                        var result = from book in bookstore
                                     orderby book.name
                                     select book;
                        bookstore = (System.Collections.Generic.List<BOOK.Book>)result;
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("книги отсортированы по издательству");
                        var result = from book in bookstore
                                     orderby book.publisher
                                     select book;
                        bookstore = (System.Collections.Generic.List<BOOK.Book>)result;
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("книги отсортированы по году");
                        var result = from book in bookstore
                                     orderby book.year
                                     select book;
                        bookstore = (System.Collections.Generic.List<BOOK.Book>)result;
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("книги отсортированы по количеству страниц ");
                        var result = from book in bookstore
                                     orderby book.pages
                                     select book;
                        bookstore = (System.Collections.Generic.List<BOOK.Book>)result;
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("книги отсортированы по цене");
                        var result = from book in bookstore
                                     orderby book.price
                                     select book;
                        bookstore = (System.Collections.Generic.List<BOOK.Book>)result;
                    }
                    break;
                default:
                    Console.WriteLine("что-то пошло не так");
                    break;

            }
        }
        /// <summary>
        /// найти книгу в коллекции по критерию мы вводим сначала номер критерия который мы хотим найти 
        /// </summary>
        
        public void FindByTag()
        {
            Console.WriteLine("введите номер критерия");
            Console.WriteLine("1->ISBN /n 2->автор /n 3->название /n 4->издательство /n 5->год изания /n 6->количество страниц /n 7-> цена");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    {
                        Console.WriteLine("введите номер Id");
                        
                        int id = Convert.ToInt32(Console.ReadLine());
                        var selectedbooks = from t in bookstore // определяем каждый объект из teams как t
                                            where t.ISBN == id //фильтрация по критерию
                                            orderby t.ISBN
                                            // упорядочиваем по возрастанию
                                            select t; // выбираем объект

                        foreach (Book b in selectedbooks)
                            Console.WriteLine(b);
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("введите автора");
                        string aut = Console.ReadLine();
                        var selectedbooks = from t in bookstore // определяем каждый объект из teams как t
                                            where t.author == aut //фильтрация по критерию
                                            orderby t.author
                                            // упорядочиваем по возрастанию
                                            select t; // выбираем объект

                        foreach (Book b in selectedbooks)
                            Console.WriteLine(b);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("введите название");
                        string name = Console.ReadLine();
                        var selectedbooks = from t in bookstore // определяем каждый объект из teams как t
                                            where t.name == name //фильтрация по критерию
                                            orderby t.name

                                            // упорядочиваем по возрастанию
                                            select t; // выбираем объект

                        foreach (Book b in selectedbooks)
                            Console.WriteLine(b);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("введите издателя");
                        string pub = Console.ReadLine();
                        var selectedbooks = from t in bookstore // определяем каждый объект из teams как t
                                            where t.publisher == pub //фильтрация по критерию
                                            orderby t.publisher

                                            // упорядочиваем по возрастанию
                                            select t; // выбираем объект

                        foreach (Book b in selectedbooks)
                            Console.WriteLine(b);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("введите год издания ");
                        int yr = Convert.ToInt32(Console.ReadLine());
                        var selectedbooks = from t in bookstore // определяем каждый объект из teams как t
                                            where t.year == yr //фильтрация по критерию
                                            orderby t.year
                                            // упорядочиваем по возрастанию
                                            select t; // выбираем объект

                        foreach (Book b in selectedbooks)
                            Console.WriteLine(b);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("введите нужное количество страниц ");
                        int pg = Convert.ToInt32(Console.ReadLine());
                        var selectedbooks = from t in bookstore // определяем каждый объект из teams как t
                                            where t.pages == pg //фильтрация по критерию
                                            orderby t.pages
                                            // упорядочиваем по возрастанию
                                            select t; // выбираем объект

                        foreach (Book b in selectedbooks)
                            Console.WriteLine(b);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("введите цену");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var selectedbooks = from t in bookstore // определяем каждый объект из teams как t
                                            where t.ISBN == id //фильтрация по критерию
                                            orderby t.ISBN
                                            // упорядочиваем по возрастанию
                                            select t; // выбираем объект

                        foreach (Book b in selectedbooks)
                            Console.WriteLine(b);
                    }
                    break;
                default:
                    Console.WriteLine("что-то пошло не так");
                    break;


            }
        }
            
            
        
        /// <summary>
        /// метод exis смотрит была ли такая книга в коллекции или нет
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        

         bool exis(Book book)
        {
            foreach (Book b in bookstore)
            {
                if (book.Equals(b)) { return true; }
            }
            return false;
        }
        /// <summary>
        /// после того как ты все сделали мы все сохраняем в бинарный файл и при возможности можем из него что-то прочесть
        /// </summary>
        static FileStream destFile = new FileStream(fail, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        BinaryWriter writer = new BinaryWriter(destFile);
        public void save()
        {
            foreach (Book b in bookstore)
            {
                writer.Write(b.ISBN);
                writer.Write(b.author);
                writer.Write(b.name);
                writer.Write(b.publisher);
                writer.Write(b.year);
                writer.Write(b.pages);
                writer.Write(b.price);
            }
            writer.Close();
            destFile.Close();
        }

    }
}
