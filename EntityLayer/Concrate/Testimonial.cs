using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Testimonial
    {

        public int TestomonialID { get; set; }
        public string ClientName { get; set; }
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
