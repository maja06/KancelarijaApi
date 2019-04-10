using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Dto.OsobaUredjajDto
{
    public class ListaKoriscenjaDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<VrijemeDto> VrijemeKoriscenja { get; set; }
    }
}
