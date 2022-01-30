using System;
using System.Collections.Generic;


namespace Team.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Card card = new Card();
        bool isPlaying = true;
        int totalScore = 300;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying && totalScore > 0)
            {
                GetInputs();
                DrawCards();
                DoOutputs();
            }

            // Game over message.
            if (!isPlaying)
            {
                Console.WriteLine($"You have ended the game with {totalScore} points. ");
                Console.WriteLine("Thanks for playing!");
            }
            else if (totalScore <= 0){
                Console.WriteLine("You have run out of points! \n YOU LOSE!");
            }
        }

        /// <summary>
        /// Asks the user if they want to draw a card.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Draw a card? [y/n] ");
            string drawCard = Console.ReadLine();
            isPlaying = (drawCard == "y");
        }

        /// <summary>
        /// Updates the two cards drawn.
        /// </summary>
        public void DrawCards()
        {
            if (!isPlaying)
            {
                return;
            }

            card.GetCard1();
            card.GetCard2();
        }

        /// <summary>
        /// Displays the cards, tracks the user's guess, and updates score.
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            card.DisplayCard1();
            Console.Write("Higher or lower? (h/l) ");
            string playerGuess = Console.ReadLine();
            card.DisplayCard2();

            bool guessLower = (playerGuess == "h");

            if (guessLower == card.isHigher())
            {
                totalScore += 100;
            }
            else
            {
                totalScore -= 75;
            }

            Console.WriteLine($"Your score is: {totalScore}\n");
        }
    }
}