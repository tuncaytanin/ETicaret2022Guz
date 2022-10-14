using ETicaret.EntityLayer.Abstract;

namespace ETicaret.EntityLayer.Concrate
{
    public class Role: IEntity
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string RoleStatu { get; set; }

        public string RoleDescription { get; set; }
    }
}
