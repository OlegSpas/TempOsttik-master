using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class BlogsRepository : IBlogsRepository
    {
        private readonly PritulokDBContext _dBContext;

        public BlogsRepository(PritulokDBContext dbContext)
        {
            _dBContext = dbContext;
        }

        public List<Blog> GetBlogs()
        {
            return _dBContext.Blogs.ToList();
        }
        public void AddBlog(Blog newBlog)
        {
            _dBContext.Blogs.Add(newBlog);
            _dBContext.SaveChanges();
        }
    }
}
