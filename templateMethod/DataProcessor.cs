using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templateMethod
{
    public abstract class DataProcessor
    {
        public void GetProcessStore()
        {
            Get();
            Process();
            Store();
        }

        public abstract void Get();
        public abstract void Process();  
        public void Store()
        {
            Console.WriteLine("Store user data to MySQL.");
        }
    }
}
