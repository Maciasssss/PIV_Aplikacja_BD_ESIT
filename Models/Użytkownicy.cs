using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV_BazaDanych_ESIT.Models
{
    public class Użytkownicy
    {
        [Key]
        [Column("ID_Użytkownika")]
        public int ID { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        public DateTime DataUrodzenia { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Haslo { get; set; }
        [Required]

        public virtual ICollection<Rezerwacja> Rezerwacja { get; set; }
        public virtual ICollection<Wiadomości> Wiadomości { get; set; }

    }
}
