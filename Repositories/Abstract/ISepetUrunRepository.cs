using Interview.Entities;
using System.Collections.Generic;
namespace Interview.Repositories
{
    public interface ISepetUrunRepository
    {
      public List<SepetUrun> GetSepetUrunList();
      public SepetUrun GetSepetUrun(int id);
    }

}