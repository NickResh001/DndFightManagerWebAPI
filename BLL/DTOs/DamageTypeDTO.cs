﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DamageTypeDTO
    {
        public DamageTypeDTO() { }
        public DamageTypeDTO(DamageType damageType)
        {
            Id = damageType.Id;
            Title = damageType.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
