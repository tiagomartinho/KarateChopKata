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
            int half = numbers.Length / 2;
            for (int i = 0; i < 2; i++)
            {
                if (half < numbers.Length && numbers[half] == number)
                {
                    return half;
                }
                else
                {
                    if (half < numbers.Length && numbers[half] > number)
                    {
                        half = half / 2;
                        if (numbers[half] == number)
                        {
                            return half;
                        }
                    }
                    else
                    {
                        half = half + (half / 2) + 1;
                        if (half < numbers.Length && numbers[half] == number)
                        {
                            return half;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
