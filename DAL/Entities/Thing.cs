﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Thing
    {
        [Key]
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Count { get; set; }
        public string? BeastNoteId { get; set; } = null!;
        public string? BeastId { get; set; } = null!;
        public virtual BeastNote BeastNote { get; set; } = null!;
        public virtual Beast Beast { get; set; } = null!;

    }
}
