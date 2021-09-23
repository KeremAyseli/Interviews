using Interview.Entities;
using Interview.Repositories;
using System.Collections.Generic;
using System;

namespace Interview.Services
{
    class SehirAnalizi
    {
        MusteriRepositories musteiRepos = new MusteriRepositories();
        SepetRepositories sepetRepos = new SepetRepositories();
        SepetUrunRepositories sepetUrunRepos = new SepetUrunRepositories();
        List<SehirAnaliz> AnalizSonuc = new List<SehirAnaliz>();

        public SehirAnalizi()
        {
            var musteriler = musteiRepos.GetMusteriList();
            var sehirler = musteiRepos.GetUniqeCity();
            for (int j = 0; j < sehirler.Count; j++)
            {
                int toplamtutar = 0, ToplamSiparişSayısı = 0;
                for (int i = 0; i < musteriler.Count; i++)
                {
                    if (musteriler[i].Sehir == sehirler[j].Sehir)
                    {
                        var sepetUrunleri = sepetRepos.GetSepetList(musteriler[i].Id);
                        for (int x = 0; x < sepetUrunleri.Count; x++)
                        {
                            ToplamSiparişSayısı++;
                            sepetUrunRepos.GetSepetUrunList(sepetUrunleri[x].Id).ForEach(x => toplamtutar += Convert.ToInt32(x.Tutar));
                        }
                    }
                }
                AnalizSonuc.Add(new SehirAnaliz(sehirler[j].Sehir, ToplamSiparişSayısı, toplamtutar));
            }
        }
        public List<SehirAnaliz> GetAnalizSonuc()
        {
            return AnalizSonuc;
        }
    }


}