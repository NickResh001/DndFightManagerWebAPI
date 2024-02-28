using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SceneDTO
    {
        public SceneDTO() { }
        public SceneDTO(Scene scene)
        {
            Id = scene.Id;
            Title = scene.Title;
            CampaignId = scene.CampaignId;
            SettingId = scene.SettingId;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string CampaignId { get; set; } = null!;
        public string? SettingId { get; set; }
    }
}
