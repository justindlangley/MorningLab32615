using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningLab32615
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter in a one-word description of the item requested for approval?");
            string UserDescription = Console.ReadLine();
            
            Console.WriteLine("What is the cost of the item for approval?");
            var price = Console.ReadLine();
            var userPrice = int.Parse(price);
        }

        private static string ThirdLevelTest(string UserDescription, int userPrice)
        {
            if (userPrice < 1000)
            {
                Console.WriteLine("Approved");
            }

            if (userPrice > 1000)
            {
                Console.WriteLine("Escalated.");
            }

            else (UserDescription = "hardware" && userPrice > 5000);
            {
                Console.WriteLine("Denied.");
            }
            return UserDescription;
        }

        private static string SecondLevelTest(string UserDescription, int userPrice)
        {
            if (userPrice < 500 && !UserDescription = "towncar")
            {
                Console.WriteLine("Approved");
            }

            if (userPrice > 500 && !UserDescription = "towncar")
            {
                Console.WriteLine("Escalated.");
            }
            else (UserDescription = "enertainment");
            {
                Console.WriteLine("Denied.");
            }
            return UserDescription;
        }

        private static string FirstManagerTest(string UserDescription, int userPrice)
        {
            if (userPrice < 250 && !UserDescription = "Entertainment")
            {
                Console.WriteLine("Approved");
            }

            if (userPrice > 250 && !UserDescription = "Entertainment")
            {
                Console.WriteLine("Escalated.");
            }
            else (UserDescription = "Entertainment");
            {
                Console.WriteLine("Denied.");
            }
            return UserDescription;
        }
        enum ManagerLevel
        {
            firstLevel,
            secondLevel,
            thirdLevel,
            CEOLevel

        }
        enum Status
        {
            Approved,
            Rejected,
            Escalated
             
        }
    }
}

