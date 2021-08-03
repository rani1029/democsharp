using System;

namespace EmployeeWageUc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNum = new Random();
            int present = ranNum.Next(0, 2);
            Console.WriteLine("{present}");
            if (present == 1)
            {
                Console.WriteLine("Employee is present");

            }
            else
                Console.WriteLine("Employee is not present");



        }
    }
}
