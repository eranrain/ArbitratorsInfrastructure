using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbitratorModule
{
    public class SecretShare
    {
        public int Serial { get; set; }

        public virtual byte[] ShareData { get; set; }

        public virtual int ShareIndex {get; set;}

        public virtual Boolean HandedToProvider {get; set;}
        
        public virtual ArbitratorUser Arbitrator { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
