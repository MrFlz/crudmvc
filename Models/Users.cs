using System;
using System.Collections.Generic;

namespace crudmvc.Models
{
    public partial class Users
    {
        public int Iduser { get; set; }
        public string Nickname { get; set; }
        public string Rolename { get; set; }
        public string Password { get; set; }
    }
}
