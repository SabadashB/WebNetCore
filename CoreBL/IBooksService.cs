using CoreDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBL
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(Guid id);
        bool DeleteBookById(Guid id);
        bool UpdateBook(Book book);
        Guid AddBook(Book book);
    }
}
