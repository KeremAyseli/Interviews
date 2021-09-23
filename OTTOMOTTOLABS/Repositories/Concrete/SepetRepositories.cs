using System.Collections.Generic;
using System.Linq;
using Interview.Entities;
using Interview.Services;

namespace Interview.Repositories
{
    public class SepetRepositories : ISepetRepository
    {
        WebApiContext db = new WebApiContext();
        public List<Sepet> GetSepetList()
        {
            return db.Sepet.ToList();
        }
        public Sepet GetSepet(int id)
        {
            return db.Sepet.FirstOrDefault(x => x.MusteriId == id);
        }
        public void AddSepet(Sepet sepet)
        {
            db.Sepet.Add(sepet);
            db.SaveChanges();
        }
        public List<Sepet> GetSepetList(int id){
            return db.Sepet.Where(x => x.Id == id).ToList();
        }

    }
}