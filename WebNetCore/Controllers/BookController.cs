using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]  
    public class BookController : ControllerBase
    {
        private static List<Books> Books { get; set; }

        static BookController()
        {
            Books = new List<Books>();
            Books.Add(new Books
            {
                Id = Guid.NewGuid(),
                Name = "Game of Thrones",
                AuthorName = "Jorge Martin",
                Pages = 415,
                Count = 802
            });
        }

        private readonly ILogger<BookController> _logger;
        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Create(Books book)
        {
            book.Id = Guid.NewGuid();
            Books.Add(book);
        }

        [HttpGet]
        public IEnumerable<Books> Get()
        {
            return Books;
        }

        [HttpPut("{id}")]
        public void Update(int id, Books weatherForecast)
        {
            Books[id] = weatherForecast;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Books.Remove(Books[id]);
        }

        [HttpGet("{id}")]
        public Books GetById(int id)
        {
            return Books.First();
        }
    }
}
