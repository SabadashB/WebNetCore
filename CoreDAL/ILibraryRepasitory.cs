using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDAL
{
    public interface ILibraryRepasitory
    {
        Guid Add(Library library);
        IEnumerable<Library> GetAll();
        List<Book> FindLocation(int radius);

    }
}
