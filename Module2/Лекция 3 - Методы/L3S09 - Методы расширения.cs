using System;
namespace L3S09
{
    public static class RandomExtensions
    {
        public static bool NextBool(this Random rnd)
        {
            return rnd.Next(2) > 0;
        }
    }

    class Program
    {
        public static void MainX()
        {
            var rnd = new Random();
            rnd.NextBool();
        }
    }


}

//!Extension метод