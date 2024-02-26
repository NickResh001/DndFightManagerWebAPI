using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<BeastNote> CreatedBeastNotes { get; } = new List<BeastNote>();
        public virtual ICollection<BeastNote> ModeratedBeastNotes { get; } = new List<BeastNote>();
        public virtual ICollection<Campaign> Campaigns { get; } = new List<Campaign>();
    }
}
