using System;

namespace Program_Z.C
{
    internal class Program
    {
        public static void Main()
        {
            Menu();
        }
        static string[,] ttt = { { "1|", "2|", "3|", }, { "4|", "5|", "6|", }, { "7|", "8|", "9|" } };
        static bool p1t = true;
        static void Menu()
        {
            string menu;
            Console.WriteLine("Pick a game. Rock Paper Sscissors against Ross [1] or Tic Tac Toe against your friend [2].");
            menu = Console.ReadLine();
            if (menu == "1")
            {
                RPS();
            }
            else if (menu == "2")
            {
                TTT();
            }
            else
            {
                Console.WriteLine("That's not a valid option, please pick either Rock Paper Sscissors or Tic Tac Toe");
                Console.ReadLine();
                Menu();
            }
        }
        static void MR()
        {
            Console.WriteLine("Press [1] to return to menu");
            string mr;
            mr = Console.ReadLine();
            if (mr == "1")
            {
                Console.Clear();
                Menu();
            }
            else
            {
                Environment.Exit(0);
            }
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
                }
                else if (RPS == "2")
                {
                    Console.WriteLine("You win... Because Paper covers Rock. (╥_╥)");
                }
                else if (RPS == "3")
                {
                    Console.WriteLine("I win... because Rock smashes Scissors. :]");
                }
                else
                {
                    Console.WriteLine("That's not fair! (*_*)");
                }
            }
            if (c == 2)
            {
                if (RPS == "1")
                {
                    Console.WriteLine("I win... because Paper covers Rock. :]");
                }
                else if (RPS == "2")
                {
                    Console.WriteLine("I guess it's a tie...(¬,¬)");
                }
                else if (RPS == "3")
                {
                    Console.WriteLine(" You win... Because Scissors cut Paper. (╥_╥)");
                }
                else
                {
                    Console.WriteLine("That's not fair! (*_*)");
                }
            }
            if (c == 3)
            {
                if (RPS == "1")
                {
                    Console.WriteLine("You win... Because Rock smashes Scissors . (╥_╥)");
                }
                else if (RPS == "2")
                {
                    Console.WriteLine("I win... because Scissors cut Paper. :]");
                }
                else if (RPS == "3")
                {
                    Console.WriteLine("I guess it's a tie...(¬,¬)");
                }
                else
                {
                    Console.WriteLine("That's not fair! (*_*)");
                }
            }
            MR();
        }
        static bool CW()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (ttt[i, 0] == ttt[i, 1] && ttt[i, 1] == ttt[i, 2] && (ttt[i, 0] == "X|" || ttt[i, 0] == "O|"))
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (ttt[0, i] == ttt[1, i] && ttt[1, i] == ttt[2, i] && (ttt[0, i] == "X|" || ttt[0, i] == "O|"))
                {
                    return true;
                }
            }

            // Check diagonals
            if (ttt[0, 0] == ttt[1, 1] && ttt[1, 1] == ttt[2, 2] && (ttt[0, 0] == "X|" || ttt[0, 0] == "O|"))
            {
                return true;
            }

            if (ttt[0, 2] == ttt[1, 1] && ttt[1, 1] == ttt[2, 0] && (ttt[0, 2] == "X|" || ttt[0, 2] == "O|"))
            {
                return true;
            }

            return false;
        }

        static void GB()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int o = 0; o < 3; o++)
                {
                    Console.Write(ttt[0 + o, i]);
                }
                Console.WriteLine();
            }
        }
        static void TTT()
        {
            GB();
            //Console.Clear();
            if (p1t == true)
            {
                Console.WriteLine("Player 1 pick a space");
            }
            else
            {
                Console.WriteLine("Player 2 pick a space");
            }
            string move;
            move = Console.ReadLine();
            bool validMove = false;

            while (!validMove)
            {
                validMove = true;

                if (move == "1" && ttt[0, 0] != "X|" && ttt[0, 0] != "O|")
                {
                    ttt[0, 0] = p1t ? "X|" : "O|";
                }
                else if (move == "2" && ttt[0, 1] != "X|" && ttt[0, 1] != "O|")
                {
                    ttt[0, 1] = p1t ? "X|" : "O|";
                }
                else if (move == "3" && ttt[0, 2] != "X|" && ttt[0, 2] != "O|")
                {
                    ttt[0, 2] = p1t ? "X|" : "O|";
                }
                else if (move == "4" && ttt[1, 0] != "X|" && ttt[1, 0] != "O|")
                {
                    ttt[1, 0] = p1t ? "X|" : "O|";
                }
                else if (move == "5" && ttt[1, 1] != "X|" && ttt[1, 1] != "O|")
                {
                    ttt[1, 1] = p1t ? "X|" : "O|";
                }
                else if (move == "6" && ttt[1, 2] != "X|" && ttt[1, 2] != "O|")
                {
                    ttt[1, 2] = p1t ? "X|" : "O|";
                }
                else if (move == "7" && ttt[2, 0] != "X|" && ttt[2, 0] != "O|")
                {
                    ttt[2, 0] = p1t ? "X|" : "O|";
                }
                else if (move == "8" && ttt[2, 1] != "X|" && ttt[2, 1] != "O|")
                {
                    ttt[2, 1] = p1t ? "X|" : "O|";
                }
                else if (move == "9" && ttt[2, 2] != "X|" && ttt[2, 2] != "O|")
                {
                    ttt[2, 2] = p1t ? "X|" : "O|";
                }
                else
                {
                    Console.WriteLine("That's not a valid spot, please pick again");
                    validMove = true;
                    p1t = !p1t;
                }
            }
            bool isBoardFull = true;
            foreach (var spot in ttt)
            {
                if (spot != "X|" && spot != "O|")
                {
                    isBoardFull = false;
                    break;
                }
            }

            if (isBoardFull)
            {
                GB();
                Console.WriteLine("It's a draw!");
                MR();
                return;
            }
            if (CW())
            {
                GB();
                Console.WriteLine(p1t ? "Player 1 wins!" : "Player 2 wins!");
                MR();
                return;
            }

            p1t = !p1t; // Switch turns
            TTT();
            
        }
    }
}