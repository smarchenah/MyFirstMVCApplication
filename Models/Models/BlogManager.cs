using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFirstMVCApplication.Models
{
    public class BlogManager : IDisposable
    {
        BlogContext _data = new BlogContext();

        /// <summary>
        /// Get a list with the latest post according of the property max
        /// </summary>
        /// <param name="max">Number of post to get</param>
        /// <returns>List of the post</returns>
        public IEnumerable<Post> GetLatestPosts(int max)
        {
            var posts = from post in _data.Posts
                        orderby post.Date descending
                        select post;
            return posts.Take(max).ToList();
        }

        /// <summary>
        /// Get a list with the post according to an specific date
        /// </summary>
        /// <param name="year">Year of the post</param>
        /// <param name="month">Month of the post</param>
        /// <returns>List of the post</returns>
        public IEnumerable<Post> GetPostsByDate(int year, int month)
        {
            var posts = from post in _data.Posts
                        where post.Date.Month == month && post.Date.Year == year
                        orderby post.Date descending
                        select post;
            return posts.ToList();
        }

        /// <summary>
        /// Get a post according to his Code
        /// </summary>
        /// <param name="code">Code of the post</param>
        /// <returns>Post</returns>
        public Post GetPost(string code)
        {
            //Include de Comments of the post ( .Include(p=>p.Comments) )
            return _data.Posts.Include(p=>p.Comments).FirstOrDefault(post => post.Code == code);
        }

        public void Dispose()
        {
            _data.Dispose();
        }
    }
}
