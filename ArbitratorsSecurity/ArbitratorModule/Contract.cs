using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ArbitratorModule
{
    public class Contract
    {

        //Class Members

        public virtual Guid Guid { get; set; }

        public virtual int Stage { get; set; }

        public virtual Byte[] Commitment { get; set; }

        public virtual string ToU { get; set; }

        public virtual RSAParameters UserPublicKey { get; set; }

        public virtual string ViolatedMessage { get; set; }

        public virtual byte[] ViolatedMessageSignature { get; set; }

        public virtual ICollection<SecretShare> Shares { get; set; }

        public virtual ICollection<ArbitratorUser> Arbitratros { get; set; }
    }
}
