using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braveior.EntityFrameworkDemo.Repository.Models
{
    public class Series : Production
    {
        public int NumberOfEpisodes { get; set; }

    }
}
