/*
In the game Exquisite Corpse, participants draw either a head, body, or feet of a creature. The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.

For this project, you’ll write a program that mimics the Exquisite Corpse game. Using methods, you’ll be able to randomly combine different parts of ASCII characters so they create a new creature.
*/

using System;

namespace ExquisiteCorpse
{
    class Program
    { 
        static void BuildACreature(string head = null, string body = null, string feet = null)
        {
            Random randomNumber = new Random();
            int headNum = head != null ? TranslateToNumber(head) : randomNumber.Next(1, 4);
            int bodyNum = body != null ? TranslateToNumber(body) : randomNumber.Next(1, 4);
            int feetNum = feet != null ? TranslateToNumber(feet) : randomNumber.Next(1, 4);
            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void ManualMode()
        {
            Console.WriteLine("Select head (ghost, bug, monster): ");
            string head = Console.ReadLine().ToLower();
            Console.WriteLine("Select body (ghost, bug, monster): ");
            string body = Console.ReadLine().ToLower();
            Console.WriteLine("Select feet (ghost, bug, monster): ");
            string feet = Console.ReadLine().ToLower();
            BuildACreature(head, body, feet);
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;

                case 2:
                    BugHead();
                    break;

                case 3:
                    MonsterHead();
                    break;

                default:
                    GhostFeet();
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;

                case 2:
                    BugBody();
                    break;

                case 3:
                    MonsterBody();
                    break;

                default:
                    GhostFeet();
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;

                case 2:
                    BugFeet();
                    break;

                case 3:
                    MonsterFeet();
                    break;

                default:
                    GhostFeet();
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;

                case "bug":
                    return 2;

                case "monster":
                    return 3;

                default:
                return new Random().Next(1, 4); // Return a random value if input is invalid
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exquisite Corpse! Choose a mode:");
            Console.WriteLine("1. Manual Mode");
            Console.WriteLine("2. Random Mode");
            Console.Write("Enter your choice: ");
            string modeChoice = Console.ReadLine();

            switch (modeChoice)
            {
                case "1":
                    ManualMode();
                    break;
                case "2":
                    RandomMode();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting program.");
                    break;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
