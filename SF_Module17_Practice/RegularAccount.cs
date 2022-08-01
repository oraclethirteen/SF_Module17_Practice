using System;
using System.Text;

namespace SF_Module17_Practice
{
    public class RegularAccount : ICount
    {
        public void CalculateInterest(double balance)
        {
            double interest = balance * 0.4;

            if (balance < 1000)
            {
                interest -= balance * 0.2;
            }

            if (balance < 50000)
            {
                interest -= balance * 0.4;
            }

            Console.WriteLine($"Процентная ставка обычного аккаунта: {interest}");
        }
    }
}
