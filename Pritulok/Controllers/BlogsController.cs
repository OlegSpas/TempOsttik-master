using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Pritulok.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogsService _blogsService;
        public BlogsController(IBlogsService blogsService)
        {
            _blogsService = blogsService;
        }

        [HttpGet]
        public IEnumerable<Blog> GetAll()
        {
            return _blogsService.GetBlogs().ToArray();
        }
        [HttpPost]
        public void AddBlog(Blog newBlog)
        {
            _blogsService.AddBlog(newBlog);
        }

    }
}
