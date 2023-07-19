using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Exceptions
{
    public class RestException:Exception
    {
        public RestException(HttpStatusCode code,string message)
        {
            Message= message;
            Code= code;
        }
        public RestException(HttpStatusCode code,string key,string errorMessage, string? message=null)
        {
            Code= code;
            Message = message;
            Errors = new List<RestExceptionErrorItem>() { new RestExceptionErrorItem(key, errorMessage) };
        }
        public RestException(HttpStatusCode code,List<RestExceptionErrorItem> errors,string? message)
        {
            Code= code;
            Errors = errors;
            Message= message;
        }
        public string? Message { get; set; }
        public HttpStatusCode Code { get; set; }
        public List<RestExceptionErrorItem> Errors { get; set; }
        
    }

    public class RestExceptionErrorItem
    {
        public string? Key { get; set; }
        public string ErrorMassege { get; set; }
        public RestExceptionErrorItem(string key, string errorMassege)
        {
            Key = key;
            ErrorMassege = errorMassege;
        }
    }
}
