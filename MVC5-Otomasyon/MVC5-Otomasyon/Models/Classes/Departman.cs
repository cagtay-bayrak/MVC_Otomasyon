using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Departman
    {
        [Key]
        public int Departmanid { get; set; }
        public string DepartmanAd { get; set; }
    }
}