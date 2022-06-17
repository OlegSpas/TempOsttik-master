using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Blogs")]
    public partial class Blog
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public string BlogType { get; set; }
        public string Message { get; set; }
    }
}
