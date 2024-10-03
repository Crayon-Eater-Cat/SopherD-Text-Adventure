namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carry;
            string name;
            string output = "";
            Console.WriteLine("Salutations, new user. Thou art named...");
            name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name + ", we've much to discuss.");
            carry = Console.ReadLine();
            Console.WriteLine("*A few seconds later, your eyes become flooded with light.\n" +
                "A warm sensation overcomes you for a moment, like you are standing in the sun with a cool breeze*\n");
            Console.ReadLine();
        }
    }
}
