using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV_BazaDanych_ESIT.Models
{
    public class Opinie
    {
        [Key]
        [Column("ID_Opini")]
        public int ID { get; set; }
        [Required]
        public DateTime DataWystawienia { get; set; }
        public int Ocena { get; set; }
        [Required]
        public virtual OfertaTurystyczna OfertaTurystyczna { get; set; }
    }
}
