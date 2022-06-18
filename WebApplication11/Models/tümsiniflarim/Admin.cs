﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication11.Models.tümsiniflarim
{
    public class Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Ad bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Admin Adı")]
        public string Ad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Soyad bilgisi 20 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Admin Soyadı")]
        public string Soyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(11, ErrorMessage = "Tc bilgisi 11 karakterden uzun olamaz !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        public string TC { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(4, ErrorMessage = "Şifre bilgisi 4 karakterden oluşması gerekli !")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz !!")]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "Mail bilgisi 100 karakterden uzun olamaz !")]
        [Display(Name = "Mail Adresi")]
        public string MAIL { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15, ErrorMessage = "Telefon bilgisi 15 karakterden uzun olamaz !")]
        [Display(Name = "Telefon")]
        public string TELEFON { get; set; }


    }
}