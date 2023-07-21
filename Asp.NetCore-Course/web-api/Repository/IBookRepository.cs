using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using web_api.Models;

namespace web_api.Repository
{
    public interface IBookRepository
    {
        Task<List<BookDetailsDto>> GetAllBooks();

        Task<BookDetailsDto> GetBookDetailsById(int id);

        Task<int> CreateBook(CreateBookDto model);

        Task<bool> UpdateBook(int id, UpdateBookDto model);

        Task<bool> RemoveBook(int id);
    }
}
