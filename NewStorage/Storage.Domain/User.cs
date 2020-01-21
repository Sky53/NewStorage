using System;
using System.Collections.Generic;

namespace Storage.Domain
{
    public class User
    {
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsDeleted { get; set; }
    }
}
