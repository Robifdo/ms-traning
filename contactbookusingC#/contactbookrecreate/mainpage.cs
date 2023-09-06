
using System;

namespace ContactBook
{

    class HomePage
    {
        public static void ShowingContactToUser(List<Dictionary<string, string>> contactDetails)
        {
            Console.WriteLine("hi");
        }


        public static List<Dictionary<string, string>> SavingContactToContactBook(List<Dictionary<string, string>> contactDetails)
        {

            Dictionary<string, string> Details = new Dictionary<string, string>();
            Console.WriteLine();
            Console.Write("Enter the FirstName :");
            string name;
            name = Console.ReadLine();

            Details.Add("name", name);

            Console.Write("Enter the Lastname :");
            string lastname = Console.ReadLine();

            Details.Add("lname", lastname);

            Console.Write("Enter the Email :");
            string email = Console.ReadLine();

            Details.Add("email", email);


            Console.Write("Enter the Mobile Number :");
            string mobnumber = Console.ReadLine();

            Details.Add("mobnumber", mobnumber);

            Console.Write("Enter the notes :");
            string notes = Console.ReadLine();

            Details.Add("notes", notes);
            contactDetails.Add(Details);

            return contactDetails;
        }



        public static void ShowingMenu(List<Dictionary<string, string>> contactDetails)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1.Save Contact");
            Console.WriteLine("2.Show Contact");
            Console.WriteLine("3.Edit Contact");
            Console.WriteLine("4.Delete Contact");
            Console.WriteLine("5.Exit Contact");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter your option :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contactDetails = SavingContactToContactBook(contactDetails);
                    Console.WriteLine("hi hello");
                    ShowingMenu(contactDetails);
                    break;
                case 2:
                    ShowingContactToUser(contactDetails);
                    break;
                case 3:
                    SavingContactToContactBook(contactDetails);
                    break;
                case 4:
                    SavingContactToContactBook(contactDetails);
                    break;
                case 5:
                    SavingContactToContactBook(contactDetails);
                    break;
                default:
                    SavingContactToContactBook(contactDetails);
                    break;
            }
        }
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> contactDetails = new List<Dictionary<string, string>>();
            ShowingMenu(contactDetails);
        }

    }
}