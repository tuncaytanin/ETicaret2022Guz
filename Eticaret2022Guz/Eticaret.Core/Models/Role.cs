using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Eticaret.Core.Models
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }

        [Display(Name = "Role Adı")]
        public string RoleName { get; set; }

        public bool RoleStatu { get; set; }
        [Display(Name = "Role Açıklama")]
        public string RoleDescription { get; set; }
    }
}
