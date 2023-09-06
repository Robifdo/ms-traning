using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactbookusing_c_
{
    internal class Menupage
    {
        public static void ShowingMenu(List<Dictionary<string, string>> contactDetails)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1.Save Contact");
            Console.WriteLine("2.Show Contact");
            Console.WriteLine("3.Edit Contact");
            Console.WriteLine("4.Delete Contact");
            Console.WriteLine("5.Search Contact");
            Console.WriteLine("6.Exit Contact");
            Console.WriteLine();
            Console.WriteLine();



            Console.Write("Enter your option :");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------------------------------------");


            switch (option)
            {
                case 1:
                    SaveContact save = new SaveContact();
                    save.SavingContactToContactBook(contactDetails);
                    break;
                case 2:
                    ShowContact.ShowingAllContactToUser(contactDetails);
                    Menupage.ShowingMenu(contactDetails);
                    break;

                case 3:
                    EditContact.AskingUserChooseContact(contactDetails);
                    Menupage.ShowingMenu(contactDetails);
                    break;

                case 4:
                    DeleteContact.DeleteContactFromContactBook(contactDetails);
                    break;

                case 5:
                    SearchContact.SearchingTheContact(contactDetails);
                    break;

                case 6:
                    break;

                default: 
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
