using System.ComponentModel.DataAnnotations;

namespace Interview.Entities
{
    public class Sepet
    {
        [Key]
        public int Id {get;set;}
        public int  MusteriId {get;set;}
    }
}