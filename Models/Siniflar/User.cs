using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g212102053_mehmet_kaan_akcan_odev.Models.Siniflar
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string FullName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Email { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Password { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1, ErrorMessage = "En fazla 1 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Authorization { get; set; } = "B";


    }
}