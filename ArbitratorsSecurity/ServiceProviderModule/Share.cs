using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceProviderModule
{
    public class Share
    {
        public virtual int Serial { get; set; }
        
        public virtual Contract Contract { get; set; }

        public virtual byte[] Share { get; set; }

        public virtual int ShareIndex { get; set; }
    }
}
