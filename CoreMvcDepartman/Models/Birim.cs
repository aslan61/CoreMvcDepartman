using CoreMvcDepartman.Models;
using System.ComponentModel.DataAnnotations;

namespace CoreMvcDepartman.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set; }

        public IList<Personel> Personels { get; set; }
    }
}
