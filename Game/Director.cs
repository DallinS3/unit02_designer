using System;
using System.Collections.Generic;

namespace Game
{
    /// <summary>
    ///
    /// </summary>
    public class Director
    {
        List<Card> _card = new List<Card>();
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 0;

        /// <summary>
        /// 
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 14; i++)
            {
                Card face = new Card();

                if (i == 1)
                {
                    face = 'A';
                }
                else if (i == 11)
                {
                    face = 'J';
                }
                else if (i == 12)
                {
                    face = 'Q';
                }
                else if (i == 13)
                {
                    face = 'K';
                }
                else
                {
                    
                }

                _card.Add(face);
            }
        }

        /// <summary>
        /// 
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

            _score = 300;
            foreach (Card face in _card)
            {
                face.Draw();
                _score += face.faceValue;
            }
            _totalScore += _score;
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

            string values = "";
            foreach (Card face in _card)
            {
                values += $"{face.faceValue} ";
            }

            Console.WriteLine($"You rolled: {values}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_score > 0);
        }
    }
}


