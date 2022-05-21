using System;
namespace TrackScoreExam
{
    public class PerfectNumber
    {
        public PerfectNumber()
        {
            
            int temp, sum = 0;
            Console.Write("Please Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine("Entered number " + num + " is a perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
            Console.ReadLine();

        }
    }
}
