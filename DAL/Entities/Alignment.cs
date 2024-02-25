using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Alignment
    {
        [Key]
        public string Id { get; set; } = null!;
        public int Law { get; set; }
        public int Goodness { get; set; }
        public string Title { get; set; } = null!;
    }
}
