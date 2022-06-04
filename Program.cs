// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp3
{
    internal class Chuongtrinh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ten gi: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nam sinh: ");
            int namsinh = Convert.ToInt32(Console.ReadLine());
            int tuoi = 2022 - namsinh;
            Console.WriteLine("Hello " + name + ", Nam nay ban duoc " + tuoi);
            
            //1132

           
        }
    }
}
