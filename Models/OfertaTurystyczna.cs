using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV_BazaDanych_ESIT.Models
{
    public class OfertaTurystyczna
    {
        [Key]
        [Column("ID_Oferty_Turystycznej")]
        public int ID { get; set; }
        [Required]
        public string Kategoria { get; set; }
        public int Koszt { get; set; }
        [Required]
        public DateTime DataWyjazdu { get; set; }
        [Required]
        public DateTime DataPrzyjazdu { get;set; }
        [Required]
        public string MiejsceWyjazdu { get; set; }
        [Required]
        public string MiejsceDocelowe { get; set; }

        public virtual ICollection<Rezerwacja> Rezerwacja { get; set; }
        public virtual ICollection<Opinie> Opinie { get; set; }
    }
}
