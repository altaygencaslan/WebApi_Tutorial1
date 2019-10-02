using System.ComponentModel.DataAnnotations;

namespace WebApi_Tutorial1.Models
{
    public class Personel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Ad bilgisi zorunludur")]
        public string Ad { get; set; }
        [Required(ErrorMessage="Soyad bilgisi zorunludur")]
        public string Soyad { get; set; }
    }
}