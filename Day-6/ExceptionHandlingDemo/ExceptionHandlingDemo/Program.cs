using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static int Divide()
        {
            int x = 10;
            int y = 0;
            int z = 0;
            try
            {
                z = x / y;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return z;
        }
        static void Main()
        {
            try
            {
                int res = Divide();
            }
            catch(DivideByZeroException ex)
            {
                PrintException(ex);
            }
            catch(Exception ex)
            {
                PrintException(ex);
            }
        }

        private static void PrintException(Exception ex)
        {
            Console.WriteLine($"Type: {ex.GetType().Name}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Method: {ex.TargetSite}");
            Console.WriteLine($"Application: {ex.Source}");
            Console.WriteLine($"Details: {ex.StackTrace}");
        }
    }
}
