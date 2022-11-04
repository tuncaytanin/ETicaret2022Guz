using ETicaret.EntityLayer.Abstracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.EntityLayer.Concretes
{
    public class Adress : IEntity
    {
        public int AdressId { get; set; }
        public string AdressName { get; set; }
        public string CityName { get; set; }
        public string TownName { get; set; }

        public string NeighborhoodName { get; set; }

        public string AdressDescription { get; set; }

        //public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
    }
}
