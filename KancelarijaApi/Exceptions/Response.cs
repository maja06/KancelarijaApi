using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Exceptions
{
    public class Response
    {
        public object Data { get; set; }
        public bool IsError { get; set; }
        public Error Error { get; set; }
    }
}
