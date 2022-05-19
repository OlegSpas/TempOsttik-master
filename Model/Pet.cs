using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Sex { get; set; }
        public string Size { get; set; }  
        public string Age { get; set; } 
        public string Description { get; set; }
        public virtual ICollection<PetImage> Images { get; set; }
    }
}
