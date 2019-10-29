using System;
using System.Text.RegularExpressions;

namespace trycatch
{
    class Program
    {
        static public bool validName(String name)
        {
            return Regex.IsMatch(name, "[A-Z]{1}[a-z]{1,29}$");
        }
        static public bool validEmail(String email)
        {
            return Regex.IsMatch(email, "[a-zA-Z0-9]{5-30}@{1}[a-zA-Z0-9]{5-10}\\.{1}[A-Za-z]{2-3}$");
        }
        static public bool validPhone(String phone)
        {
            return Regex.IsMatch(phone, "[0-9]{3}[-]{1}[0-9]{3}[-]{1}[0-9]{4}");
        }
        static public bool validDate(String date)
        {
            return Regex.IsMatch(date, "[0-1]{1}[0-9]{1}[/]{1}[0-9]{2}[/]{1}[0-9]{4}");
        }
        static void Main(string[] args)
        {
            string email, name, phone, date;

            Console.WriteLine("Please enter a valid name?");
            name = Console.ReadLine();
            bool namecheckk = validName(name);
            if (namecheckk == true)
            {
                Console.WriteLine("Name is Valid!");
            }
            else if (namecheckk == false)
            {
                Console.WriteLine("Sorry, name is not valid!");
            }

            Console.WriteLine("Please enter a valid email?");
            email = Console.ReadLine();
            bool emailcheckk = validEmail(email);
            if (emailcheckk == true)
            {
                Console.WriteLine("Email is Valid!");
            }
            else if (emailcheckk == false)
            {
                Console.WriteLine("Sorry, email is not valid!");
            }


            Console.WriteLine("Please enter a valid phone number?");
            phone = Console.ReadLine();
            bool phonecheckk = validPhone(phone);
            if (phonecheckk == true)
            {
                Console.WriteLine("Phone number is Valid!");
            }
            else if (phonecheckk == false)
            {
                Console.WriteLine("Sorry, phone number is not valid!");
            }


            Console.WriteLine("Please enter a valid date?");
            date = Console.ReadLine();
            bool datecheckk = validDate(date);
            if (datecheckk == true)
            {
                Console.WriteLine("Date is Valid!");
            }
            else if (datecheckk == false)
            {
                Console.WriteLine("Sorry, date is not valid!");
            }

        }
    }
}
