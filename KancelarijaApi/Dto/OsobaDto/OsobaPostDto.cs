﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Dto.OsobaDto
{
    public class OsobaPostDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public long KancelarijaId { get; set; }
    }
}