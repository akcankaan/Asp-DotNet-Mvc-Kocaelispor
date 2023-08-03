using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace g212102053_mehmet_kaan_akcan_odev.Models.Siniflar
{
    public class MainImage
    {
        [Key]
        public int MainImageID { get; set; }

        [Column(TypeName = "Text")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string MainImageUrl { get; set; }
    }
}