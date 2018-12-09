using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {

                double user1, user2, user3;

                Console.WriteLine("Enter in three dollar values ");// prompting the user to add numbers
                List<double> currancy = new List<double>();// addding the user numbers to a list array

                Console.WriteLine("Enter first number");//entering the numbers and storing it into the currancy list
                user1 = double.Parse(Console.ReadLine());
                currancy.Add(user1);
                Console.WriteLine("Enter secound number");
                user2 = double.Parse(Console.ReadLine());
                currancy.Add(user2);
                Console.WriteLine("Enter third number");
                user3 = double.Parse(Console.ReadLine());
                currancy.Add(user3);

                
                Console.WriteLine("_________\n");
                Console.WriteLine($"US dollar {user1.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");// converting number each dollar value 
                Console.WriteLine($"Swedish {user1.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE"))}");
                Console.WriteLine($"Thai {user1.ToString("c", CultureInfo.CreateSpecificCulture("th-TH"))}"); 
                Console.WriteLine($"Japanies Yen {user1.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"))}");

                Console.WriteLine("_________\n");
                Console.WriteLine($"US dollar {user2.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");//printing secound number
                Console.WriteLine($"Swedish {user2.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE"))}");
                Console.WriteLine($"Thai {user2.ToString("c", CultureInfo.CreateSpecificCulture("th-TH"))}");
                Console.WriteLine($"Yen {user2.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"))}");

                Console.WriteLine("_________\n");
                Console.WriteLine($"US dollar {user3.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");// third number printed out
                Console.WriteLine($"Swedish {user3.ToString("c", CultureInfo.CreateSpecificCulture("sv - SE"))}");
                Console.WriteLine($"Yen {user3.ToString("c", CultureInfo.CreateSpecificCulture("th - TH"))}");
                Console.WriteLine($"US dollar {user3.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"))}");



                Console.WriteLine("_________\n");
                Console.WriteLine("Lowest number is {0}", currancy.Min());//the list is having the minumum maxumum and average taken  
                Console.WriteLine("Highest number is {0}", currancy.Max());
                Console.WriteLine(String.Format("Average is {0:0}", currancy.Average()));// you must use the string.format 

                Console.WriteLine("\nWould you like to to run this program agian y/n");//asking the user if they want to continue
                string userAnswer = Console.ReadLine().ToLower();// reading in the users answer

              if (userAnswer == "y")//if the enter a y it will continue back to the top of the loop 
              {
                  continue;

              }
              else if (userAnswer == "n")//if n is entered the the loop will break and the program will end
              {
                  Console.WriteLine("Goodbye");
                   break; 
              }
               
            }
        }
    }
}