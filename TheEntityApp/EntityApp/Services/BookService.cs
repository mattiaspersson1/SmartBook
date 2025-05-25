
using System.Collections.Generic;
using EntityApp.Models;

namespace EntityApp.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books = [];
        private int _nextId = 1;

        public List<Book> GetAll() => _books;

        public void Add(Book book)
        {
            book.Id = _nextId++;
            _books.Add(book);
        }
    }
}
