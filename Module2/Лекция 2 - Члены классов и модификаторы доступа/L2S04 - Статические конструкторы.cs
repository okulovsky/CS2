﻿using System;
namespace L2S04
{
    public class Statistics
    {
        static string percentString;

        public static void SetPercentString(string percentString)
        {
            Statistics.percentString = percentString;
        }

        static Statistics()
        {
            throw new Exception("Ooops!");
            percentString = "%";
        }

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
            Statistics.SetPercentString(" percent");
            var stat = new Statistics();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
                stat.AccountCase(rnd.Next(2) > 0);
            stat.PrintStatistics();
        }
    }

}

//!Осторожно: исключения в статическом конструкторе! Возникают внезапно.