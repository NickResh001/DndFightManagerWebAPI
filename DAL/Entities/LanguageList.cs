using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class LanguageList
    {
        [Key]
        public string Id { get; set; } = null!;
        public string LanguageId { get; set; } = null!;
        public string BeastNoteId { get; set; } = null!;


        public virtual Language Language { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!;

    }
}
