using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMax
{
    public class MaximumOfThese
    {
        public string Max(string first, string second, string third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo(third)>0)
            {
                return first;
            }
            if(second.CompareTo(first) >0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            return third;
        }
    }
}
