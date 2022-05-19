using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Users")]
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
