﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class FaturaKalem
    {

        [Key]
        public int FAturaKalemid { get; set; }
        public string Aciklama { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }

        public Faturalar Faturalar { get; set; }
    }
}