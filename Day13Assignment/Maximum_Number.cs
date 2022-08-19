using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignment
{
    public class Maximum_Number<T> where T : IComparable
    {
        public T[] value;

        public Maximum_Number(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValues(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        public T MaxMethod()
        {
            var max = MaxValues(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValues(this.value);
            Console.WriteLine("Maximum value is "+max);
        }

    }
}
