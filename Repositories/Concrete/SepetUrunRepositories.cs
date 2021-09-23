using System.Collections.Generic;
using System.Linq;
using Interview.Entities;
using Interview.Services;

namespace Interview.Repositories
{
    public class SepetUrunRepositories: ISepetUrunRepository
    {
        WebApiContext db = new WebApiContext();
     
        public List<SepetUrun> GetSepetUrunList()
        {
            return db.SepetUrun.ToList();
        }
        public SepetUrun GetSepetUrun(int id)
        {
            return db.SepetUrun.FirstOrDefault(x => x.Id == id);
        }
        public void AddSepet(SepetUrun sepetUrun){
           db.SepetUrun.Add(sepetUrun);
           db.SaveChanges();
        }
        public List<SepetUrun> GetSepetUrunList(int SepetId){
            return db.SepetUrun.Where(x => x.SepetId == SepetId).ToList();
        }

    }
}