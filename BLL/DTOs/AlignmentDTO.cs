using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AlignmentDTO
    {
        public AlignmentDTO() { }
        public AlignmentDTO(Alignment alignment)
        {
            Id = alignment.Id;
            Law = alignment.Law;
            Goodness = alignment.Goodness;
            Title = alignment.Title;
        }
        public string Id { get; set; } = null!;
        public int Law { get; set; }
        public int Goodness { get; set; }
        public string Title { get; set; } = null!;
    }
}
