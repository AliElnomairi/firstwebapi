using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using firstwebapi.Models;
using System;
namespace firstwebapi.Controllers
{
    [Route("api/Todoitem")]
    [ApiController]
    public class TodoitemController : ControllerBase
    {
        List <Todoitem> items= new List<Todoitem> ();
        public TodoitemController()
        {
            items.Add =new Todoitem { Id = 1, Title = "item1", complete = false};
            items.Add = new Todoitem { Id = 2, Title = "item2", complete = true };
        }
        [HttpGet]
        public List<Todoitem> Get()
        {
            return items;
        }
    }
}
