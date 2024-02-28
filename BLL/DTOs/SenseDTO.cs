using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SenseDTO
    {
        public SenseDTO() { }
        public SenseDTO(Sense sense)
        {
            Id = sense.Id;
            Title = sense.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
