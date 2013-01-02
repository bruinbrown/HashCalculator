using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HMAC_calculator
{
    public static class HashingFactory
    {
        public static HashAlgorithm GetInstance(HashProvider algorithm)
        {
            switch (algorithm)
            {
                case HashProvider.SHA1:
                    return new SHA1CryptoServiceProvider();
                case HashProvider.MD5:
                    return new MD5CryptoServiceProvider();
                case HashProvider.HMACSHA1:
                    return new HMACSHA1();
                case HashProvider.HMACMD5:
                    return new HMACMD5();
                default:
                    return null;
            }
        }
    }
}
