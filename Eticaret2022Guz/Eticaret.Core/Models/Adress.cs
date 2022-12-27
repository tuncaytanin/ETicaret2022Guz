namespace Eticaret.Core.Models
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
