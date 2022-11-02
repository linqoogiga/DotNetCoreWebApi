using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IMath
    {
        public int Add(int a, int b);

        public int Minus(int a, int b);

        public int Multiple(int a, int b);

        public int divide(int a, int b);

        public string WorkTime(int hours);
    }
}
