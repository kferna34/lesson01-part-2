using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

*author : Krytia Fernandez
*student number : 300845885
*date: may 13,2016
*/
namespace week01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName();
        }
        /*
        *reads the username from the console
        *@method getusername
        *@return{string} username
        */
        public static string GetUserName()
        {
            //initialize var || set username

            string UserName = "";
            OutputStringToConsole("Enter UserName:", false);
            UserName = Console.ReadLine();

            //shows the username entered
            Console.WriteLine("/n========================");
            Console.WriteLine("You entered:" + UserName);

            return UserName;

        }
        //condition for the display of username.. same line or not
        private static string OutputStringToConsole(string outputstring, bool hasNewLine)
        {
            if (hasNewLine)
            {
                Console.WriteLine(outputstring);
            }
            else
            {
                Console.Write(outputstring);
            }

            return outputstring;
        }
    }
}

