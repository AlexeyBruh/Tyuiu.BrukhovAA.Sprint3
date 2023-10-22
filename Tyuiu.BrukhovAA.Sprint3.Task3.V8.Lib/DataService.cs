using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrukhovAA.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach(char n in value)
            {
                if(Char.IsDigit(n))
                {
                    res = res + n;
                }
            }

            return Convert.ToInt32(res);
        }
    }
}
