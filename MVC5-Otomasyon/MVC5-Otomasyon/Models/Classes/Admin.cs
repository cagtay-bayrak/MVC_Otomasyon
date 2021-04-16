﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Admin
    {
        [Key]
        public int Adminid { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    }
}