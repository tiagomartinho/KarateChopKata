using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class KarateChop
    {
        public int Chop(int number, int[] numbers) {
            if(numbers.Length == 0)
            {
                return -1;
            }

            int half = numbers.Length / 2;
            if (numbers[half] == number)
            {
                return half;
            }
            else
            {
                if(numbers[half] > number)
                {
                    half = half / 2;
                    if (numbers[half] == number)
                    {
                        return half;
                    }
                }
            }

            return -1;
        }
    }
}
