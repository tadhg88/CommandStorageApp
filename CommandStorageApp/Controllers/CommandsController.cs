using System.Collections.Generic;
using CommandStorageApp.Data;
using CommandStorageApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandStorageApp.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommandRepo _repository = new MockCommandRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();

            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommand(int id)
        {
            var command = _repository.GetCommandById(id);

            return Ok(command);
        }
    }
}