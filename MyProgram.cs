using Average;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
        
         
            //create doubles
            double a, b, c;

            //do first #
            Console.Write("Enter the First number: ");
            a = Convert.ToDouble(Console.ReadLine());

            //do second #
            Console.Write("Enter the Second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            //do third #
            Console.Write("Enter the third number: ");
            c = Convert.ToDouble(Console.ReadLine());


            Average.Average.MyAvg(a,b,c);
        }
    }
}

// Created on 2/6/23

/* Lab 2 completed by Michael Ramos TECH4982-01 */
////