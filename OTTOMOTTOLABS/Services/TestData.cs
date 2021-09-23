using System;
using Interview.Entities;
using Interview.Repositories;
using System.Collections.Generic;
namespace Interview.Services
{
    class TestData
    {
        string[] names = { "John", "Mary", "Peter", "Linda",
        "Osian","Sohaib","Deacon","Darci","Abbigail","Lily-May"};
        string[] lastNames = { "Smith", "Doe", "Peters", "Linda",
        "Naylor","Castaneda","Rankin","Stubbs","Mcgrath","Mcdonald"};
        string[] city = { "Ankara", "İstanbul", "İzmir", "Bursa", "Edirne", "Konya", "Antalya", "Diyarbakır", "Van", "Rize" };
        Random rnd = new Random();
        MusteriRepositories musteriRepos = new MusteriRepositories();
        SepetRepositories sepetRepos = new SepetRepositories();
        SepetUrunRepositories sepeturun = new SepetUrunRepositories();
        string RandomName()
        {
            return names[rnd.Next(0, names.Length)];
        }
        string RandomLastName()
        {
            return lastNames[rnd.Next(0, lastNames.Length)];
        }

        string RandomCity()
        {
            return city[rnd.Next(0, city.Length)];
        }
        public TestData(int MusteriAdet, int sepetAdet)
        {
            List<Musteri> AnlıkMusteriListesi = new List<Musteri>();
            for (int i = 0; i < MusteriAdet; i++)
            {
                Musteri musteri = new Musteri();
                AnlıkMusteriListesi.Add(musteri);
                musteri.Ad = RandomName();
                musteri.Soyad = RandomLastName();
                musteri.Sehir = RandomCity();
                musteriRepos.AddMusteri(musteri);
            }
            for (int i = 0; i < sepetAdet; i++)
            {
                Sepet sepet = new Sepet();
                sepet.MusteriId = AnlıkMusteriListesi[rnd.Next(0, AnlıkMusteriListesi.Count)].Id;
                sepetRepos.AddSepet(sepet);
                for (int x = 0; x < rnd.Next(1, 6); x++)
                {
                    SepetUrun spt = new SepetUrun();
                    spt.SepetId = sepet.Id;
                    spt.Tutar = rnd.Next(100, 1000);
                    spt.Aciklama = "aciklama";
                    sepeturun.AddSepet(spt);
                }
            }



        }
    }
}
/*
Osian Naylor
Sohaib Castaneda
Deacon Rankin
Darci Stubbs
Abbigail Mcgrath
Lily-May Mcdonald
Elif Needham
Bradleigh Prince
Safa Bloggs
Sallie Koch
*/