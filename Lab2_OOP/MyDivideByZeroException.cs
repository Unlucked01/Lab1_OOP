using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    internal class MyDivideByZeroException : DivideByZeroException
    {
        public MyDivideByZeroException(): base("Деление на ноль невозможно!") { }
    }
}
