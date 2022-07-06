using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreDAL
{
    public class LibraryRepasitory : ILibraryRepasitory
    {
        private readonly EFCoreDbContext _dbContext;
        public LibraryRepasitory(EFCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid Add(Library library)
        {
            library.Id = Guid.NewGuid();
            _dbContext.Libraries.Add(library);
            _dbContext.SaveChanges();

            return library.Id;
        }

        public List<Book> FindLocation(int radius)
        {
            //if(Library.XLocation > radius + 10 && Library.XLocation < radius - 10)&&
            //    (Library.YLocation > radius + 10 && Library.YLocation < radius - 10) &&
                return null;
        }

        public IEnumerable<Library> GetAll()
        {
            return _dbContext.Libraries.ToList();
        }
    }
}
