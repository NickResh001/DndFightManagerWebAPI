using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class DamageType : HardcodeDirectory
    {
        public virtual ICollection<DamageTendency> DamageTendencies { get; } = new List<DamageTendency>();
    }
}
