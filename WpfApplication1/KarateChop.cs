using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class KarateChop
    {
        public int Chop(int number, int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int half;

            while (left <= right)
            {
                half = (left + right) / 2;

                if (number == numbers[half])
                {
                    return half;
                }

                if (number < numbers[half])
                {
                    right = half - 1;
                }
                else
                {
                    left = half + 1;
                }
            }

            return -1;
        }
    }
}
