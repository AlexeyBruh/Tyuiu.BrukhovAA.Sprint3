using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrukhovAA.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int i = 1; i <= x; i++)
                {
                    if ((x % i == 0) && (i > 5))
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
