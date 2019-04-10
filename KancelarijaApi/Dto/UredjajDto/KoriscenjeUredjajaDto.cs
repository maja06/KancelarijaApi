using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.OsobaDto;
using KancelarijaApi.Dto.OsobaUredjajDto;

namespace KancelarijaApi.Dto.UredjajDto
{
    public class KoriscenjeUredjajaDto
    {
        public string Name { get; set; }
        public OsobaGetDto Osoba { get; set; }
        public List<VrijemeDto> ListaKoriscenje { get; set;}
    }
}
