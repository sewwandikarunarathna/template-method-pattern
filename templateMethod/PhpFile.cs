using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templateMethod
{
    public class PhpFile : DataProcessor
    {
        
       public override void Get()
        {
            Console.WriteLine("Get user data from php file.");
        }

        public override void Process()
        {
            Console.WriteLine("Process data from php file.");
        }

        
    }
}
