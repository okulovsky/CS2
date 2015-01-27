using System;
namespace L2S05
{
    public class Statistics
    {
        internal static string percentString = "%";

        private double totalCount;
        private double successCount;

        public void AccountCase(bool success)
        {
            totalCount++;
            if (success) successCount++;
        }

        public void PrintStatistics()
        {
            Console.WriteLine("Statistics: {0}/{1} = {2}{3}", 
                successCount, 
                totalCount, 
                (double)successCount * 100 / totalCount, 
                percentString);
        }
    }

    public class Program
    {
        public static void MainX()
        {
            Statistics.percentString = " percent"; //но сделать это из другой сборки этого уже нельзя
            var stat = new Statistics();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
                stat.AccountCase(rnd.Next(2) > 0);
            stat.PrintStatistics();
        }
    }

}

//!internal поля: нельзя поменять из другой сборки