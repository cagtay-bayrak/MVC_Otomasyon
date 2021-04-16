﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyati { get; set; }
        public bool Durum { get; set; }
        public string UrunGorsel { get; set; }

        //Bir ürünün bir kategori olabilir ilişkisi
        public Kategori Kategori { get; set; }
    }
}