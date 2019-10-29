using System;
using System.Text.RegularExpressions;

namespace ReggieExpresso
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateName();
            ValidateEmail();
            ValidatePhone();
            ValidateDate();
        }

        static void ValidateName()
        {   
            //prompt user to enter email
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Match m = Regex.Match(name, @"(^([A-Z]{1,30})+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$)");

            if (m.Success == false)
            {
                Console.WriteLine("Sorry, Name was invalid. Please try again.");
                ValidateName();
            }
            else
            {
                Console.WriteLine("Name valid!");
            }
        }


        static void ValidateEmail()
        {

            //prompt user to enter email
            Console.WriteLine("Enter your email address");
            string email = Console.ReadLine();

            Match m = Regex.Match(email, @"(?:[A-Za-z]+)(@)(?:[A-Za-z]+)(\.)(?:[A-Za-z]{3,5}$)");

            if (m.Success == false)
            {
                Console.WriteLine("Sorry, Email was invalid. Please try again.");
                ValidateEmail();
            }
            else {
                Console.WriteLine("Email valid!");
            }
        }

        static void ValidatePhone()
        {
            //prompt user to enter phone
            Console.WriteLine("Enter a phone number. Be sure to include the area code.");
            string input = Console.ReadLine();


            Match m = Regex.Match(input, @"(^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$)");

            if (m.Success == false)
            {
                Console.WriteLine("Sorry, phone is not valid. Try Again. 000-000-0000");
                ValidatePhone();
            }
            else {
                Console.WriteLine("Phone valid!");
            }
        }

        static void ValidateDate()
        {
            //prompt user to enter phone
            Console.WriteLine("Enter your favorite date (day, month, year)");
            string date = Console.ReadLine();

            Match m = Regex.Match(date, @"^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$");

            if (m.Success == false)
            {
                Console.WriteLine("Sorry, date is not valid. Try Again.");
                ValidateDate();
            }
            else {
                Console.WriteLine
                ("Date valid! However, the correct favorite date should be 06/24/1992, my birthday.");
            }
        }
    }
}
