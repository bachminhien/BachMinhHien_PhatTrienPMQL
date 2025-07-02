using System.Net;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class Person : Employee
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}