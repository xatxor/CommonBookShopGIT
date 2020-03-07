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
        [HttpGet]
        public List<Book> ViewBooksAndAuthors()
        {
            return BookRepository.ViewBooksAndAuthors();
        }
        [HttpGet]
        public List<Book> ViewBooksWithId(int id)
        {
            return BookRepository.ViewBooksWithId(id);
        }
        [HttpGet]
        public List<Book> ViewAuthorsWithId(int id)
        {
            return BookRepository.ViewAuthorsWithId(id);
        }
        [HttpPut]
        public void AddBook(int id, string name)
        {
            BookRepository.AddBook(id,name);
        }
    }
}
