using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignment
{

    public  class MaxNumber<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;

        public MaxNumber(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue)>0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue)>0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >=0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue)>0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue)>0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >=0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
            return default;
        }
        public T MaxMethod()
        {
            T max = MaxNumber<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);

            T max1 = MaxNumber<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
            return max;
            return max1;
        }
    }

}
