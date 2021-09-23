using System.ComponentModel.DataAnnotations;

namespace Interview.Entities
{
    public class SepetUrun
    {
        [Key]
        public int Id{get;set;}
        [Required]
        public int SepetId { get; set; }
        [Required]
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
    }

}