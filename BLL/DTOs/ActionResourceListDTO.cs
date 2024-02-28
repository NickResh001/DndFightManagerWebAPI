using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ActionResourceListDTO
    {
        public ActionResourceListDTO() { }
        public ActionResourceListDTO(ActionResourceList actionResourceList)
        {
            Id = actionResourceList.Id;
            BeastId = actionResourceList.BeastId;
            ActionResourceId = actionResourceList.ActionResourceId;
            Available = actionResourceList.Available;
        }
        public string Id { get; set; } = null!;
        public string BeastId { get; set; } = null!;
        public string ActionResourceId { get; set; } = null!;
        public bool Available { get; set; }
    }
}
