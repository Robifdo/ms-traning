using contactbookusing_c_;
using System;
namespace ContactBook
{
    class HomePage
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> contactDetails = new List<Dictionary<string, string>>();
            Menupage.ShowingMenu(contactDetails);
        }
    }
}