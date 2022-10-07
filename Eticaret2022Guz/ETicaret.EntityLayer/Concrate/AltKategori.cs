using ETicaret.EntityLayer.Abstract;

namespace ETicaret.EntityLayer.Concrate
{
    public class AltKategori : IEntity
    {
        public int AltKategoriId { get; set; }
        
        public string AltKategoriAdi { get; set; }
        public bool AltKategoriDurumu { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public short SortKey { get; set; }

        public ICollection<Urun> Uruns { get; set; }

    } 
}
