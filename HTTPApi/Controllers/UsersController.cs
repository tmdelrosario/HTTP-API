using HTTPApi.UsersData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTTPApi.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsersData _UsersData;
        public UsersController(IUsersData usersData)
        {
            _UsersData = usersData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok(_UsersData.Users());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetUsers(int id)
        {
            var users = _UsersData.GetUsers(id);
            if (users != null)
            {
                return Ok(_UsersData.GetUsers(id));
            }

            return NotFound($"User with Id: {id} was not found");
            
        }
    }
}
