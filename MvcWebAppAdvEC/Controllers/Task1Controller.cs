using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcWebAppAdvEC.Controllers
{
    public class Task1Controller : Controller
    {
        // 
        // GET: /Task1/

        public string Index()
        {
            return "Hello welcome to your first task in adv. ec section .. you can modifiy the url to add /welcome to enter our welcome page";
        }

        // 
        // GET: /Task1/Welcome/ 

        public string Welcome()
        {
            return "Hi, i'm glad that you came here ";
        }
    }
}
