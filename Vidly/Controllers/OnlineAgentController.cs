using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class OnlineAgentController : Controller
    {
        // GET: OnlineAgent
        public ViewResult Index()
        {
            var agent = GetAgent();
            return View(agent); 
        }

        private IEnumerable<Agent> GetAgent()
        {

            return new List<Agent>
            {
                new Agent { Id = 1, Name = "Amazon"},
                new Agent { Id = 2, Name = "Flipkart"}
            };
           

        }













    }
}