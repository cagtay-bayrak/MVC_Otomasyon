using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_Otomasyon.Models.Classes
{
    public class Faturalar
    {
        [Key]
        public int Faturaid { get; set; }


        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string FaturaSıraNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public DateTime FaturaSaati { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string VergiDairesi { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimEden { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }

        //Bir faturanın birden fazla katagorisi olabilir .
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}