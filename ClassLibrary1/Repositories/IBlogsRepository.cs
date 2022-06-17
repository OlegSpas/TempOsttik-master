using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IBlogsRepository
    {
        public List<Blog> GetBlogs();
        public void AddBlog(Blog newBlog);
    }
}
