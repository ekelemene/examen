using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаем объект класса DerivedClass,
            DerivedClass dClass = new DerivedClass();
            dClass.Method1();
            dClass.Method2();
            dClass.Method3();
        }
    }
    }
