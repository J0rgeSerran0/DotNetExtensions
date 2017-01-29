namespace DemoDotNetExtensions
{

    using System;
    using System.Threading;

    public class DemoExceptionExtensions
    {

        public static void GenerateException()
        {
            try
            {
                Exception1();
            }
            catch (Exception ex)
            {
                throw new ArrayTypeMismatchException("GenerateException method", ex);
            }
        }

        private static void Exception1()
        {
            try
            {
                Exception2();
            }
            catch (Exception ex)
            {
                Thread.Sleep(2500);
                throw new DivideByZeroException("Exception1 " + DateTime.UtcNow, ex);
            }
        }

        private static void Exception2()
        {
            throw new OverflowException("Exception2 " + DateTime.UtcNow);
        }

    }

}