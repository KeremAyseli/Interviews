using Interview.Entities;
using System.Collections.Generic;
namespace Interview.Repositories
{
   public interface IMusteriRepository
    {
       public Musteri GetMusteri(int id);
       public  List<Musteri> GetMusteriList();
    }
}