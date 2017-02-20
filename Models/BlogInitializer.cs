using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFirstMVCApplication.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            context.Posts.Add(new Post()
            {
                Author = "Sergio Marchena Herranz",
                Title = "Hello, INCAS!",
                Code = "hello-INCAS",
                Date = new DateTime(2016, 1, 29),
                Text = "Hi INCAS, das ist meine erste MVC Post!",
                Comments = new[] {
                    new Comment() { Author = "John Doe", Date = new DateTime(2005, 8,13), Text="Hey, this is great!" },
                    new Comment() { Author = "Peter Petersen", Date = new DateTime(2005, 8,14), Text="Good news! Keep writing, please :)" }
                }

            });
            context.Posts.Add(new Post()
            {
                Author = "Sergio Marchena Herranz",
                Title = "Second post",
                Code = "second-post",
                Date = new DateTime(2016, 1, 28),
                Text = "Sollte ich etwas schreiben oder? :)"
            });
            context.Posts.Add(new Post()
            {
                Author = "Sergio Marchena Herranz",
                Title = "Test post",
                Code = "test-post",
                Date = new DateTime(2016, 1, 27),
                Text = "Heute ist mein erste post! Willkommen)"
            });

            // Other seed data

            base.Seed(context);
        }
    }

}