using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;

namespace FCrypt
{
    class DecryptionRSA
    {

        RSA rsaModule;

        public void LoadKeys()
        {
            RSAParameters parameters = new RSAParameters();
            //parameters.Modulus = ;// ...
            //parameters.Exponent = ;// ...
            rsaModule = new RSACryptoServiceProvider();
            rsaModule.ImportParameters(parameters);
        }
    }
}
