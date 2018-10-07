using System;

namespace probability
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerone;
            int playertwo;
            int solution = 47;
            Console.WriteLine("Player One: ");
            playerone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Player Two: ");
            playertwo = Convert.ToInt32(Console.ReadLine());
            if (playerone == solution)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (playertwo == solution)
            {
                Console.WriteLine("Player Two Wins!");
            }
            else if (playerone < 60 && playertwo > 60)
            {
                Console.WriteLine("Player Two Wins!");
            }
            else if (playertwo < 60 && playerone > 60)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (playerone > 60 && playertwo > 60)
            {
                if (playerone > playertwo && playerone <= solution)
                {
                    Console.WriteLine("Player One Wins!");
                }
                else if (playertwo > playerone && playertwo <= solution)
                {
                    Console.WriteLine("Player Two Wins!");
                }
                else
                {
                    Console.WriteLine("An Error Ocurred......");
                }
            }
            else if (playerone == solution && playertwo == solution)
            {
                Console.WriteLine("Tie!");
            }
            else if (playertwo == playerone)
            {
                Console.WriteLine("Tie!");
            }
            else if (playerone < 60 && playertwo < 60)
            {
                if (playerone < 60 && playertwo >= solution)
                {
                    Console.WriteLine("Player Two Wins!");
                }
                else if (playertwo < 60 && playerone >= solution)
                {
                    Console.WriteLine("Player One Wins!");
                }
                else
                {
                    Console.WriteLine("An Error Ocurred......");
                }
            }
            else
            {
                Console.WriteLine("An Error Ocurred......");
            }
        }
    }
}
