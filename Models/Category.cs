using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Coreblog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post> Posts { get; set; }
    }
}
