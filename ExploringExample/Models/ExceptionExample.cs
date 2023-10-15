using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringExample.Models
{
    public class ExceptionExample
    {
        public static void Method1()
        {
            Method2();
        }
        
        public static void Method2()
        {
            Method3();
        }

        public static void Method3()
        {
            Method4();
        }

        public static void Method4()
        {
            throw new Exception("An exception has ocurred.");
        }
    }
}