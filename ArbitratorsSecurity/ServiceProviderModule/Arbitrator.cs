﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceProviderModule
{
    public class Arbitrator
    {
        public virtual int Serial { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual string ArbitratorId { get; set; }

        public virtual int ArbitratorIndex { get; set; }

        public virtual Boolean Apprvoed { get; set; }
    }
}
