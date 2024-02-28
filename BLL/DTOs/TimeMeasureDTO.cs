using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TimeMeasureDTO
    {
        public TimeMeasureDTO() { }
        public TimeMeasureDTO(TimeMeasure timeMeasure)
        {
            Id = timeMeasure.Id;
            Title = timeMeasure.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
