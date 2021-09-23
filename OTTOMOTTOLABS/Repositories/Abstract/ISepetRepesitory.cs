using Interview.Entities;
using System.Collections.Generic;
namespace Interview.Repositories
{
    public interface ISepetRepository
    {
      public  List<Sepet> GetSepetList();
      public  Sepet GetSepet(int id);
    }

}