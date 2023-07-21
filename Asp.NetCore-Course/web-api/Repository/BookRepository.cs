using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_api.Data;
using web_api.Models;

namespace web_api.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<BookDetailsDto>> GetAllBooks()
        {
            var books = await _context.Books
                            .Select(x => new BookDetailsDto()
                            {
                                Id = x.Id,
                                Amount = x.Amount,
                                Description = x.Description,
                                Title = x.Title
                            }).ToListAsync();
            return books;
        }

        public async Task<BookDetailsDto> GetBookDetailsById(int id)
        {
            var book = await _context.Books.Where(x => x.Id == id)
                                    .Select(x => new BookDetailsDto()
                                    {
                                        Id = x.Id,
                                        Amount = x.Amount,
                                        Description = x.Description,
                                        Title = x.Title
                                    }).FirstOrDefaultAsync();
            return book;
        }

        public async Task<int> CreateBook(CreateBookDto model)
        {
            var book = new Book()
            {
                Amount = model.Amount,
                Description = model.Description,
                Title = model.Title,
            };

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }

        public async Task<bool> UpdateBook(int id, UpdateBookDto model)
        {
            var book = await _context.Books.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (book != null)
            {
                // _context.Books.Update(book);
                book.Title = model.Title;
                book.Amount = model.Amount;
                book.Description = model.Description;
                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }


        public async Task<bool> RemoveBook(int id)
        {
            // var book = new Book() {Id = id};
            // _context.Books.Remove(book);
            // await _context.SaveChangesAsync();
            var book = await _context.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

    }
}
