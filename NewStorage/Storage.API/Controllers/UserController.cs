using Microsoft.AspNetCore.Mvc;
using Storage.Business;
using Storage.Business.DTO;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService userService)
        {
            _service = userService;
        }

        [HttpPost]
        public async Task<int> AddUser([FromBody]UserDTO userDTO)
        {
            return await _service.AddUserAsync(userDTO);
        }

        [HttpGet("{id:int}")]
        public async Task<UserDTO> GetUserById(int id)
        {
            return await _service.FindUserAsyncById(id);
        }

        [HttpPut]
        public void UpdateUser([FromBody]UserDTO userDTO)
        {
            _service.UpdateUserAsync(userDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<int> DeleteUser(int id)
        {
            return await _service.DeleteUserAsync(id);
        }

        [HttpGet]
        public UserDTO GetDTO()
        {
            return new UserDTO()
            {
                Id = 1,
                Login = "Login",
                Password = "Password",
                Name = "NameDTO"
            };
        }

        [HttpGet("getuser")]
        [Route("getuser")]
        public User GetUser()
        {
            return new User()
            {
                Id = 12,
                Name = "NameUser",
                Login = "LoginUser",
                Password = "Password",
                Birthday = DateTime.Now,

            };
        }
    }
}
