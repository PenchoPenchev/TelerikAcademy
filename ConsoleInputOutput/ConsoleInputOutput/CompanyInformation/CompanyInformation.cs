namespace CompanyInformation
{
    using System;

    class CompanyInformation
    {
        static void Main(string[] args)
        {
            /*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age               and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.*/

            Console.Write("Firm name: ");
            string firmName = Console.ReadLine();

            Console.Write("Firm address: ");
            string firmAddress = Console.ReadLine();

            Console.Write("Firm phone number: ");
            string firmPhone = Console.ReadLine();

            Console.Write("Firm fax: ");
            string firmFax = Console.ReadLine();

            Console.Write("Firm web site: ");
            string firmSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Manager phone number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm name is {0}. It's located at {1}. Phone number: {2}, fax: {3}, web site: {4}. {0}.", firmName,                      firmAddress, firmPhone, firmFax, firmSite);
            Console.WriteLine("Firm manager names are {0} {1}. His phone number is {2}", managerFirstName, managerLastName, managerPhone);
        }
    }
}
