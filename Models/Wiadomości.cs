using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV_BazaDanych_ESIT.Models
{
    public class Wiadomości
    {
        [Key]
        [Column("ID_Wiadomości")]
        public int ID { get; set; }

        [Required]
        public string Temat { get; set; }
        public string Tekst { get; set; }

        public virtual Rezerwacja Rezerwacja { get; set; }

        public int UżytkownicyID { get; set; }

        [ForeignKey("UżytkownicyID")]
        public virtual Użytkownicy Użytkownicy { get; set; }
    }
}
