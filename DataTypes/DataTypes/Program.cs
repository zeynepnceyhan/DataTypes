namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = 'Z';
            string name = "Zeynep";
            bool condition = false;
            int number1 = 10;
            long number2 = 289568764568;
            short number3 = 4567;
            byte number4 = 255;
            Console.WriteLine("Number1 is " + number1 + "\nNumber1's data type is int");
            Console.WriteLine("Number2 is " + number2 + "\nNumber2's data type is long");
            Console.WriteLine("Number3 is " + number3 + "\nNumber3's data type is short");
            Console.WriteLine("Number4 is " + number4 + "\nNumber4's data type is byte");
            Console.WriteLine("Condition is " + condition + "\nCondition's data type is bool");
            Console.WriteLine("Character is " + character + "\nCharacter's data type is char");
            Console.WriteLine("Name is " + name + "\nName's data type is string");
            Console.ReadLine();
        }
        
    }

}