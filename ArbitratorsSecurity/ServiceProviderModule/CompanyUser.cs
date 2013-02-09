using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreModule.Core;

namespace ServiceProviderModule
{
    public class CompanyUser : CoreModule.Core.User
    {
        public virtual ICollection<Contract> Contracts { get; set; }

    }
}
