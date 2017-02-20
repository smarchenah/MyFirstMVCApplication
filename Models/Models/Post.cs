using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApplication.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}