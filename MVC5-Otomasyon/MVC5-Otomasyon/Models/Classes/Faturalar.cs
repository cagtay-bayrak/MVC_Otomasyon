using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Faturalar
    {
        [Key]
        public int Faturaid { get; set; }
        public string FaturaSeriNo { get; set; }
        public string FaturaSıraNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public DateTime FaturaSaati { get; set; }
        public string VergiDairesi { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }

        //Bir faturanın birden fazla katagorisi olabilir .
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}