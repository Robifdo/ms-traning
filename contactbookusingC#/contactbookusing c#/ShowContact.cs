using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactbookusing_c_
{
    internal class ShowContact
    {
        public static void ShowSingleContact(List<Dictionary<string, string>> contactDetails,int ContactIndex)
        {
            Console.WriteLine("------------------------------------------------------------");
            foreach (var items in contactDetails[ContactIndex - 1])
            {
                Console.WriteLine($"    {items.Key}   : {items.Value}");
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void ShowingAllContactToUser(List<Dictionary<string, string>> contactDetails)
        {
            int index = 0;
            Console.WriteLine("------------------------------------------------------------");
            foreach (var  contact in contactDetails)
            {
                Console.Write($"({ index + 1})");
                index++;
                foreach (var items in contact)
                {
                    Console.WriteLine($"    {items.Key}   : {items.Value}");
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
