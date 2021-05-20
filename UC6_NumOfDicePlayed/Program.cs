using System;

namespace UC6_NumOfDicePlayed
{
    class Program
    {
		public static int No_Play = 1;
		public static int Ladder = 2;
		public static int Snake = 3;
		public static int Win_position = 100;
		public static int Position_check = 0;
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to SnakeAndLadder program");
			int noOfDieRoll = 0;
			int position = 0;

			Console.WriteLine("Start position of player :	" + position);

			while (position < Win_position)
			{

				Random random = new Random();
				int droll = 0;
				while (true)
				{
					droll = random.Next(7);
					if (droll != 0) break;
				}

				Console.WriteLine("Number of dice : " + droll);

				Random ran = new Random();
				noOfDieRoll++;
				int option = 0;
				while (true)
				{
					option = ran.Next(4);
					if (option != 0) break;
				}

				Console.WriteLine("====OPTIONS======\nOption 1 : No Play\nOption 2 : Ladder \nOption 3 : Snake \n");

				Console.WriteLine("Option : " + option);
				//Switch statement
				switch (option)
				{
					case 1:

						Console.WriteLine("Player stays in the same position : " + position);
						break;

					case 2:
						if ((position + droll) > Win_position)
						{
							position = Win_position;
						}
						else
						{
							position += droll;
						}

						Console.WriteLine("Player moves ahead by : " + position);
						break;

					case 3:
						position -= droll;
						if ((position - droll) < Position_check)
						{
							position = Position_check;
						}

						Console.WriteLine("Player moves behind by : " + position);
						break;

					default:

						Console.WriteLine("Enter correct value");
						break;
				}
			}

			Console.WriteLine("Number Of Times The Dice Was Played To Win The Game Is : " + noOfDieRoll);
		}
    }
}
