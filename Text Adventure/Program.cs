using System.Security.Cryptography.X509Certificates;

namespace Text_Adventure
{
    internal class Program
    {
        //enum Season
        //{
        //    Winter,
        //    Spring,
        //    Summer,
        //    Autumn
        //}

        //Season season = Season.Winter;

        struct Character
        {
            public string named;
            public string choseneded;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Testing message");
            Color();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Derek be blind to colors red and green\n\n\n\n\n");

            bool toggle = true;
            string error = "Unknown answer, check your spelling and capitalization";
            string answer = "Type 'Yes' or 'No'";
            string progress;
            string carry;
            string name;
            string nickname;
            List<string> rndName = ["Meadow", "Thomas", "Gabriel", "Mervielle", "Elina", "Oscar", "Derek", "Joshua", "Rain", "Nelson", "Ruth", "Dylan"];
            Random rng = new Random(); 
            int rndNum = rng.Next(12);
            string chosen = "";
            List<string> chosened = ["The Brazilian Drunkard", "The Professional Bear Wrestler", "El Maestro De Codifación", "Crazian Neko", "Ruth"];
            List<string> descript = ["Drunk… Just drunk, nothing else… He knows how to party though. He will help manage your people.", 
                "The professional russian bear wrestler is a strong and a bit of a loose cannon. She will help manage your battles.", 
                "¿Por qué ellos llaman lo ‘oven’ en inglés cuando tú de en el alimento frío de fuera calor comes el alimento? He will help manage your technical stuff.", 
                "Mizu kudasai. This crazy neko (Name by another person, not me) is thirsty. Neko will help manage your supplies.", 
                "Never quite being able to see clear, she has learned to adapt. She will help manage your strategies."];
            List<string> deny = ["Nah", "No", "No thank you", "No thanks", "Nope"];
            List<string> respond = ["Just say yes for once"];
            List<string> respondTail = [", for the love of whatever you consider holy."];
            int noCounter = 0;
            string rude;
            int stage = 1;

