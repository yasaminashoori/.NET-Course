using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Models;
using web_api.Repository;

namespace web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _booksRepository;
        private readonly ILogger<BooksController> _logger;

        public BooksController(
            IBookRepository bookRepository,
            ILogger<BooksController> logger)
        {
            _booksRepository = bookRepository;
            _logger = logger;
        }

        //Route: /api/Books
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _booksRepository.GetAllBooks();
            return Ok(books);
        }

        //Route: /api/Books{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookDetailsById(int id)
        {
            var book = await _booksRepository.GetBookDetailsById(id);
            return Ok(book);
        }


        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody]CreateBookDto model)
        {
            var id = await _booksRepository.CreateBook(model);
            return Ok(id);
        }
        

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromBody]UpdateBookDto model, int id)
        {
            var result = await _booksRepository.UpdateBook(id, model);
            if (!result)
            {
                return BadRequest("This Book is not exist");
            }
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBook(int id)
        {
            var result = await _booksRepository.RemoveBook(id);
            if (!result)
            {
                return BadRequest("This Book is not exist");
            }
            return Ok(result);
        }

    }
}
