using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class BeastType : HardcodeDirectory
    {
        public virtual ICollection<BeastNote> BeastNotes { get; } = new List<BeastNote>();
    }
}
