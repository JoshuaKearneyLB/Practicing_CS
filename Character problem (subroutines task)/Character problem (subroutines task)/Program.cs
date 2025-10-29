using System;

namespace Character_problem__subroutines_task_
{
    class Program
    {
        
        // subroutines

        static string digits()
        {
            return ("0123456789");
        }

        static string characters()
        {
            return ("abcdABCD@#!$");
        }
        
        
        // main to output both of the subroutines at once
        static void Main(string[] args)
        {
            Console.WriteLine( "The alpha numeric characters are: {0}{1}",digits(),characters());
        }
    }
}
