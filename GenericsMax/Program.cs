// See https://aka.ms/new-console-template for more information
using GenericsMax;


MaximumOfThese<string> maxstring = new MaximumOfThese<string>();
MaximumOfThese<int> maxint = new MaximumOfThese<int>();
MaximumOfThese<float> maxfloat = new MaximumOfThese<float>();
maxstring.Max("Apple","Peach","Banana");
maxint.Max(1,2,3);  
maxfloat.Max(5.4f, 1.2f, 2.1f);