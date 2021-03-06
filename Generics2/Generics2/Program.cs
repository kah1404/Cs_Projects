﻿using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
//            TestGenerics8();
//            TestGenerics7();
//            TestGenerics6();
//            TestGenerics5();
//            TestGenerics4();
//            TestGenerics3();
//            TestGenerics2();
//            TestGenerics1();
        }

        private static void TestGenerics8()
        {
            var employeesByName = new SortedDictionary<int, List<Employee>>
            {
                {2, new List<Employee>{ new Employee(), new Employee(), new Employee()}},
                {3, new List<Employee>{ new Employee(), new Employee(), new Employee()}},
                {5, new List<Employee>{ new Employee(), new Employee(), new Employee()}},
                {4, new List<Employee>{ new Employee(), new Employee(), new Employee()}},
                {1, new List<Employee>{ new Employee(), new Employee(), new Employee()}}
            };

            foreach (var item in employeesByName)
            {
                Console.WriteLine($"The count of employees for {item.Key} is {item.Value.Count}");
            }


        }

        private static void TestGenerics7()
        {
            var employeesByDepartment = new Dictionary<string, List<Employee>>
            {
                { "R&C", new List<Employee>{new Employee{Name = "Kevin", Wage = 0}}},
                { "Instructors", new List<Employee>{new Employee{Name = "Scott", Wage = 300}}},
                { "LostAndFound", new List<Employee>{new Employee{Name = "Truls", Wage = 1}}}
            };

            employeesByDepartment["R&C"].Add(new Employee{ Name = "Andreas", Wage = 0});
            employeesByDepartment["Instructors"].Add(new Employee{ Name = "Terje", Wage = 260});

//            var countKeys = employeesByDepartment.Keys.Count;
//            Console.WriteLine(countKeys);
//
//            var countValues = employeesByDepartment.Values.Count;
//            Console.WriteLine(countValues);
//
//            var count = employeesByDepartment.Count;
//            Console.WriteLine(count);


            foreach (var item in employeesByDepartment)
            {
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"Department: {item.Key}: {employee.Name}: Hourly wage {employee.Wage:C}");
                }
            }

           

            Console.WriteLine("-------");

            var employeesByName = new Dictionary<string, Employee>
            {
                {"Kevin", new Employee {Name = "Kevin"}},
                {"Scott", new Employee {Name = "Scott"}},
                {"Truls", new Employee {Name = "Truls"}},

            };

            foreach (var item in employeesByName)
            {
                Console.WriteLine($"{item.Key}:{item.Value.Name}");
            }

        }

        private static void TestGenerics6()
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(3);

            var first = list.First;
            list.AddAfter(first, 5);
            list.AddBefore(first, 10);

            var node = list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

            Console.WriteLine("---------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void TestGenerics5()
        {
            var dates = new HashSet<DateTime> {DateTime.Now, DateTime.Today, DateTime.MaxValue, DateTime.MinValue};

            foreach (var date in dates)
            {
                Console.WriteLine(date);
            }

            Console.WriteLine("-------");

            var setEmployee = new HashSet<Employee>();
            var empolyee = new Employee{ Name = "Ost" };
            var empolyee2 = new Employee{ Name = "Ost" };
            setEmployee.Add(empolyee);
            setEmployee.Add(empolyee2);
            setEmployee.Add(new Employee{ Name = "Kevin" });
            setEmployee.Add(new Employee{ Name = "Scott" });
            setEmployee.Add(new Employee{ Name = "Truls" });
            

            foreach (var item in setEmployee)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("------");

            var setInteger = new HashSet<int> {1, 2, 2};

            foreach (var item in setInteger)
            {
                Console.WriteLine(item);
            }
        }

        private static void TestGenerics4()
        {
            var queue = new Queue<Employee>();
            queue.Enqueue(new Employee { Name = "Kevin" });
            queue.Enqueue(new Employee { Name = "Scott" });
            queue.Enqueue(new Employee { Name = "Truls" });


            while (queue.Count > 0)
            {
                var employee = queue.Dequeue();
                Console.WriteLine(employee.Name);

            }

            Console.WriteLine("--------");

            var stack = new Stack<Employee>();
            stack.Push(new Employee { Name = "Kevin" });
            stack.Push(new Employee { Name = "Scott" });
            stack.Push(new Employee { Name = "Truls" });


            while (stack.Count > 0)
            {
                var employee = stack.Pop();
                Console.WriteLine(employee.Name);

            }
        }

        private static void TestGenerics3()
        {
            var queue = new Queue<Employee>();
            queue.Enqueue(new Employee {Name = "Kevin"});
            queue.Enqueue(new Employee {Name = "Scott"});
            queue.Enqueue(new Employee {Name = "Truls"});


            while (queue.Count > 0)
            {
                var employee = queue.Dequeue();
                Console.WriteLine(employee.Name);

            }

        }

        private static void TestGenerics2()
        {
            var numbers = new List<int>();
            var capacity = -1;

            while (true)
            {
                if (numbers.Capacity != capacity)
                {
                    capacity = numbers.Capacity;
                    Console.WriteLine(capacity);
                }

                numbers.Add(1);
            }
        }

        private static void TestGenerics1()
        {
            var employees = new List<Employee>
            {
                new Employee {Name = "Kevin"},
                new Employee {Name = "Scott"}
            };

            employees.Add(new Employee{Name = "Hans"});

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].Name);
            }
        }
    }
}
