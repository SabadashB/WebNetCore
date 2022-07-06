﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDAL;
using CoreBL;

namespace WebNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]  
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService, ILogger<BooksController> logger)
        {
            _booksService = booksService;
            _logger = logger;
        }



        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            try
            {
                var result = _booksService.AddBook(book);

                return Created(result.ToString(), book);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IEnumerable<Book> GetAll()
        {
            return _booksService.GetAllBooks();
        }

        [HttpGet("{id}")]
        public Book GetBookById(Guid id)
        {
            return _booksService.GetBookById(id);
        }

        [HttpPut("{id}")]
        public bool UpdateBook(Guid id, Book book)
        {
            book.Id = id;

            return _booksService.UpdateBook(book);
        }

        [HttpDelete("{id}")]
        public bool DeleteBook(Guid id)
        {
            return _booksService.DeleteBookById(id);
        }
    }
}
