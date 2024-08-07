﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        //[Required]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }


        //Kategorimde birden fazla ürün yer alabilir.
        public ICollection<Urun> Uruns { get; set; }
    }
}