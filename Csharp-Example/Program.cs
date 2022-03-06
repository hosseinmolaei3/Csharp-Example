using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Calculator Example In Console
            while (true)
            {
                try
                {
                    double adad1, adad2;
                    char alamat;
                    Console.WriteLine("kabar aziz adad 1 ro vared kon:");
                    adad1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("kabar aziz adad 2 ro vared kon:");
                    adad2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("kabar aziz alamat ro vared kon:");
                    alamat = char.Parse(Console.ReadLine());
                    if (alamat == '+')
                    {
                        Console.WriteLine(adad1 + adad2);
                    }
                    else if (alamat == '-')
                    {
                        Console.WriteLine(adad1 - adad2);
                    }
                    else if (alamat == '*')
                    {
                        Console.WriteLine(adad1 * adad2);
                    }
                    else if (alamat == '/')
                    {
                        Console.WriteLine(adad1 / adad2);
                    }
                    else
                    {
                        Console.WriteLine("alamat dorst vard kon jenab");
                    }
                }
                catch
                {
                    Console.WriteLine("karbar adad vard kon");
                }
            }
        }
    }
}
