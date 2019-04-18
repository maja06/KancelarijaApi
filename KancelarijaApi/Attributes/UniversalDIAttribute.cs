using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Attributes
{
    [AttributeUsage( AttributeTargets.Class)]
    public class UniversalDiAttribute : Attribute
    {
        public EnumServiceForDI Name { get; }

        public UniversalDiAttribute(EnumServiceForDI name = EnumServiceForDI.Transient)
        {
            this.Name = name;
        }
    }
}
