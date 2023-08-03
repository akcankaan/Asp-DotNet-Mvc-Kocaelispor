using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g212102053_mehmet_kaan_akcan_odev.Models.Siniflar
{
    public class Main
    {
        [Key]
        public int MainID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(2000, ErrorMessage = "En fazla 2000 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Promotion { get; set; }
    }
}