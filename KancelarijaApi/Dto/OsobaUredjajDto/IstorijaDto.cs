using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Dto.OsobaUredjajDto
{
    public class IstorijaDto
    {
        public DateTime VrijemeOd { get; set; }
        public DateTime? VrijemeDo { get; set; }
        public string UredjajIme { get; set; }
        public string OsobaIme { get; set; }
        public string OsobaPrezime { get; set; }
    }
}
