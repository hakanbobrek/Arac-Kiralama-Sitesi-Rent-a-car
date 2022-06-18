using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication11.Models.tümsiniflarim
{
    public class Urun
    {
        public int ID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Ürün Adı bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Ürün Adı")]


        public string Ad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Durum bilgisi 30 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Ürün Durumu")]
        public string Durum { get; set; }

        [Display(Name = "Ürün Markası")]
        public int MarkaID { get; set; }
        public virtual Marka Marka { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Stok Adedi")]
        public int Stok { get; set; }

        [Column(TypeName = "Varchar")]
        [Display(Name = "Dönüş Tarihi")]
        public string Tarih { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Kiralama Fiyatı")]
        public decimal KiralamaFiyat { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "Fotoğraf bilgisi 100 karakterden uzun olamaz !")]

        [Display(Name = "Fotoğraf")]
        public string Fotograf { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200, ErrorMessage = "Özellikler bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Özellikler")]
        public string Ozellikler { get; set; }

    }
}