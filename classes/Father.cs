using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Father : Grandfather // наследование методов деда
    {
        public string father_say() // метод отца
        {
            return "I'm father method";
        }
    }
}
