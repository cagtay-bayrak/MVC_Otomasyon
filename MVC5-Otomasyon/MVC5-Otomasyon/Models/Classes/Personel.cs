using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonelAd { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonelSoyad { get; set; }




        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string PersonelGorsel { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public ICollection<Departman> Departman { get; set; }
    }
}