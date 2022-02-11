using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMax
{
    public class MaximumOfThese<T> where T: IComparable
    {
        public T Max(T first, T second, T third)
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
