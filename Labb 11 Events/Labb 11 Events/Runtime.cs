using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_11_Events
{
    class Runtime
    {
        public delegate void AnalyzeNumber();
        private event AnalyzeNumber NumberInput;
        int input;

        public void Start()
        {
            NumberInput += new AnalyzeNumber(IsEven);
            NumberInput += new AnalyzeNumber(IsDivisableByThree);
            NumberInput += new AnalyzeNumber(IsPrimeNumber);

            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            OnNumberInput();
            Console.ReadLine();
        }

        private void OnNumberInput()
        {
            NumberInput.Invoke();
        }

        private void IsEven()
        {
            if (input % 2 == 0)
            {
                Console.WriteLine(input + " is even.");
            }
            else
            {
                Console.WriteLine(input + " is not even.");
            }
        }
        
        private void IsDivisableByThree()
        {
            if (input % 3 == 0)
            {
                Console.WriteLine(input + " is dividable by 3.");
            }
            else
            {
                Console.WriteLine(input + " is not divadable by 3.");
            }
        }

        private void IsPrimeNumber()
        {
            bool isPrime = true;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(input + " is a prime number.");
            }
            else
            {
                Console.WriteLine(input + " is not a prime number.");
            }
        }
    }
}
