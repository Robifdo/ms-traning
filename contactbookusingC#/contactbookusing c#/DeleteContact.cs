using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactbookusing_c_
{
    internal class DeleteContact
    {
        public static void DeleteContactFromContactBook(List<Dictionary<string, string>> contactDetails)
        {
            ShowContact.ShowingAllContactToUser(contactDetails);
            Console.WriteLine();
            Console.Write("Which contact your want to delete :");
            int contactIndex = Convert.ToInt16(Console.ReadLine());
            ShowContact.ShowSingleContact(contactDetails, contactIndex);
            Console.WriteLine("Are your want to delete this contact from contactbook.......Yes(Y) or No(N)");
            char Option = Convert.ToChar(Console.ReadLine());
            if(Option == 'y' || Option == 'Y')
            {
                contactDetails.Remove(contactDetails[contactIndex-1]);
            }
            Menupage.ShowingMenu(contactDetails);
        }
        
    }
}
