using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApp.Application.Exceptions
{
    public class ExceptionModel : ErrorStatusCode
    {
        public IEnumerable<String> Errors { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class ErrorStatusCode()
    {
        public int StatusCode { get; set; }
    }
}
