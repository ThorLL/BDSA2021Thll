using System;

namespace leapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year to test whether or not it's a leap year, hit enter afterwards.");
            while (true)
            {
                var input = Console.ReadLine();
                try
                {
                    int year = int.Parse(input);     
                    if(IsLeapYear(year))
                    {
                        Console.WriteLine("Yay");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Nay");
                        return;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("'"+ input + "' is not an integer, e.g. 420");
                }
                
                
            }
            
        }
        public static bool IsLeapYear(int year){
        if(year % 4 == 0){
            if(year % 100 == 0){
                return year % 400 == 0;
            }else {
                return true;
            }
        }else{
            return false;
        }
    }
    }
    

}
