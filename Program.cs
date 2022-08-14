using System;
using System.Collections.Generic;
using System.Globalization;
using Curso_POO_Polimorfismo.Entities;
namespace Curso_POO_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the number of emplyees:");
            int nEmployees = int.Parse(Console.ReadLine());
            List<Employee> employee = new List<Employee>();


            for (int i = 0; i < nEmployees; i++)
            {
                Console.WriteLine("Employee #1 data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == 'y')
                {
                    int additionalCharge = int.Parse(Console.ReadLine());
                    employee.Add(new OutsourceEmployee(name, hour, valuePerHour, additionalCharge));
                }
                else
                {
                    employee.Add(new Employee(name, hour, valuePerHour));
                }
            }


            Console.WriteLine("PAYMENTS:");
            foreach (var n in employee)
            {
                Console.WriteLine($"{n.Name} - {n.Payment().ToString(CultureInfo.InvariantCulture)}");
            }



            Console.ReadLine();
        }
    }
}
