using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KancelarijaApi.Models;

namespace KancelarijaApi
{
    public class Kancelarija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long KancelarijaId { get; set; }
        public string Opis { get; set; }

        public IList<Osoba> ListaOsobe  { get; set; }

    }
}
