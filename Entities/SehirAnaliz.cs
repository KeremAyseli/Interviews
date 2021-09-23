namespace Interview.Entities
{
    
        public class SehirAnaliz
        {
            public string SehirAdi { get; set; }
            public int SepetAdet { get; set; }
            public int ToplamTutar { get; set; }
            public SehirAnaliz(string sehirAdi, int sepetAdet, int toplamTutar){
                SehirAdi = sehirAdi;
                SepetAdet = sepetAdet;
                ToplamTutar = toplamTutar;
            }
           
        }
    
}