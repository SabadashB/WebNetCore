using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDAL
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(Guid id);
        bool DeleteById(Guid id);
        bool Update(Book book);
        Guid Add(Book book);
    }
}
