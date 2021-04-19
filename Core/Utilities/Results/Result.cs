using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       

        public Result(bool success , string message):this(success)//success ve message birlikte çalışması için
        {
            Message = message;
            //Success = success; siliyoruz gereksiz altta success ctor var
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success  { get; }

        public string Message { get; }
    }
}
