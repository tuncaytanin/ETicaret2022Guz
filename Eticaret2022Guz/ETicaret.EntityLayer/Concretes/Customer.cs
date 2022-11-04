using ETicaret.EntityLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ETicaret.EntityLayer.Concretes
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

        //public ICollection<Adress> Adresses { get; set; }


    }
}
