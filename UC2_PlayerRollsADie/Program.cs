using System;

namespace UC2_SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Player is at position: "+position);
            Random random = new Random();
            int droll = 0;
            while (true)
            {
                droll = random.Next(7);
                if (droll != 0) break;

            }
            Console.WriteLine(droll);
        }
    }
}
