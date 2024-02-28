using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BeastTypeDTO
    {
        public BeastTypeDTO() { }
        public BeastTypeDTO(BeastType beastType)
        {
            Id = beastType.Id;
            Title = beastType.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
