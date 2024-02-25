using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ActionThrow
    {
        [Key]
        public string Id { get; set; } = null!;
        public string ActionId { get; set; } = null!;
        public string? Title { get; set; }
        public string Throw { get; set; } = null!;

        public virtual Action Action { get; set; } = null!;

    }
}
