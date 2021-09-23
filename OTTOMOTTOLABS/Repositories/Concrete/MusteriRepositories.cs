using System.Collections.Generic;
using Interview.Entities;
using Interview.Services;
using System.Linq;
namespace Interview.Repositories
{
    public class MusteriRepositories : IMusteriRepository
    {
        WebApiContext db = new WebApiContext();

        public List<Musteri> GetMusteriList()
        {
            return db.Musteri.ToList();
        }
        public Musteri GetMusteri(int id)
        {
            return db.Musteri.FirstOrDefault(m => m.Id == id);
        }
        public void AddMusteri(Musteri musteri)
        {
            db.Musteri.Add(musteri);
            db.SaveChanges();
        }
        public List<Musteri> GetMusteriList(string Sehir){
            return db.Musteri.Where(m => m.Sehir == Sehir).ToList();
        }
        public List<Musteri> GetUniqeCity(){
            return db.Musteri.GroupBy(y=>y.Sehir).Select(y=>new Musteri{Sehir=y.Key}).Cast<Musteri>().ToList();
        }


    }


}