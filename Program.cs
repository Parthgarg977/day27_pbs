using System;

namespace day27pbs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address book problems");

            AddressBook manager = new AddressBook();

            while (true)
            {
                Console.WriteLine("\nPlease Select any one option: ");
                Console.WriteLine("Select 1: For add Details to Address Book");
                Console.WriteLine("select 2: For Display All Contacts of Address Book");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    case 1:    
                        {
                            day27pbs person = new day27pbs();
                            Console.WriteLine("Enter First Name: ");
                            string firstname = Console.ReadLine();
                            person.FirstName = firstname;
                            Console.WriteLine("Enter Last Name: ");
                            string lastname = Console.ReadLine();
                            person.LastName = lastname;
                            Console.WriteLine("Enter Address: ");
                            string address = Console.ReadLine();
                            person.Address = address;
                            Console.WriteLine("Enter Phone Number: ");
                            long number = long.Parse(Console.ReadLine());
                            person.PhoneNumber = number;
                            manager.addday27pbs(person);
                        }
                        break;
                    case 2:   
                        {
                            manager.Display();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please Select any one operation ");
                        }
                        break;
                }
            }
        }
    }
}
