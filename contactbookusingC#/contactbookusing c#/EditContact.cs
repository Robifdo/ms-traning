using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace contactbookusing_c_
{
    class EditContact : ShowContact
    {
        public static void AskingUserChooseContact(List<Dictionary<string, string>> contactDetails)
        {
            ShowContact.ShowingAllContactToUser(contactDetails);
            Console.Write("Enter the contact number to Edit :");
            int ContactIndex = Convert.ToInt32(Console.ReadLine());
            if(ContactIndex<=contactDetails.Count && ContactIndex > 0)
            {
                ShowContact.ShowSingleContact(contactDetails, ContactIndex);
                Console.WriteLine("Which one you want to edit");
                Console.WriteLine();
                int i = 1;
                
                foreach(var items in contactDetails[ContactIndex - 1])
                {
                    Console.WriteLine($"{i}.{items.Key}");
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine("Type the option :");
                int option = Convert.ToInt32(Console.ReadLine());
                i = 1;
                string key="";
                foreach (var items in contactDetails[ContactIndex - 1])
                {
                    if(i == option)
                    {
                        key = items.Key;
                    } 
                    i++;
                }
                Console.WriteLine();
                Console.Write($"Enter the new {key} :");
                contactDetails[ContactIndex - 1][key] = Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("Invalie option......");
            }
        }
    }
}
