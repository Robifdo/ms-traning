using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactbookusing_c_
{
    internal class SaveContact
    {
        public void SavingContactToContactBook(List<Dictionary<string, string>> contactDetails)
        {

            Dictionary<string, string> Details = new Dictionary<string, string>();
            Console.WriteLine();
            Console.Write("Enter the FirstName :");
            string name;
            name = Console.ReadLine();

            Details.Add("name", name);

            Console.Write("Enter the Lastname :");
            string lastname = Console.ReadLine();

            Details.Add("lastname", lastname);

            Console.Write("Enter the Email :");
            string email = Console.ReadLine();

            Details.Add("email", email);


            Console.Write("Enter the Mobile Number :");
            string mobnumber = Console.ReadLine();

            Details.Add("mobilenumber", mobnumber);

            Console.Write("Enter the notes :");
            string notes = Console.ReadLine();

            Details.Add("notes", notes);
            contactDetails.Add(Details);

            Menupage.ShowingMenu(contactDetails);

        }
    }
}
