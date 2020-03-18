using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System;
using Blog.API.Models;

namespace Blog.API.Repos
{
    public class BlogRepos
    {
        private string ConnectionString { get; set; }
        public BlogRepos(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        private IMongoCollection<BlogPost> Initialize()
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase("BlogDB");
            var collection = database.GetCollection<BlogPost>("Blog");
            return collection;
        }
        public List<BlogPost> GetBlog(string dateTime)
        {
            IMongoCollection<BlogPost> collection = Initialize();
            var Dbcustomer = collection.Find<BlogPost>(x => x.Date == dateTime);
            return Dbcustomer.ToList();
        }
    }
}
