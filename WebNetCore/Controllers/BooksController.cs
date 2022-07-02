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
    public class BooksController : ControllerBase
    {
        private static List<Book> Books { get; set; }

        static BooksController()
        {
            Books = new List<Book>();
            Books.Add(new Book
            {
                Id = Guid.NewGuid(),
                Name = "Game of Thrones",
                AuthorName = "Jorge Martin",
                Pages = 415,
                Count = 802
            });
        }

        private readonly ILogger<BooksController> _logger;
        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Create(Book book)
        {
            book.Id = Guid.NewGuid();
            Books.Add(book);
        }

        [HttpGet]
        public IEnumerable<Book> GetAll()
        {
            return Books;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            Book product = Books.FirstOrDefault(user => user.Id == id);
            if (product != null)
            {
                return Ok(product);
            }
            else return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Book book)
        {
            var dbProduct = Books.FirstOrDefault(x => x.Id == book.Id);
            if (dbProduct != null)
            {
                var index = Books.IndexOf(dbProduct);
                Books[index] = book;
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            Book dbProduct = Books.FirstOrDefault(x => x.Id == id);
            if (dbProduct != null)
            {
                Books.Remove(dbProduct);

                return Ok(dbProduct);
            }
            else return NotFound();
        }
    }
}
