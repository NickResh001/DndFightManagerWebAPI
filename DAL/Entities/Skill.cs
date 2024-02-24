using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Skill
    {
        [Key]
        public string Id { get; set; } = null!;
        public string AbilityId { get; set; } = null!;
        public string Title { get; set; } = null!;


        public virtual Ability Ability { get; set; } = null!;
    }
}
