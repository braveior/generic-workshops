using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braveior.EntityFrameworkDemo.Repository.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public string Source { get; set; }

        public int Stars { get; set; }

        public int ProductionId { get; set; }

        public Production Production { get; set; }

        public User User { get; set; }

        public int? UserId { get; set; }

    }
}
