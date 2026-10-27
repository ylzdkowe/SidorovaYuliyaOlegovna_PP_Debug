using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void BorrowBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                Console.WriteLine($"Ошибка: книга с ID {id} не найдена.");
                return;
            }

            if (!book.IsAvailable)
            {
                Console.WriteLine($"Ошибка: книга '{book.Title}' уже выдана.");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine($"Книга '{book.Title}' выдана.");
        }

        public void ReturnBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                Console.WriteLine($"Ошибка: книга с ID {id} не найдена.");
                return;
            }

            if (book.IsAvailable)
            {
                Console.WriteLine($"Ошибка: книга '{book.Title}' не была выдана.");
                return;
            }

            book.IsAvailable = true;
            Console.WriteLine($"Книга '{book.Title}' возвращена.");
        }

        public Book? FindBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}