using CoreDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBL
{
    class LibrariesService : ILibrariesService
    {
        private readonly ILibraryRepasitory _libraryRepository;

        public LibrariesService(ILibraryRepasitory libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }
        public Guid AddBook(Library library)
        {

            return _libraryRepository.Add(library);
        }

        public IEnumerable<Library> GetAllBooks()
        {
            return _libraryRepository.GetAll();
        }
    }
}
