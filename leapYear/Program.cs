using System;

namespace leapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            
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
