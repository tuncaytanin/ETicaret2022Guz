using ETicaret.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.EntityLayer.Concrate
{
    public class Urun : IEntity
    {
        public int UrunId { get; set; }   
        public string UrunAdi { get; set; }

        public string UrunKodu { get; set; }

        public string UrunAciklama { get; set; }

        public int AltKategoriId { get; set; }

        public AltKategori AltKageori { get; set; }
    }
}
