using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.OsobaDto;

namespace KancelarijaApi.Dto.KancelarijaDto
{
    public class IzlistavanjePoKancelarijiDto
    {

        public string Opis { get; set; }
        public IList<OsobaGetDto> ListaOsobe { get; set; }
    }
}