            if (stage == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Restarting");
                stage++;
            }
            if (stage == 1)
            {
                Console.Title = ("Section 1");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Salutations, new user. Thou art named...");
                Console.ForegroundColor = ConsoleColor.Yellow;
                name = Console.ReadLine();
                if (name == "")
                {
                    name = "Unregistered User";
                }
                Character character = new()
                {
                    named = name
                };
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Welcome, " + name + ", we've much to discuss.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                rude = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (deny.Contains(rude))
                {
                    rude = "";
                    noCounter++;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Bit rude innit?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(".");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("..");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("...");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Proceeding anyways...");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    rude = Console.ReadLine();
                    if (deny.Contains(rude))
                    {
                        noCounter++;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Too bad, shush now");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*A few seconds later, your eyes become flooded with light. \n" +
                    "A warm sensation overcomes you for a moment, like you are standing in the sun with a cool breeze. \n" +
                    "The sensation soon ends and is replaced by a cold one. \n" +
                    "Though the feeling is cold, it is inviting. \n" +
                    "It feels… familiar, like an old friend you once lost but now found after a millenia. \n" +
                    "All is calm, all is right, all is safe.*");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                Console.WriteLine("*You now find yourself seeing more than just light. \n" +
                    "You are now in a meadow, and it appears boundless, like you could run for hours and would only see the green grass, blue skies, and flowers each with a unique color. \n" +
                    "After observing this new realm you exist in, you then remember the voice, the voice which asked for your name. \n" +
                    "Wait, you had a name? You do not remember having a name, and how do you know what all this is called? \n" +
                    "You have never seen these… things, before. You feel you would remember if you had seen and felt such beautiful scenery.*");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Color();
                Console.WriteLine("Type 'Proceed' or 'Restart'");
                progress = Console.ReadLine();
                while (true)
                {
                    if (progress == "Proceed")
                    {
                        stage++;
                        progress = "";
                        break;
                    }
                    if (progress == "Restart")
                    {
                        stage = 0;
                        progress = "";
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(error);
                        Console.WriteLine("Type 'Proceed' or 'Restart'");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        progress = Console.ReadLine();
                    }
                }
            }
            if (stage == 2)
            {
                Console.Clear();
                Console.Title = ("Section 2");
                Color();
                Console.WriteLine("No's: " + noCounter);
                Console.WriteLine("Stage 01 completed");
                rude = "";
                noCounter = 0;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nWelcome to our world. The French have taken over our land and we must push them out. \n" +
                    "The Monarchs have the material funds and the Catholics have the spiritual funds, all at your disposal. Will you help us?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(answer);
                Console.ForegroundColor = ConsoleColor.Yellow;
                rude = Console.ReadLine();
                while (true)
                {
                    if (deny.Contains(rude))
                    {
                        rude = "";
                        noCounter++;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nWelp, you don't really have a choice... Anyways");
                        break;
                    }
                    if (rude == "Yes")
                    {
                        rude = "";
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nThank you very much. You'll be rewarded greatly in the after math");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(error);
                        Console.WriteLine(answer);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        rude = Console.ReadLine();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nNow, we need you to choose a nickname. We can't have others knowing your true name.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                nickname = Console.ReadLine();
                while (true)
                {
                    if (deny.Contains(nickname))
                    {
                        nickname = "";
                        noCounter++;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nYou don't have a choice");
                    }
                    if (nickname == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nFine, I'll choose one for you.");

                        Console.WriteLine("Here, " + rndName[rndNum] + " is your nickname");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("You will now be refered to as " + nickname);
                        break;
                    }
                }
                Console.WriteLine("The French have resurrected Napoleon with state of the art technology as a super-human version of himself. \n" +
                    "His chosen, Queenie, is ruthless and constantly shouts “I am your queenie, bow before me”. You yourself must have a chosen as well. \n" +
                    "This chosen will execute and manage tasks for you and be your voice to the public. \n" +
                    "You must choose between the: \n(1) Brazilian drunkard \n(2) The professional russian bear wrestler (Rooskiiy Chell) \n(3) or el maestro de codificación \n(4) Crazian neko \n(5) Ruth");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Type 1 to 5 to choose the corrosponding chosen");
                rude = Console.ReadLine();
                toggle = true;
                while (toggle)
                {
                    if (deny.Contains(rude))
                    {
                        rude = "";
                        noCounter++;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nKinda have to choose...");
                        break;
                    }
                    if (rude == "1")
                    {
                        rude = "";
                        chosen = chosened[0];
                        Console.WriteLine(chosened[0] + " will be your chosen");
                    }
                    if (rude == "2")
                    {
                        rude = "";
                        chosen = chosened[1];
                        Console.WriteLine(chosened[1] + " will be your chosen");
                    }
                    if (rude == "3")
                    {
                        rude = "";
                        chosen = chosened[2];
                        Console.WriteLine(chosened[2] + " will be your chosen");
                    }
                    if (rude == "4")
                    {
                        rude = "";
                        chosen = chosened[3];
                        Console.WriteLine(chosened[3] + " will be your chosen");
                    }
                    if (rude == "5")
                    {
                        rude = "";
                        chosen = chosened[4];
                        Console.WriteLine(chosened[4] + " will be your chosen");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(error);
                        Console.WriteLine(answer);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        rude = Console.ReadLine();
                    }
                }
                Character character = new()
                {
                    choseneded = chosen,
                };
                progress = Console.ReadLine();
                while (true)
                {
                    if (progress == "Proceed")
                    {
                        stage++;
                        progress = "";
                        break;
                    }
                    if (progress == "Restart")
                    {
                        stage = 0;
                        progress = "";
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(error);
                        Console.WriteLine("Type 'Proceed' or 'Restart'");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        progress = Console.ReadLine();
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void Color()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            current = Console.ForegroundColor;
        }

        enum colors
        {
            Red,
            Yellow,
            Green,
            Blue,
            Magenta
        }

        static ConsoleColor current;
    }
}