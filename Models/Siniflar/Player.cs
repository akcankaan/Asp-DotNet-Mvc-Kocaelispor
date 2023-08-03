using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g212102053_mehmet_kaan_akcan_odev.Models.Siniflar
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string PlayerName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string PlayerSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(3, ErrorMessage = "En fazla 3 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string PlayerNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string position_played { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Nationality { get; set; }

        [Column(TypeName = "Text")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string PlayerImage { get; set;}
    }
}