using System;

namespace UC7_TwoPlayers
{ 
    class Program
    {
        public static int No_Play = 1;
        public static int Ladder = 2;
        public static int Snake = 3;
        public static int Win_position = 100;
        public static int Position_check = 0;
        public static int Start_Position = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakeAndLadder program");
            boolean player1IsPlaying = true;
            int player1Position = START_POSITION, player2Position = START_POSITION, dieRoll, options, dieRolledTimes = 0;
            Random random = new Random();
            while (player1Position != Win_position && player2Position != Win_position)
            {
                dieRoll = random.Next(6) + 1;
                dieRolledTimes++;
                options = random.Next(3) + 1;

                switch (options)
                {
                    case 1:
                        if (player1IsPlaying)
                        {
                            player1Position += 0;
                            player1IsPlaying = false;
                        }
                        else
                        {
                            player2Position += 0;
                            player1IsPlaying = true;
                        }
                        break;
                    case 2:
                        if (player1IsPlaying)
                        {

                            if (player1Position + dieRoll <= Win_position)
                            {

                                player1Position += dieRoll;
                                Console.WriteLine("Player 1 landed on a ladder");

                            }

                        }
                        else
                        {

                            if (player2Position + dieRoll <= Win_position)
                            {

                                player2Position += dieRoll;
                                Console.WriteLine("Player 2 landed on a ladder");

                            }

                        }
                        break;
                    case 3:
                         if (player1IsPlaying)
                        {

                            player1Position -= dieRoll;
                            player1IsPlaying = false;

                            if (player1Position < 0)
                            {

                                player1Position = 0;

                            }

                            Console.WriteLine("Player 1 landed on a snake");

                        }
                        else
                        {

                            player2Position -= dieRoll;
                            player1IsPlaying = true;

                            if (player2Position < 0)
                            {

                                player2Position = 0;

                            }

                            Console.WriteLine("Player 2 landed on a snake");
                            break;
                        }
                    default:
                        Console.WriteLine("Enter proper value");
                        break;

                }
                Console.WriteLine("Player 1 position  = " + player1Position);
                Console.WriteLine("Player 2 position  = " + player2Position);

            }

            if (player1Position == 100)
            {

                Console.WriteLine("Player 1 won the game!");

            }
            else
            {

                Console.WriteLine("Player 2 won the game!");

            }
            Console.WriteLine("Dice was rolled " + dieRolledTimes + " to win the game");
        }
    }
}
