 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO SIGN IN PAGE ! FILL YOUR ALL DOCUMENTS CAREFULLY");
            Console.WriteLine("Enter your first name");
            string fname = Console.ReadLine();

            Console.WriteLine("enter your surname name");
            string lname = Console.ReadLine();

            Console.WriteLine("your name is {0} {1}" , fname , lname);

            Console.WriteLine("Enter your mobile number ");
            string number = Console.ReadLine();
            Console.WriteLine("your mobile number is " + number);

            Console.WriteLine("enter your email id");
            string email = Console.ReadLine();
            Console.WriteLine("your email id is " + email);


            Console.WriteLine("Enter your date of birth (yyyy/mm/dd) : ");
            DateTime dateofbirth = DateTime.Parse(Console.ReadLine());

            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateofbirth.Year;

            if (currentDate.Month < dateofbirth.Month || (currentDate.Month == dateofbirth.Month && currentDate.Day < dateofbirth.Day))

            {
                age--;
            }
            Console.WriteLine("Your age is :" + age);

            if (age > 18)
            {
                Console.WriteLine("You are succesfully signed in");

            }
            else if (age < 18)
            {
                Console.WriteLine("You are under 18 so you cannot signup");
            }

            Console.ReadLine();


        }
    }
}
