using System;

namespace Program_Z.C
{
    internal class Program
    {
        public static void Main()
        { 
            Menu();
        }
        static void RPS()
        {
            string RPS;
            
            Console.WriteLine("Hey, I'm Ross! let's play rock, paper, scissors!");
            Console.WriteLine("Rock[1], Paper [2], Scissors[3]");
            Random R = new Random();
            int c = R.Next(1, 3);
            RPS = Console.ReadLine();
            if (c == 1)
            {
                if (RPS == "1")
                {
                    Console.WriteLine("I guess it's a tie...(¬,¬)");
                    Console.ReadLine();
                }
                else if (RPS == "2")
                {
                    Console.WriteLine("You win... Because Paper covers Rock. (╥_╥)");
                    Console.ReadLine();
                }
                else if (RPS == "3")
                {
                    Console.WriteLine("I win... because Rock smashes Scissors. :]");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That's not fair! (*_*)");
                    Console.ReadLine();
                }
            }
            if (c == 2)
            {
                if (RPS == "1")
                {
                    Console.WriteLine("I win... because Paper covers Rock. :]");
                    Console.ReadLine();
                }
                else if (RPS == "2")
                {
                    Console.WriteLine("I guess it's a tie...(¬,¬)");
                    Console.ReadLine();
                }
                else if (RPS == "3")
                {
                    Console.WriteLine(" You win... Because Scissors cut Paper. (╥_╥)");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That's not fair! (*_*)");
                    Console.ReadLine();
                }
            }
            if (c == 3)
            {
                if (RPS == "1")
                {
                    Console.WriteLine("You win... Because Scissors smashes Rock. (╥_╥)");
                    Console.ReadLine();
                }
                else if (RPS == "2")
                {
                    Console.WriteLine("I win... because Scissors cut Paper. :]");
                    Console.ReadLine();
                }
                else if (RPS == "3")
                {
                    Console.WriteLine("I guess it's a tie...(¬,¬)");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That's not fair! (*_*)");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();
            Menu();
        }
        static void GB()
        {
            string[,] ttt = { { "1|", "2|", "3|", }, { "4|", "5|", "6|", }, { "7|", "8|", "9|" } };
            Console.Write(ttt[0, 0]);
            Console.Write(ttt[0, 1]);
            Console.WriteLine(ttt[0, 2]);
            Console.Write(ttt[1, 0]);
            Console.Write(ttt[1, 1]);
            Console.WriteLine(ttt[1, 2]);
            Console.Write(ttt[2, 0]);
            Console.Write(ttt[2, 1]);
            Console.WriteLine(ttt[2, 2]);
        }
        static void TTT()
        {
            GB();
            Console.Write("Player 1 pick a space");
            string move;
            move = Console.ReadLine();
            if (ttt ("x"||"o") == [0, 0], [0, 1], [0, 2])
        }
        static void UTTT() 
        {
            Console.WriteLine("Placeholder");        
        }
        static void Menu()
        {
            string menu;
            Console.WriteLine("Pick a game. RPS against Ross [1] or TTT against your friend [2]. There's also Ultimate Tic Tac Toe[3]");
            menu = Console.ReadLine();
            if (menu == "1")
            {
                RPS();
            }
            else if (menu == "2")
            {
                TTT();
            }
            else if (menu == "Speech")
            {
                Console.WriteLine("Machine, turn back now. The layers of this palace are not for your kind. Turn back, or you will be crossing the Will of GOD... Your choice is made. As the righteous hand of the Father, I shall REND YOU APART, and you will become inanimate once more.\nBEHOLD! THE POWER OF AN ANGEL!\nWhat ? How can this be ? Bested by this... this thing ? You insignificant FUCK! THIS IS NOT OVER! May your woes be many, and your days few!\nMachine, I know you're here. I can smell the insolent stench of your bloodstained hands. I await you down below. Come to me.\nLimbo, Lust, all gone... With Gluttony soon to follow.Your kind know nothing but hunger; purged all life on the upper layers, and yet they remain unsatiated... As do you.You've taken everything from me, machine. And now all that remains is PERFECT HATRED.\nMachine... I will cut you down, break you apart, splay the gore of your profane form across the STARS! I will grind you down until the very SPARKS CRY FOR MERCY!My hands shall RELISH ENDING YOU... HERE! AND! NOW!'nTwice! ? Beaten by an object... Twice! I've only known the taste of victory, but this taste... Is- Is this my blood? Haha- I've never known such... Such... relief.. ? I - I need some time to think... We will meet again, machine. May your woes be many... and your days few.");
                Console.ReadLine();
            }
            else if (menu == "3")
            {
                UTTT();
            }
            else
            {
                Console.WriteLine("That's not a valid option, please pick either RPS or TTT");
                Console.ReadLine();
                Menu();
            }
        }
      
    }
}