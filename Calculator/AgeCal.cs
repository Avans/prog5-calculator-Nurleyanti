using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AgeCal : IAgeCalculator
    {
        public int CalculateAge(DateTime dateOfBirth)
        {
            return (DateTime.Today - dateOfBirth).Days / 365;
        }


public bool ParseInput(string input, out DateTime result)
        {
            
            if(DateTime.TryParse(input, out result))
            {if (input != null)
                {
                    return true;
                }
            }return false;
        }
    }
}
