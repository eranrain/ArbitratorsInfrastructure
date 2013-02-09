using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


namespace UsersModule.Core
{
    public class Contract
    {

        //Class Members
        public virtual int SerialNum { get; set; }

        public virtual User User { get; set; }

        public virtual Guid Guid { get; set; }

        public virtual Byte[] polynom {get; set;}

        public virtual int Stage { get; set; }

        public virtual Byte[] Commitment {get; set;}

        public virtual Byte[] SigCaC { get; set; }

        public virtual string ToU { get; set; }

        public virtual Byte[] SigCaToU { get; set; }

        public virtual RSAParameters RSAData{get; set;}

        public virtual Byte[] SigCaPublicKey { get; set; }

        public virtual ICollection<Arbitrator> Arbitrators { get; set;  }


    }
}
