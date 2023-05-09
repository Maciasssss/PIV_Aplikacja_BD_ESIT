using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV_BazaDanych_ESIT.Models
{
    public class Rezerwacja
    {
        [Key]
        [Column("ID_Rezerwacji")]
        public int ID { get; set; }
        [Required]
        public DateTime DataRezerwacji { get; set; }
        [Required]
        public int LiczbaOsób { get; set; }
        [Required]
        public int Koszt { get; set; }
        [Required]

        public virtual OfertaTurystyczna OfertaTurystyczna { get; set; }
        public virtual Użytkownicy Użytkownicy { get; set; }

        public ICollection<Wiadomości> wiadomościs { get; set; }
    }
}
