using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HabitatDTO
    {
        public HabitatDTO() { }
        public HabitatDTO(Habitat habitat)
        {
            Id = habitat.Id;
            Title = habitat.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
