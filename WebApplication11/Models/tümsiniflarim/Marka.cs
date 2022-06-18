using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication11.Models.tümsiniflarim
{
    public class Marka
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Marka Adı bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Marka Adı")]
        public string Ad { get; set; }


        public ICollection<Urun> Uruns { get; set; }
    }
}