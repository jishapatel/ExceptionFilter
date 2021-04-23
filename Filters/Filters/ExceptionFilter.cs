using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;


namespace Filters.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnException(actionExecutedContext);

            if(actionExecutedContext.Exception is IndexOutOfRangeException)
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                response.Content = new StringContent("Provide proper index value!!");
                response.ReasonPhrase = "Index out of Range";
                actionExecutedContext.Response = response;
            }

            else if (actionExecutedContext.Exception is DivideByZeroException)
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                response.Content = new StringContent("Provide proper numbers value!!");
                response.ReasonPhrase = "Divide By Zero Not Allowed";
                actionExecutedContext.Response = response;
            }

            else
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                response.Content = new StringContent("Error!! please try again!!");
                actionExecutedContext.Response = response;
            }
        } 
    }
}