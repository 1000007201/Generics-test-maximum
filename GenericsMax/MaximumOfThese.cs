using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMax
{
    public class MaximumOfThese
    {
        public double Max(double first_number, double second_number, double third_number)
        {
            if(first_number.CompareTo(second_number) > 0 && first_number.CompareTo(third_number)>0)
            {
                return first_number;
            }
            if(second_number.CompareTo(first_number) >0 && second_number.CompareTo(third_number) > 0)
            {
                return second_number;
            }
            return third_number;
        }
    }
}
