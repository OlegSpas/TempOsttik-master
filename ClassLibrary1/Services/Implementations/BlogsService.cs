using Infrastructure.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Implementations
{
    public class BlogsService : IBlogsService
    {
        private readonly IBlogsRepository _blogsRepository;

        public BlogsService(IBlogsRepository blogsRepository)
        {
            _blogsRepository = blogsRepository;
        }
        public List<Blog> GetBlogs()
        {
            return _blogsRepository.GetBlogs();
        }
        public void AddBlog(Blog newBlog)
        {
            _blogsRepository.AddBlog(newBlog);
        }
    }
}
