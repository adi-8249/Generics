using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class FindMaximum
    {
        public int MaxNumber(int Number1, int Number2, int Number3)
        {
            if (Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) > 0)
            {
                return Number1;
            }
            if (Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) > 0)
            {
                return Number2;
            }
            if (Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) > 0)
            {
                return Number3;
            }
            throw new Exception("Either two or three inputs are same");
        }
    }
}
