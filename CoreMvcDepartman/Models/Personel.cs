using CoreMvcDepartman.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMvcDepartman.Models
{
    public class Personel
    {
        [Key]
        public int perid { get; set; }
        public string? ad { get; set; }
        public string? soyad { get; set; }
        public string sehir { get; set; }
        public int BirimID { get; set; }
        public Birim Birim { get; set; }

    }
}
