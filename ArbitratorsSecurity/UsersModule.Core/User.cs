using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreModule.Core
{
    public class User
    {
        public virtual string UserId { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string TelNumber { get; set; }

        public virtual string EmailAddr { get; set; }

        public virtual string Password { get; set; }

        public virtual string Info { get; set; }

        public virtual DateTime DateCrated { get; set; }

        public virtual DateTime LastLogIn { get; set; }

    }
}
