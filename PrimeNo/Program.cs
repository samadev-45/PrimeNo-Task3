namespace PrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int number=3;
            if (number <= 1)
            {
                Console.WriteLine("Its not a prime");
                return;
            }
            for(int i=2; i <= number - 1; i++)
            {
                if(number%i == 0)
                {
                    isPrime = false;
                    break;
                }
                
            }
            if(isPrime == true)
            {
                Console.WriteLine("its prime no");
            }
            else
            {
                Console.WriteLine("Its not prime no");
            }
        }
    }
}
