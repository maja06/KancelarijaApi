using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace KancelarijaApi.Attributes
{
    public enum EnumServiceForDI
    {
        Scoped = 0,
        Transient = 1,
        Singleton = 2
       
    }
}
