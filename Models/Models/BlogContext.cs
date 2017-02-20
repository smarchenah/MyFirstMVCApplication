using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFirstMVCApplication.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection") { }

        public DbSet<Post> Posts { get; set; }

    }
}