﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            
            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine("------------------");

            //TODO: Print the Average of numbers
            
            var avg = numbers.Average();
            Console.WriteLine($"Avg: {avg}");
            Console.WriteLine("------------------");
            
            //TODO: Order numbers in ascending order and print to the console
            var asc = numbers.OrderBy(ascending => ascending);
            Console.WriteLine(asc);
            foreach (var num in asc)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------");


            //TODO: Order numbers in descending order and print to the console
            var desc = numbers.OrderByDescending(descending => descending);
            Console.WriteLine(desc);
            foreach (var num in desc)
            {
                Console.WriteLine(num);
            }
            

            Console.WriteLine("------------------");

            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(num => num > 5);
            foreach (var num in greaterThanSix) {Console.WriteLine(num);}
            Console.WriteLine("------------------");

            
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Take 4 Descending");
            foreach (var num in desc.Take(4) )
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------");


            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 30;
            foreach (var num in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------");


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filtered = 
                employees.Where(emp => emp.FirstName.StartsWith('S') || emp.FirstName.StartsWith('C'))
                    .OrderBy(emp =>emp.FirstName);
            foreach (var emp in filtered) {Console.WriteLine(emp.FullName);}
            Console.WriteLine("------------------");


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            foreach (var emp in overTwentySix) {Console.WriteLine($"Name: {emp.FullName}, Age: {emp.Age}");}
            Console.WriteLine("------------------");


            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yearsOfExp = employees.Where(y => y.YearsOfExperience <= 10 && y.Age > 35);
            var sumOfYOE = yearsOfExp.Sum(emp => emp.YearsOfExperience);
            Console.WriteLine($"The Summed Years of Experience are: {sumOfYOE}");

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var averageYOE = yearsOfExp.Average(y => y.YearsOfExperience);
            Console.WriteLine($"The Average Years of Experience are: {averageYOE}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee ( "Alicia", "Braxton", 35, 3)).ToList();
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FullName}, {emp.Age}, {emp.YearsOfExperience}");
            }

            ;


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
