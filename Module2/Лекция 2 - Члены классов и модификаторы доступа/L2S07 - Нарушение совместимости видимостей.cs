namespace L2S07
{
    internal class InternalClass
    {
    }

    public class PublicClass
    {
        private InternalClass CorrectField1;
        internal InternalClass CorrectField2;
        //public InternalClass IncorrectField; //нарушение правил видимости
    }
}

//!Нарушение правил видимости