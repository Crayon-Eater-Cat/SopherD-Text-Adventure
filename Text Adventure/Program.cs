namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Derek be blind to colors red and green\n\n\n\n\n");
            string error = "Unknown answer";
            int progress = 0;
            string choice1;
            string carry;
            string name;
            string output = "";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Salutations, new user. Thou art named...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome, " + name + ", we've much to discuss.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*A few seconds later, your eyes become flooded with light. \n" +
                "A warm sensation overcomes you for a moment, like you are standing in the sun with a cool breeze. \n" +
                "The sensation soon ends and is replaced by a cold one. \n" +
                "Though the feeling is cold, it is inviting. \n" +
                "It feels… familiar, like an old friend you once lost but now found after a millenia. \n" +
                "All is calm, all is right, all is safe.*");
            Console.ReadLine();
            Console.WriteLine("*You now find yourself seeing more than just light. \n" +
                "You are now in a meadow, and it appears boundless, like you could run for hours and would only see the green grass, blue skies, and flowers each with a unique color. \n" +
                "After observing this new realm you exist in, you then remember the voice, the voice which asked for your name. \n" +
                "Wait, you had a name? You do not remember having a name, and how do you know what all this is called? \n" +
                "You have never seen these… things, before. You feel you would remember if you had seen and felt such beautiful scenery.*");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to our world. The French have taken over our land and we must push them out. \n" +
                "The Monarchs have the material funds and the Catholics have the spiritual funds, all at your disposal. Will you help us?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please type 'Yes' or 'No'...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            choice1 = Console.ReadLine();
            progress++;
            if (progress == 1)
            {
                if (choice1 == "Yes")
                {
                
                }
                if (choice1 == "No")
                {

                }
                else
                {
                    Console.WriteLine(error);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Please type 'Yes' or 'No'...");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    choice1 = Console.ReadLine();
                }
            }


            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
