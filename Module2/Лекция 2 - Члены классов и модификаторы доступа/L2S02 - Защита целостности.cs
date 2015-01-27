using System;
namespace L2S02
{
    public class Statistics
    {
        private double totalCount;
        private double successCount;

        public void AccountCase(bool success)
        {
            totalCount++;
            if (success) successCount++;
        }

        double GetPercent()
        {
            return (double)successCount * 100 / totalCount;
        }

        public void PrintStatistics()
        {
            Console.WriteLine("Statistics: {0}/{1} = {2}%", successCount, totalCount, GetPercent() );
        }
    }

    public class Program
    {
        public static void MainX()
        {
            var stat = new Statistics();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
                stat.AccountCase(rnd.Next(2) > 0);
            stat.PrintStatistics();
        }
    }
}

//!Инкапсулируем методами: выставляем наружу только то, что нужно