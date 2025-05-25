
using System.Collections.Generic;
using EntityApp.Models;

namespace EntityApp.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        void Add(Book book);
    }
}
