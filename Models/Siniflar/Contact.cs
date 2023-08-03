using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g212102053_mehmet_kaan_akcan_odev.Models.Siniflar
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Column(TypeName = "Text")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Location { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Email { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Call { get; set; }
    }
}