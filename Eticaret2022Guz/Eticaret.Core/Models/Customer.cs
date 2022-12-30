using System;

namespace Eticaret.Core.Models
{
    public class Customer : IEntity
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

        public bool CustomerStatus { get; set; }

        public string PhoneNumber { get; set; }

        public string CustomerPassword { get; set; }

        public string Token { get; set; }
        public DateTime? TokenExpireDate { get; set; }

        //public ICollection<Adress> Adresses { get; set; }


    }
}
