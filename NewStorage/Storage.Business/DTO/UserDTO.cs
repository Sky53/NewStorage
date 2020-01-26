using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Business.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
