﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Sense : HardcodeDirectory
    {
        public virtual ICollection<SenseList> SenseLists { get; } = new List<SenseList>();
    }
}
