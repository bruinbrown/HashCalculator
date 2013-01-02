using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace HMAC_calculator
{
    class Program
    {
        static int Main(string[] args)
        {
            Encoding encoding = new ASCIIEncoding();
            var options = new CommandLineOptions();
            var parser = new CommandLineParser(options);
            if (!parser.ParseCommandLine(args))
            {
                Console.ReadLine();
                return -1;
            }
            var encrypter = HashingFactory.GetInstance(options.HashingAlgorithm);
            if (encrypter is KeyedHashAlgorithm)
            {
                ((KeyedHashAlgorithm)encrypter).Key = encoding.GetBytes(options.Key ?? "");
            }
            var bytes = encrypter.ComputeHash(encoding.GetBytes(options.Message));
            var converted = Convert.ToBase64String(bytes);
            Console.WriteLine(converted);
            Console.ReadLine();
            return 0;
        }
    }
}
