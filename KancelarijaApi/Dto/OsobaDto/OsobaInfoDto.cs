using KancelarijaApi.Dto.KancelarijaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.OsobaUredjajDto;
using KancelarijaApi.Dto.UredjajDto;

namespace KancelarijaApi.Dto.OsobaDto
{
    public class OsobaInfoDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public KancelarijaGetDto Kancelarija { get; set; }
        public List<VrijemeDto> ListaKoriscenje { get; set; }
        public List<UredjajGetDto> ListaUredjaji { get; set; }
    }
}
