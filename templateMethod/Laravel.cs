using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templateMethod
{
    public class Laravel : DataProcessor
    {
        public override void Get()
        {
            Console.WriteLine("Get user data from laravel file.");
        }

        public override void Process()
        {
            Console.WriteLine("Process data from laravel file.");
        }

       
    }
}
