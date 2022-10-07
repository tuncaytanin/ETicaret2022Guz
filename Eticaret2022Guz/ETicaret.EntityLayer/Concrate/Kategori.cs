using ETicaret.EntityLayer.Abstract;

namespace ETicaret.EntityLayer.Concrate
{
    public class Kategori : IEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public bool KategoriDurumu { get; set; }

        public short SortKey { get; set; }

        public ICollection<AltKategori> AltKategoris { get; set; }
    }
}
