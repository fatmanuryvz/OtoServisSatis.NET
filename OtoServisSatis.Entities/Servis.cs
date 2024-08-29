﻿using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Servis : IEntitiy
    {
        public int Id { get; set; }
        [Display(Name = "Servise Geliş Tarihi")]
        public DateTime ServisGelisTarihi {  get; set; }
        [Display(Name = "Araç Sorunu")]
        public string AracSorunu {  get; set;}
        [Display(Name = "Servis Ücteri"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public decimal ServisUcreti {  get; set; }
        [Display(Name = "Servisten Çıkış Tarihi")]
        public DateTime ServistenCikisTarihi { get; set; }
        [Display(Name = "Yapılan İşlemler")]
        public string? Yapilanİslemler { get; set; }
        [Display(Name = "Garanti Kapsamında Mı?")]
        public bool GarantiKapsamindaMi {  get; set; }
        [StringLength(15)]
        [Display(Name = "Araç Plakası")]
        public string AracPlaka { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Marka { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Model { get; set; }
        [StringLength(50)]
        [Display(Name = "Kasa Tipi"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string KasaTipi { get; set; }
        [StringLength(50)]
        [Display(Name = "Şase No"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string? SaseNo {  get; set; }
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Notlar { get; set; }

    }
}