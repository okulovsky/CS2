namespace L2S06
{
    internal class InternalClass
    {

    }

    public class Program
    {
        public static void MainX()
        {
            var obj = new InternalClass(); // этот код не будет работать в другой сборке
        }
    }
}

//!internal class 
