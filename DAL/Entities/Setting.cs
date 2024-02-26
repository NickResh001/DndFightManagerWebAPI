using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Setting
    {
        [Key]
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public virtual ICollection<Scene> Scenes { get; } = new List<Scene>();

    }
}
