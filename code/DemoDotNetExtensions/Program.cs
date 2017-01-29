namespace DemoDotNetExtensions
{

    using DotNetExtensions;
    using System;

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Demo - DotNetExtensions");

            // StringExtensions - Repeat
            Console.WriteLine('-'.Repeat(23));
            Console.WriteLine();

            // ExceptionExtensions
            try
            {
                DemoExceptionExtensions.GenerateException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExceptionExtensions");
                var info = ex.GetMessagesFromInnerExceptions().ToString();
                Console.WriteLine(info);
                Console.WriteLine();
            }


            Console.WriteLine("Press any key to close the App");
            Console.ReadLine();
        }

    }

}