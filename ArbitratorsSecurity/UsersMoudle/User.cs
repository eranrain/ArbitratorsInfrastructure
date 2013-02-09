using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UsersModule.Core
{
    public class User : CoreModule.Core.User 
    {
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
