namespace Factory
{
    public class User
    {
        public void RightInput(string inputString)
        {
            char input = Convert.ToChar(inputString);

            if (input != 'e' && input != 'h')
            {
                throw new CharcterException();
            }
        }
    }

    public class CharcterException : Exception
    {

        public  CharcterException()
        {
            System.Console.WriteLine("Lütfen e ve h harflerini kullanalım !!!");
        }
    }
}