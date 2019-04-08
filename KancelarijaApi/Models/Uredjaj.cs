using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Models
{
    public class Uredjaj
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UredjajId { get; set; }
        public string UredjajIme { get; set; }

        public long? OsobaId { get; set; }
        [ForeignKey("OsobaId")]
        public Osoba Osoba { get; set; }

        public IList<OsobaUredjaj> ListaKoriscenje { get; set; }

    }
}
