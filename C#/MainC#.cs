using System;//Clarifies System

namespace MainNamespace//Namespace works the same as a Java Class, but broader
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Integer = 10;
            Decimal = 10.9;
            Text = "This is text";
            Character = '$';
            TrueFalse  = false;

            if (Integer == 10 && Decimal > 10.9)
            {
                Text = "This is an If / Else Statement";
            }
            else
            {
                Text = "Variables can be updated";
            }

            while (Integer == 10)
            {
                Text = "While Statements repeat as long as the condition is true";
            }

            Console.WriteLine"This outputs text";
        }
    }
}

