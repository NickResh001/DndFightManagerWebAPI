﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Habitat : HardcodeDirectory
    {
        public virtual ICollection<HabitatList> HabitatLists { get; } = new List<HabitatList>();
    }
}
