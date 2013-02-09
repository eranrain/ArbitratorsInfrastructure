using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbitratorModule
{
    public class ArbitratorUser : CoreModule.Core.User
    {
        public virtual ICollection<SecretShare> Shares { get; set; }
        public virtual ICollection<Contract > Contracts { get; set; }
    }
}
