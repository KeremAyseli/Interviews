using System.ComponentModel.DataAnnotations;
namespace Interview.Entities
{
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Ad { get; set; }
        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }
        public string Sehir { get; set; }
    }
}