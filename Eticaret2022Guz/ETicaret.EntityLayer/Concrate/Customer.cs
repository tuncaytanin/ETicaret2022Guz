using ETicaret.EntityLayer.Abstract;

namespace ETicaret.EntityLayer.Concrate
{
    public class Customer: IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }

        public string CustomerEmail { get; set; }
        public string CustomerUserName { get; set; }
        /// <summary>
        /// Birth Day Format : YYYY-MM-DD
        /// </summary>
        public DateTime BirthDay { get; set; }

        public DateTime CreateDate { get; set; }

        public bool CustomerStaut { get; set; }

        public ICollection<Adress> Adresses { get; set; }


    }
}
