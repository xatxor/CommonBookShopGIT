using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication13.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public int Sum(int numb1, int numb2)
        {
            return (numb1 + numb2);
        }
        [HttpGet]
        public int Umn(int numb1, int numb2)
        {
            return (numb1 * numb2);
        }
        [HttpGet]
        public int Min(int numb1, int numb2)
        {
            return (numb1 - numb2);
        }
        [HttpGet]
        public int Del(int numb1, int numb2)
        {
            return (numb1 / numb2);
        }
    }
}
