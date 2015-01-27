using System;
namespace L2S01
{
    public class Statistics
    {
        public int totalCount;
        public int successCount;
    }

    public class Program
    {
        public static void MainX()
        {
            var stat = new Statistics();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                stat.totalCount++;
                stat.successCount += rnd.Next(2) > 0 ? 1 : 0;
            }
            Console.WriteLine("Statistics: {0}/{1} = {2}%", stat.successCount, stat.totalCount, (double)stat.successCount*100 / stat.totalCount);
        }
    }
}

//!Пример на инкапсуляцию: неинкапсулированный класс, можно сделать successCount>totalCount и получить >100%