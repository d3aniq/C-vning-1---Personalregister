namespace C__Övning_1___Personalregister
{
    
    class Employee
    {
        public string name;
        public string salary;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[100]; //Max 100st anställda.
            int count = 0;

            Console.WriteLine("Personalregister");

            while (true)
            {
                Console.WriteLine("\n1. Lägg till anställd");
                Console.WriteLine("2. Visa alla anställda");
                Console.WriteLine("3. Avsluta\n");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Employee e = new Employee();

                    Console.Write("Namn: ");
                    e.name = Console.ReadLine();

                    Console.Write("Lön: ");
                    e.salary = Console.ReadLine();

                    employees[count] = e;
                    count++;
                }
                else if (choice == "2")
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(employees[i].name + " - " + employees[i].salary);
                    }
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel val, försök igen.");
                }
            }
        }
    }
}
