using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SettingDTO
    {
        public SettingDTO() { }
        public SettingDTO(Setting setting)
        {
            Id = setting.Id;
            Title = setting.Title;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
