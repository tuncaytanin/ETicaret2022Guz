using ETicaret.EntityLayer.Abstracts;

namespace ETicaret.EntityLayer.Concretes
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string RoleStatu { get; set; }

        public string RoleDescription { get; set; }
    }
}
