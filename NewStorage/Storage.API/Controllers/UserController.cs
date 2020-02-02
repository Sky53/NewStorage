using Microsoft.AspNetCore.Mvc;
using Storage.Business.DTO.UserDTO;
using Storage.Business.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<UserResponse> GetUserByIdAsync(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<int> AddUser([FromBody]UserRequest userRequest)
        {
            return await _userService.AddAsync(userRequest);
        }

        [HttpPut("{id}")]
        public async Task<UserResponse> UpdateUser(int id, [FromBody]UserRequest userRequest)
        {
            return await _userService.UpdateAsync(id, userRequest);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteAsync(id);

            return Ok();
        }
    }
}
