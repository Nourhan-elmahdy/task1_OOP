using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_OOP_Eraaasoft
{
    internal class Student
    {
        public int id;
        public string name;
        public StudentLevel studentLevel;
        public Address Addr;

        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {id}");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student Address: {Addr.City} {Addr.Street} {Addr.ZipCode}");
            Console.WriteLine($"Student Level: {studentLevel}");
        }
    }

}
