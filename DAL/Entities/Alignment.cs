using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Alignment : HardcodeDirectory
    {
        public int Law { get; set; }
        public int Goodness { get; set; }
        public virtual ICollection<BeastNote> BeastNotes { get; } = new List<BeastNote>();
    }
}
