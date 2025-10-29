using System;

namespace Carpet_problem__subroutines_
{
    class Program
    {
        //subroutines

        static double Cost(double Width, double Length, double PriceOfCarpet_msq)
        {   
            // creating variables we can add together later
            const int Fee = 50;
            double Grippers = (Width * 2) + (Length * 2);
            double Carpet = (Width * Length) * PriceOfCarpet_msq;
            double Underlay = 3 * (Width * Length);


            // I TRIED DOING THE OUTPUTS IN A LOOP BUT, IT DIDNT WORK >
            //for (int i = 0; i < 3; i++)
           // {
                //Console.WriteLine("+ {i}", Fee, Grippers, Carpet, Underlay);

            //}

            
            Console.WriteLine("Fitting Fee : {0}", Fee);
            Console.WriteLine("Grippers : {0}", Grippers);
            Console.WriteLine("Carpet : {0}", Carpet);
            Console.WriteLine("Underlay : {0}", Underlay);
            

            return (Fee + Grippers + Carpet + Underlay);
        }



        //main (getting user inputs to put in the function )
        static void Main(string[] args)
        {

            Console.WriteLine("Enter width: ");
            double WIDTH = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Length: ");
            double LENGTH = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of carpet per metre sqaured: ");
            double PRICEOFCARPET_MSQ = double.Parse(Console.ReadLine());

            Console.WriteLine("Total : {0}", Cost(WIDTH, LENGTH, PRICEOFCARPET_MSQ));


        }
    }
}
