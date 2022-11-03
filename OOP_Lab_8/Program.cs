namespace OOP_Lab_8                                     // Andreas Blom YH.Net -22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creates a empty stack ande then instansiate 5 object, and use Push method to put them in the stack.
            Stack<Employee> empStack = new Stack<Employee>();

            Employee e1 = new Employee() { Id = 100, Name = "Hasse", Gender = "M",Salery = 15900 };
            Employee e2 = new Employee() { Id = 101, Name = "Märta", Gender = "F", Salery = 25500 };
            Employee e3 = new Employee() { Id = 102, Name = "Göran", Gender = "M", Salery = 11900 };
            Employee e4 = new Employee() { Id = 103, Name = "Agda", Gender = "F", Salery = 26100 };
            Employee e5 = new Employee() { Id = 104, Name = "Jörgen", Gender = "M", Salery = 16000 };

   
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            // Print out all the employees and items in the stack.
            Console.WriteLine("Items left in the stack " + empStack.Count);
            foreach (Employee employees in empStack)
            {
                Console.WriteLine(employees);
                Console.WriteLine("Items left in the stack = " + empStack.Count);
            }

            Console.WriteLine("-----------------------------------------------------------");

            // Retrieves the objects in a Pop method through a while loop and prints out items left in the stack.
            Console.WriteLine("Retrive using Pop Method.");
            while (empStack.Count > 0)
            {
                Console.WriteLine("{0}", empStack.Pop());
                Console.WriteLine("Items left in the stack = " + empStack.Count);
            }


            // Adds the objects again through the Push method.
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            Console.WriteLine("-------------------------------------------------------------");

            // Picks out two objects using the Peek method, and then prints how many objects are left on the stack

            Console.WriteLine("Retrive using Peek Method.");

            Console.WriteLine(empStack.Peek());
            Console.WriteLine("Items left in the stack = " + empStack.Count);
            Console.WriteLine(empStack.Peek());
            Console.WriteLine("Items left in the stack = " + empStack.Count);

            Console.WriteLine("--------------------------------------------------------------");

            // Checking if employee 3 is in the stack

            if (empStack.Contains(e3) == true)
            {
                Console.WriteLine("Employee 3 is in the stack ");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in the stack ");
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("");

            // Creates a list and adds 5 objects.

            List<Employee> empList = new List<Employee>();
            empList.Add(e1);
            empList.Add(e2);
            empList.Add(e3);
            empList.Add(e4);
            empList.Add(e5);

            // Checking if Employee 2 is in the List.
            if (empList.Contains(e2) == true)
            {
                Console.WriteLine("Employee 2 exists in the list ");
            }
            else
            {
                Console.WriteLine("Employee 2 is not in the list ");
            }
            Console.WriteLine("");

            // Print out first Object in the List with gender M
            Console.WriteLine(empList.Find(i => i.Gender == "M"));

            Console.WriteLine("");

            // Prints out all objects with gender M
            var findAll = empList.FindAll(i => i.Gender == "M");
            foreach (var item in findAll)
            {
                Console.WriteLine(item);
            }

        }
    }
}