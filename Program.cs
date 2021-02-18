using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> listOfStudents = new MyDictionary<string>();

            listOfStudents.Add("Eren Oktar");
            listOfStudents.Add("Doğukan İmirzalıoğlu"); // Students
            listOfStudents.Add("Cem Uzay");

            listOfStudents.List(); // Students List

            Console.WriteLine("\nAmount of students: "+listOfStudents.Count); //Amount Of Students

        }
    }
}