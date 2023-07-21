using System;

namespace web_api.Models
{
    public class UpdateBookDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
