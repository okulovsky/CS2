using System;
namespace L3S10
{
    public class UsefulClass
    {
        public int Sum(params int[] arguments)
        {
            var res = 0;
            foreach (var e in arguments)
                res += e;
            return res;
        }
    }
}

//!Модульное тестирование