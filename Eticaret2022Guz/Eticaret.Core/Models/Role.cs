namespace Eticaret.Core.Models
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public bool RoleStatu { get; set; }

        public string RoleDescription { get; set; }
    }
}
