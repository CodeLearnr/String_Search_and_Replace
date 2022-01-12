using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA15_ReplaceString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LA_15: Replacing String in paragraph \n");
            /*Write a program that searches a string in a multi-line string input, and replaces all occurrences of the search string with a replace string.
              Example:
              Multi - line Input:
              Alex is a good student.Programming is fun for Alex.
              David, Susan, and Alex are good at C# programming.
              Alex is ambitious to create his / her career in Software Development.
              Search String: Alex
              Replace String: Your Name
              Output:
              Your Name is a good student.Programming is fun for Your Name.
              David, Susan and Your Name are good at C# programming.
              Your Name is ambitious to create his / her career in Software Development.*/

            string str1 = "Alex is a good student. Programming is fun for Alex.\nDavid, Susan, and Alex are good at C# programming.\nAlex is ambitious to create his/her career in Software Development.\n ";
            Console.WriteLine(str1);
            string oldName = "Alex";
                do
                {
                    Console.Write("Enter the name to be replace: ");
                    oldName = UppercaseFirst(Console.ReadLine());

                    if(str1.Contains(oldName) != true)
                        Console.WriteLine("Please enter a valid name!");
                }
                while (str1.Contains(oldName) != true);
                
            Console.Write("Enter the new name: ");
            string newName = UppercaseFirst(Console.ReadLine());
            char gender = 'M';
            string str2 = "his/her";

                do
                {
                    Console.Write($"{newName} is a male or female? ");
                    string str3 = Console.ReadLine().Substring(0, 1);
                    str3 = str3.ToUpper();
                    gender = Convert.ToChar(str3);

                    if (gender == 'F')
                    {
                        str2 = str1.Replace("his/her", "her");
                        break;
                    }
                    else if (gender == 'M')
                    {
                        str2 = str1.Replace("his/her", "his");
                        break;
                    }
                    else
                        Console.WriteLine($"Please enter {newName}'s gender ?");
                }
                while (gender != 'F' || gender != 'M');

            str2 = str2.Replace(oldName, newName);
            Console.WriteLine("\nThe result after name replacement:\n" + str2);

            Console.WriteLine("\nPlease any key to exit.");
            Console.ReadLine();
        }
        public static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
