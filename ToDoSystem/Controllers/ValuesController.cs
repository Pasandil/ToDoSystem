using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoSystem.Methord_Classes;

namespace ToDoSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IPrimaryMethordClass bll = new PrimaryMethordClass();

        [HttpGet]
        public IActionResult GetAllToDoLists()
        {
            return Ok(bll.GetAllToDoLists());
        }

        [HttpGet("id")]
        public IActionResult GetToDoListByID(long id)
        {
            return Ok(bll.GetAllToDoLists(id));
        }

        [HttpPost()]
        public IActionResult AddToDoItem(long id, string Name, string description)
        {
            return Ok(bll.AddToDoItem(id, Name, description));
        }

    }
}
