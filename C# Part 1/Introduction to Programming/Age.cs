using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myBirthdayString = Console.ReadLine();
            string todayString = "03.05.2016";
            string[] myBirthdayStringArr = myBirthdayString.Split('.');
            int monthB = Convert.ToInt32(myBirthdayStringArr[0]);
            int dayB = Convert.ToInt32(myBirthdayStringArr[1]);
            int yearB = Convert.ToInt32(myBirthdayStringArr[2]);
            string[] todayStringArr = todayString.Split('.');
            int monthT = Convert.ToInt32(todayStringArr[0]);
            int dayT = Convert.ToInt32(todayStringArr[1]);
            int yearT = Convert.ToInt32(todayStringArr[2]);
            int myYearsNow;
            if (monthB < monthT)
            {
                myYearsNow = yearT - yearB;
                Console.WriteLine(myYearsNow);
                Console.WriteLine(myYearsNow + 10);
            }
            else if (monthB == monthT)
            {
                if (dayB > dayT)
                {
                    myYearsNow = yearT - yearB - 1;
                    Console.WriteLine(myYearsNow);
                    Console.WriteLine(myYearsNow + 10);
                }
                else
                {
                    myYearsNow = yearT - yearB;
                    Console.WriteLine(myYearsNow);
                    Console.WriteLine(myYearsNow + 10);
                }
            }
            else
            {
                myYearsNow = yearT - yearB - 1;
                Console.WriteLine(myYearsNow);
                Console.WriteLine(myYearsNow + 10);
            }

        }
    }
}
