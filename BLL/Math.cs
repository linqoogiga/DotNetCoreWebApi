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

        public int Minus(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int Multiple(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public int divide(int a, int b)
        {
            int c = a / b;
            return c;
        }

        public string WorkTime(int hours)
        {
            if (hours > 12)
            {
                throw new Exception("HaHa");
            }

            // todo something
            return "Normal";
        }
    }

    public class AngryException : Exception
    {
        public AngryException(string message) : 
            base(message)
        {
        }
    }
}
