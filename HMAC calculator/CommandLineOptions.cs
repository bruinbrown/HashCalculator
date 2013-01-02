using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace HMAC_calculator
{
    public class CommandLineOptions
    {
        [CommandLineParser.Required]
        public HashProvider HashingAlgorithm;
        public string Key;
        [CommandLineParser.Required]
        public string Message;
    }
}
