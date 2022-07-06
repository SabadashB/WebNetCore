using CoreDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBL
{
    interface ILibrariesService
    {
        IEnumerable<Library> GetAllBooks();
        Guid AddBook(Library library);
    }
}
