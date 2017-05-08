﻿using System;
using System.Collections.Generic;
using System.Linq;
using mono.Code;



//Project.App – ConsoleApplication project – entry point of your application(everything related to the console's input/output will be made here)

namespace mono.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string _input;

            Console.WriteLine("==== WELCOME ====");

            while (true)
            {
                Console.Write("Please specify desired operation: ");
                _input = Console.ReadLine().ToLower();

                if (_input == Code.Operations.op1)                              // Provjare koja je operacija odabrana te pokretanje iste
                {
                    Enlist();                    
                }
                else if (_input == Code.Operations.op2)
                {
                    Display();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operation name!!!");
                }
            }
        }

        public static void Enlist()
        {
            string _fname, _lname, _temp;
            decimal _gpa;
            Console.WriteLine("You have chosen ENLIST operation");

            while (true)
            {
                Console.WriteLine("Enter student first name: ");
                _fname = Console.ReadLine();

                if (ValidationClass.validateString(_fname))                                 // provjera stringa
                    break;
                else
                    Console.WriteLine("Invalid input, try again. Only text accepted");
            }

            while (true)
            {
                Console.WriteLine("Enter student second name: ");                           // provjera stringa
                _lname = Console.ReadLine();

                if (ValidationClass.validateString(_lname))
                    break;
                else
                    Console.WriteLine("Invalid input, try again. Only text accepted");
            }

            while (true)
            {
                Console.WriteLine("Enter student GPA (use comma for decimal): ");
                _temp = Console.ReadLine();
                if (Decimal.TryParse(_temp, out _gpa))                                  //prvo se provjerava je li uneseni string brojčana vrijednost
                {
                    _gpa = Math.Round(Convert.ToDecimal(_temp), 2);
                    if(ValidationClass.validateValueRng(_gpa))                          //provjera nalazi li se broj u intervalu [1,5]   
                        break;
                    else
                        Console.WriteLine("Invalid value, try again");
                }

                else
                    Console.WriteLine("Invalid input, try again. Please ");

            }

            StudentContainer.Students.Add(new Student(StudentIdGenerator.getId(), _fname, _lname, _gpa));            // ukoliko su sve provjere prosle ucenik se sprema u container
        }

        public static void Display()
        {
            List<Student> SortedList = StudentContainer.Students.OrderBy(o => o.LName).ToList();                    //sortiranje liste prije ispisa

            foreach (Student item in SortedList)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                Console.Write(item.Id);
                Console.WriteLine(". \t|\t {0} \t|\t {1} \t|\t {2} \t|", item.FName, item.LName, item.GPA);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }
    }
}
