using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
    
        [Required]
        public string Name { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
