using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public bool Success { get; }

        public string Message { get; }

        public Result(bool success, string message): this(success) // success istendiğinde success li olana transfer et
        {
            
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
           
        }
    }
}
