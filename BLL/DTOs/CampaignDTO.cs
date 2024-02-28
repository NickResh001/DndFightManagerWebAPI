using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CampaignDTO
    {
        public CampaignDTO() { }
        public CampaignDTO(Campaign campaign)
        {
            Id = campaign.Id;
            Title = campaign.Title;
            AuthorId = campaign.AuthorId;
        }
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string AuthorId { get; set; } = null!;
    }
}
