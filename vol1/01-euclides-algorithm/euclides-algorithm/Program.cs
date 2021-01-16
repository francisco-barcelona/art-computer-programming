using System;

namespace euclides_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euclid's Algorithm: Given two positive integers m and n, find their greatest common divisor, that is, the largest positive integer that evenly divides both m and n");
            Console.WriteLine("Write first positive integer m bigger than 0 and smaller than 2,147,483,647: ");
            string inputM = Console.ReadLine();
            int m;
            // Ensure m is a number
            while (!Int32.TryParse(inputM, out m))
            {
                Console.WriteLine("This is not a number or is bigger than 2,147,483,647, try again! ");
                inputM = Console.ReadLine();
            }
            // Ensure m is a positive integer
            while (m <= 0)
            {
                Console.WriteLine("This is a negative number or 0, write a positive one, try again! ");
                inputM = Console.ReadLine();
                while (!Int32.TryParse(inputM, out m))
                {
                    Console.WriteLine("This is not a number or bigger than 2,147,483,647, try again! ");
                    inputM = Console.ReadLine();
                }
            }
            
            Console.WriteLine("Write second positive integer n bigger than 0 and smaller than 2,147,483,647: ");
            string inputN = Console.ReadLine();
            int n;
            // Ensure n is a number
            while (!Int32.TryParse(inputN, out n))
            {
                Console.WriteLine("This is not a number or is bigger than 2,147,483,647, try again! ");
                inputN = Console.ReadLine();
            }
            // Ensure n is a positive integer
            while (n <= 0)
            {
                Console.WriteLine("This is a negative number or 0, write a positive one, try again! ");
                inputN = Console.ReadLine();
                while (!Int32.TryParse(inputN, out n))
                {
                    Console.WriteLine("This is not a number or bigger than 2,147,483,647, try again! ");
                    inputN = Console.ReadLine();
                }
            }

            // Ensure m>=n, if m<n, exchange m <-> n. This would not make an essential change in the algorith.
            if (m < n)
            {
                int t = m;
                m = n;
                n = t;
            }

            // r is equal to the modulus m mod n
            int r = m % n;
            // While modulus is not zero, m<-n, n<-r. So, r=0 is the finite condition of the algorithm.
            while(r != 0){
                m = n;
                n = r;
                r = m % n;
            }

            // Print result
            Console.WriteLine("the largest positive integer that evenly divides both m and n is: " + n);
        }
    }
}
