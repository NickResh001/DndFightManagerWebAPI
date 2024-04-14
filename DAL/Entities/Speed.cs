﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Speed : HardcodeDirectory
    {
        public virtual ICollection<SpeedList> SpeedLists { get; } = new List<SpeedList>();
    }
}
