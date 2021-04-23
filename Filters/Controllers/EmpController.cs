using Filters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Filters.Controllers
{
    //[ExceptionFilter]
    //Controller level Exception
    public class EmpController : ApiController
    {
        int[] numbers = { 22, 43, 12, 6 };

        [ExceptionFilter]
        /*Get method https://localhost:44302/api/emp?idx=10&divider=2 this will get you an error bcz idx=10 and
        there is 4 elements in array IndexOutOfRangeException
        https://localhost:44302/api/emp?idx=2&divider=2  Proper ans
        https://localhost:44302/api/emp?idx=2&divider=0  DivideByZeroException
        https://localhost:44302/api/emp?idx=2&divider=0 FormatException*/
        [HttpGet]
        //Get method https://localhost:44302/api/emp?idx=0&divider=2
        public double division(int idx,int divider)
        {
            return numbers[idx] / divider;
        }

        [ExceptionFilter]
        //Get method https://localhost:44302/api/emp?idx=10 IndexOutOfRangeException
        public int GetNumber(int idx)
        {
            return numbers[idx];
        }
    }
}
