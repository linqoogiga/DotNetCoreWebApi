using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Math:IMath
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
