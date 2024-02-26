using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Condition
    {
        [Key]
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;

        public virtual ICollection<ConditionImmunitiesList> ConditionImmunitiesLists { get; } = new List<ConditionImmunitiesList>();
        public virtual ICollection<ConditionList> ConditionLists { get; } = new List<ConditionList>();

    }
}
