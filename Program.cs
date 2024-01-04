using System.Collections.Generic;

namespace OppgaveFraCodealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> Personlist = new List<Person>()
            {
                 new Person("John Doe", 25, "123 Main St"),
            new Person("Jane Smith", 30, "456 Oak St"),
            new Person("Bob Johnson", 22, "789 Elm St"),
            new Person("Alice Brown", 35, "101 Pine St"),
            new Person("David White", 28, "202 Maple St")
            };
            foreach (var person in Personlist)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Adress: {person.Address}");
            }
            Console.WriteLine("Would you like to add a person to your list?");
            
            var input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "y" || input == "yeah" || input == "ok")
            {
                AddPerson(Personlist);
                foreach (var person in Personlist)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Adress: {person.Address}");
                }
       
            }
            else 
            {
                Console.WriteLine("Ok");
            }


        }
        private static void AddPerson(List<Person> Personlist)
        {
            
            
                Console.WriteLine("Submit name of the person");
                string name = Console.ReadLine();
               
                Console.WriteLine("Submit the age of the person");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
                
                Console.WriteLine("Submit the address of the person");
                string address = Console.ReadLine();
                
                Person newPerson = new Person(name, age, address);

                Personlist.Add(newPerson);

                Console.WriteLine($"Person {name} added to the list.");


            
        }
    }
}
