using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braveior.EntityFrameworkDemo.Repository.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
