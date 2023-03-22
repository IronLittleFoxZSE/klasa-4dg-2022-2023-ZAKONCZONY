using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirtsLib.Database.Entities
{
    public partial class RegisteredUser
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
