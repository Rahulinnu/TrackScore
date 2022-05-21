using System;
namespace TrackScoreExam
{
    public class ReverseNumber
    {
        public ReverseNumber()
        {
            Console.WriteLine("Welcome to Reverse Number");
            Console.WriteLine("Please Enter a Number To check Reverese Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp, rem, rev = 0;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }

            Console.WriteLine("Reverse of the number " + temp + " is: " + rev);

        }
    }
}
