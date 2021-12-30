using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter You names :");

            Console.Write("Enter name of the Father ");
            string myFather = Console.ReadLine();

            Console.Write("Enter name of the Mother ");
            string myMother = Console.ReadLine();

            Console.Write("enter name of your sibling ");
            string mySibling = Console.ReadLine();

            string myFamily = string.Concat(myFather,"  ", myMother,"  ", mySibling);

            string reversedString = ReverseString(myFamily);

            DisplayResults(reversedString);

            Console.ReadLine();
        }
        private static string ReverseString(string myFamily)
        {
            string reversed = "";
            char[] reverse = myFamily.ToCharArray();
            Array.Reverse(reverse);

            foreach(char item in reverse)
            {
                reversed += item;
            }

            return reversed;
        }
        private static void DisplayResults(string results)
        {
            Console.WriteLine(results);

            string myString = " My Name is John Omondi Who Leaves in Nyayo Estate  ";

            Console.WriteLine("{0}   {1}   {2} ",myString.Length,myString.Substring(2,5),myString.Trim());
            //Console.ReadLine();

            DateTime myBirthday = DateTime.Parse("19/08/1980");
            int myages = DateTime.Now.Year -  myBirthday.Year;
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine("I am {0} Years Old", myages);

            Console.WriteLine("I have lived for {0} Years", String.Format("{0:N}", myAge.TotalDays/365));

           
        }

    }
}
