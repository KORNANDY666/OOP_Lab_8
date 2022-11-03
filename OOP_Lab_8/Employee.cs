using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_8
{
    internal class Employee
    {
        // Creats the variables i need.

        int id;
        string name;
        string gender;
        int salery;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public int Salery { get { return salery; }set { salery = value; } }


        // Method that prints out stack and list items.
        public override string ToString()
        {
            return $"{Id} - {Name} - {Gender} - {Salery}";
        }


    }
}
