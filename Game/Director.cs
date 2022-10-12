using System;
using System.Collections.Generic;

namespace Game
{
    /// <summary>
    ///
    /// </summary>
    public class Director
    {
        // Access    // Data Type    // Name     =   // Value
        public Card _currentCard = new Card();
        public Card _nextCard = new Card();
        // No need for list?
        bool _isPlaying = true;
        int _score = 300;
        string guessCard = "";

        /// <summary>
        /// 
        /// </summary>
        public Director()
        {
            
        }

        /// <summary>
        /// The user initiates the game by running the program and game continues until all points are lost (or max points are reached)
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Draw card? [y/n] ");
            string drawCard = Console.ReadLine();
            _isPlaying = (drawCard == "y");

            if (_isPlaying)
            {
                Console.WriteLine($"Card Value: {_currentCard.trueCard}");

                Console.WriteLine("Is the next card higher or lower (H/L) than the previous card?");
                Console.Write("Please type (h/l): ");
                guessCard = Console.ReadLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }
            else
            {
                _nextCard = new Card();

                if ((_currentCard.faceValue <= _nextCard.faceValue) && (guessCard == "h") ||
                (_currentCard.faceValue >= _nextCard.faceValue) && (guessCard == "l"))
                {
                    _score += 100;
                    // Console.WriteLine("You made it to a correct statement!");
                }

                else
                {
                    _score -= 75;
                    // Console.WriteLine("You made it to an incorrect statement!");
                }

                _currentCard = _nextCard;
            }
            // _score = 300;
            
        }

        /// <summary>
        /// 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            else
            {
                Console.WriteLine($"\nNew Card Value: {_nextCard.trueCard}");

                if (_score == 1000)
                {
                    Console.WriteLine("CONGRATULATIONS!! You have won the game!");
                }
            }

            Console.WriteLine($"Your score is: {_score}\n");
            _isPlaying = (_score > 0) || (_score >= 1000);
        }
    }
}
