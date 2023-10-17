using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2  ;

namespace Tyuiu.TolmachevVV.Sprint2.Review.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) < 1)
            {
                if (x > -(Math.Sqrt(2) / 2) && x < 0)
                {
                    if (y > -x)
                    {
                        return true;
                    }
                    else return false;
                }
                else return true;
            }
            else return false;
        }
    }
}
