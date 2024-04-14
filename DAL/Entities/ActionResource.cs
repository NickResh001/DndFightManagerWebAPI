using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ActionResource : HardcodeDirectory
    {
        public virtual ICollection<Action> Actions { get; } = new List<Action>();
        public virtual ICollection<ActionResourceList> ActionResourceLists { get; } = new List<ActionResourceList>();
    }
}
