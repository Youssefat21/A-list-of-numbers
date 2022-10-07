using System;

namespace A_list_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number of elements of the list : ");
            int num = Int32.Parse(Console.ReadLine());
            double[] list = new double[num] ;
            int i;
            for (i = 0; i < num; i++)
            {
                Console.WriteLine("Enter your element : ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("==========================================================");
            if (list[0] == list[num-1])
            {
                Console.WriteLine("The first and last element of the list is : Equal");
            }
            else
            {
                Console.WriteLine("The first and last element of the list is : Not Equal");
            }
        }
    }
}
