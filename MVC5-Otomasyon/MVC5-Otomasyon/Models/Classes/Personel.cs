using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelGorsel { get; set; }
    }
}