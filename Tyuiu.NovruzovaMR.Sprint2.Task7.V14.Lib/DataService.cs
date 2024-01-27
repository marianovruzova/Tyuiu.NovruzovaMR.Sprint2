using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.NovruzovaMR.Sprint2.Task7.V14.Lib;


namespace Tyuiu.NovruzovaMR.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x * x) + (y * y) <= 1 && ((x >= 0) || (y >= -x)))
            {
                return true;
            }
            return false;
        }
    }
}