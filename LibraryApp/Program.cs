using System;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book { Id = 1, Title = "Война и мир", Author = "Л. Толстой" });
            library.AddBook(new Book { Id = 2, Title = "Преступление и наказание", Author = "Ф. Достоевский" });

            Console.WriteLine("=== Сценарий 1: Выдача существующей книги ===");
            library.BorrowBook(1); 

            Console.WriteLine("\n=== Сценарий 2: Повторная выдача ===");
            library.BorrowBook(1); 

            Console.WriteLine("\n=== Сценарий 3: Возврат книги, которую не выдавали ===");
            library.ReturnBook(2); 

            Console.WriteLine("\n=== Сценарий 4: Выдача несуществующей книги ===");
            library.BorrowBook(99); 

            Console.ReadLine();
        }
    }
}