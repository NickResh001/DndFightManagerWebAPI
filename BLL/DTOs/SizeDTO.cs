using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SizeDTO
    {
        public SizeDTO() { }
        public SizeDTO(Size size)
        {
            Id = size.Id;
            Title = size.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
