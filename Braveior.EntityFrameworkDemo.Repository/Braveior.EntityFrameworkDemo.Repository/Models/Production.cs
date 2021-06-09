using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braveior.EntityFrameworkDemo.Repository.Models
{
    public abstract class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();

        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
