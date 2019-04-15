using KancelarijaApi.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KancelarijaApi.Filters
{
    public class MyReturnFilter : IResultFilter
    {
       
        public void OnResultExecuting(ResultExecutingContext context)
        {

            var result = context.Result as ObjectResult;

            var _response = new Response();

            if (result.StatusCode >= 200 && result.StatusCode <= 300)
            {
                _response.Data = result.Value;
                _response.Error = null;
                _response.IsError = false;
            }

            if (result.StatusCode >= 400 && result.StatusCode <= 500)
            {
                _response.Data = result.Value;
                _response.IsError = true;
                _response.Error = null;
            }

            context.Result = new ObjectResult(_response);

        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            
        }
    }
}
