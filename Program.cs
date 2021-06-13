using System;

namespace ข้อ_3_สถิติ
{
    class Program
    {
        static void Main(string[] args)
        {
           double min = double.PositiveInfinity;
           double max = double.NegativeInfinity;
           double sum = 0;
            start(min,max,sum);

        }
        static void start(double min1,double max1,double sum1)
        {
            
            string num; int count=0;
            do
            {
                num = Console.ReadLine();
                if (num == "End") { break; }
                min1 = min(num,min1); max1 = max(num,max1); sum1 = mean(num,sum1);
                count++;
            } while (num != "End");
            string x = Console.ReadLine();
            if(x== "FindMax") { Console.WriteLine(max1); }
            else if (x == "FindMin") { Console.WriteLine(min1); }
            else if (x == "FindMean") { Console.WriteLine(sum1/count); }
            else { Console.WriteLine("Invalid mode"); }
        }

        static double min(string num,double min1)
        {
            double x = double.Parse(num);
             if (x < min1)
            {
                min1 = x;
            } 
            return min1;
        }
        
        static double max(string num, double max1)
        {

            double x = double.Parse(num);
            
            if (x > max1)
            {
                max1 = x;
    
            }
            return max1;
        }

        static double mean(string num,double sum1)
        {
            double x = double.Parse(num);
            sum1 = sum1 + x;
            return sum1;
        } 
    }
}
