using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templateMethod
{
    class TestTemplate
    {
        static void main()
        {
            DataProcessor obj1 = new PhpFile();
            obj1.GetProcessStore();

            DataProcessor obj2 = new Laravel();
            obj2.GetProcessStore();
        }
    }
}
