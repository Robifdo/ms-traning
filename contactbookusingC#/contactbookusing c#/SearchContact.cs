using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactbookusing_c_
{
    internal class SearchContact
    {
        public static void SearchingTheContact(List<Dictionary<string, string>> contactDetails)
        {
            int i = 1;
            foreach (var items in contactDetails[0])
            {
                Console.WriteLine($"{i}.{items.Key}");
                i++;
            }
            Console.WriteLine();
            Console.Write("How do you want to search......:");
            int option = Convert.ToInt32( Console.ReadLine() );
            i = 1;
            string key = "";
            foreach (var items in contactDetails[0])
            {
                if(i == option)
                {
                    key = items.Key;
                }
                i++;
            }
            Console.Write($"\nEnter the {key} to search :");
            string value = Console.ReadLine();
            i = 0;
            bool contactFound = false;
            foreach (var items in contactDetails)
            {
                if (items.ContainsValue(value))
                {
                    contactFound = true;
                    break;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine();
            if (contactFound)
            {
                foreach (var items in contactDetails[i])
                {
                    Console.WriteLine($"{items.Key}:{items.Value}");
                }
            }
            else
            {
                Console.WriteLine("No contact found :(") ;
            }
            Menupage.ShowingMenu(contactDetails);
            
        }
    }
}
