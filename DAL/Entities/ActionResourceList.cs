using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ActionResourceList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public string ActionResourceId { get; set; } = null!;
        public bool Available { get; set; }

        public Beast Beast { get; set; } = null!;
        public ActionResource ActionResource { get; set; } = null!;
    }
}
