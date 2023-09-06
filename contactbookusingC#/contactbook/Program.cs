using System.Collections.Generic;

static void SaveContact(List<object> contact_details)
{
	Dictionary<string, string> details = new Dictionary<string, string>();
	Console.Write("Enter the First name :");
	string fname = Console.ReadLine();
	details["Firstname"] = fname;
	

	Console.Write("Enter the Last name :");
	string lname = Console.ReadLine();
	details["Lastname"] = lname;
	

	Console.Write("Enter the Mobile number :");
	string mobilenumber = Console.ReadLine();
	details["Mobilenumber"] = mobilenumber;
	

	Console.Write("Enter the Email id :");
	string Email = Console.ReadLine();
	details["Email"] = Email;
	

	Console.Write("Enter the Country :");
	string country = Console.ReadLine();
	details["Country"] = country;
	

	Console.Write("Enter the Relationship :");
	string relation = Console.ReadLine();
	details["Relation"] = relation;

	contact_details.Add(details);

	Console.WriteLine(contact_details[0]);

	menu(contact_details);
}
static void ShowContact(List<object> contact_details)
{
	foreach(object contact in contact_details)
	{
		Console.WriteLine(contact);
	}
}
static void EditContact(List<object> contact_details)
{
	Console.WriteLine("Edit contact option......");
	menu(contact_details);
}
static void DeleteContact(List<object> contact_details)
{
	Console.WriteLine("1.Save Contact");
	menu(contact_details);
}
static void SearchContact(List<Object> contact_details)
{
	Console.WriteLine("1.Save Contact");
	menu(contact_details);
}
static void menu(List<string> contact_details)
{
    Console.WriteLine();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("1.Save Contact");
	Console.WriteLine("2.Show Contact");
	Console.WriteLine("3.Edit Contact");
	Console.WriteLine("4.Delete Contact");
	Console.WriteLine("5.Search Contact");
	Console.WriteLine("6.Exit");
	Console.WriteLine();
	Console.Write("Enter your choise :");
	int Choice = Convert.ToInt32(Console.ReadLine());
	if(Choice>6 || Choice<1)
	{
		Console.WriteLine("Invalid Choice");
	}
	else
	{
		switch(Choice)
		{
			case 1:
				SaveContact(contact_details);
				break;
			case 2:
				ShowContact(contact_details);
				break;
			case 3:
				EditContact(contact_details);
				break;
			case 4:
				DeleteContact(contact_details);
				break;
			case 5:
				SearchContact( contact_details);
				break;
		}
	}
}

Console.WriteLine("Contact book");
List<string> contact_details = new List<string>();


menu(contact_details);

