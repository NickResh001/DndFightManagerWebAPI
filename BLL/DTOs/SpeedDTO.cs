using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SpeedDTO
    {
        public SpeedDTO() { }
        public SpeedDTO(Speed speed)
        {
            Id = speed.Id;
            Title = speed.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
