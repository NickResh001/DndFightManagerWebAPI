using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ActionThrowDTO
    {
        public ActionThrowDTO() { }
        public ActionThrowDTO(ActionThrow actionThrow)
        {
            Id = actionThrow.Id;
            ActionId = actionThrow.ActionId;
            Title = actionThrow.Title;
            Throw = actionThrow.Throw;
        }
        public string Id { get; set; } = null!;
        public string ActionId { get; set; } = null!;
        public string? Title { get; set; }
        public string Throw { get; set; } = null!;
    }
}
