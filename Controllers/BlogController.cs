using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.API.Models;
using Blog.API.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        [HttpGet("{dateTime}")]
        public List<BlogPost> ListBlog(string dateTime)
        {
            BlogRepos BlogRepo = new BlogRepos("mongodb+srv://lol:lol@clusterone-5rfg7.mongodb.net/test?retryWrites=true&w=majority");
            var blog = BlogRepo.GetBlog(dateTime);
            return blog;
        }
    }
}
