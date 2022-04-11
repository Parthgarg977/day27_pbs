using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day27pbs
{
    public class day27pbs
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public long PhoneNumber;

        public string Result()
        {
            return " Name is: " + FirstName + " " + LastName + "\n Address: " + Address + "\n Phone: " + PhoneNumber;
        }
    }

    public class AddressBook
    {

        public List<day27pbs> person = new List<day27pbs>(); 
        public AddressBook()
        {
            string json = File.ReadAllText(@"E:\BridgeLabzAssignment\day27_pbs\File.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<day27pbs>>(json);
            }
            else
                person = new List<day27pbs>();
        }

        public void Display() 
        {
            if (person.Count == 0)
            {
                Console.WriteLine("Please add Some Contact list First");
            }
            Console.WriteLine("Welcome to Program");
            foreach (day27pbs per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void add day27pbs(day27pbs p)  
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"E:\BridgeLabzAssignment\day27_pbs\File.json", jsonData);
        }
    }
}
