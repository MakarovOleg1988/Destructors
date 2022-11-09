using System;

namespace Lesson33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Browm", "Jim Gordon", "Maksim Bren" };

            int winner = Convert.ToInt32(Console.ReadLine());

            FinalRound _finalRound = new FinalRound(finalists, winner);

            GameOver _gameOver = new GameOver();
        }
    }

    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            string personWinner = finalists[winner];
            Console.WriteLine("Winner is" + " " + personWinner);
        }
    }

    class GameOver
    {
        public GameOver()
        {
            Console.WriteLine("Game Over");
        }
        ~GameOver() { }
    }
}



