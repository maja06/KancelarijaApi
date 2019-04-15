using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KancelarijaApi.Filters
{
    public class MyExceptionFilter : IExceptionFilter
    {

        public void OnException(ExceptionContext context)
        {
            var _response = new Response {Data = null, IsError = true};

            Error error = new Error()
            {
                Message = context.Exception.Message,
                Exception = context.Exception.ToString(),
                StackTrace = context.Exception.StackTrace
            };


            if (context.Exception.GetBaseException() is SqlException ex)
            {
                var num = ex.Number;
                if (num == 547)
                {
                    error.Message = "Brisanje nije dozvoljeno";
                }

                _response.IsError = true;
                _response.Data = null;
                _response.Error = error;

                context.Result = new ObjectResult(_response);

            }
        }
    }
}
