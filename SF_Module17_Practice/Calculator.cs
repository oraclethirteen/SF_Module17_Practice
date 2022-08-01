using System;
using System.Text;

namespace SF_Module17_Practice
{
    public class Calculator
    {
        public ICount count { get; }
        public double balance { get; set; }


        public Calculator(ICount count)
        {
            this.count = count;
        }

        public void Calculate()
        {
            count.CalculateInterest(balance);
        }
    }
}
