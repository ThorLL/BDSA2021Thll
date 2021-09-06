using System;

namespace leapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year to test whether or not it's a leap year, hit enter afterwards.");
            int year = int.Parse(Console.ReadLine());
            if(IsLeapYear(year)){
                Console.WriteLine("Yay");
            }else{
                Console.WriteLine("Nay");
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
