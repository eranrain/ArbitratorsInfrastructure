using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ServiceProviderModule
{
    public class Contract
    {

        //Class Members
        public virtual int SerialNum { get; set; }

        public virtual CompanyUser Provider { get; set; }

        public virtual Guid Guid { get; set; }

        public virtual int Stage { get; set; }

        public virtual Byte[] Commitment { get; set; }

        public virtual string ToU { get; set; }

        public virtual RSAParameters UserPublicKey { get; set; }

        public virtual ICollection<Arbitrator> Arbitrators { get; set; }

        public virtual ICollection<Share> RecviedShares { get; set; }
    }
}
