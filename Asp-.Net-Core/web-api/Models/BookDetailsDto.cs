using System;

namespace web_api.Models
{
    public class BookDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
