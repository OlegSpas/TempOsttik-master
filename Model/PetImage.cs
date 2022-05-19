using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PetImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Pet Pet { get; set; }

    }
}
