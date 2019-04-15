using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KancelarijaApi.Exceptions
{
    public class CustomException : Exception 
    {
        public CustomException(string message) : base(message)
        {

        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {

        }
      
            

        
    }
}
