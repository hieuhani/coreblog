using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Coreblog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}