﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Speed
    {
        [Key]
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;

        public virtual ICollection<SpeedList> SpeedLists { get; } = new List<SpeedList>();

    }
}
