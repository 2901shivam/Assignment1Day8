using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1Day8
{
    internal class Program
    {

       static List<string> occurance(string input, string pattern)
        {
            List<string> result = new List<string>();
            Regex reg = new Regex(pattern);
            foreach(Match match in reg.Matches(input))
            {
                result.Add(match.Value);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text/sentence/paragraph");
            string input = Console.ReadLine();

            Console.WriteLine("Number of world present in the sentence");
            int count = 1;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            List<string> noofemai = occurance(input, pattern);

            foreach(string email in noofemai)
            {
                Console.WriteLine("No of email in text of input "+email);
            }
           

            string pattern2 = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            List<string> noOfPhone = occurance(input, pattern2);
           foreach(string mobile in noOfPhone)
            {
                Console.WriteLine("Number of mobile number in input text "+mobile);
            }

            
            
            Console.ReadKey();
        }
    }
}
