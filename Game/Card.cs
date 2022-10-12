using System;

namespace Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        // <summary>
        /// Creates a card class.
        // </summary> 
    public class Card
    {

        public int faceValue;

        public string trueCard;

    // 2) Create the class constructor (function). Use the following method comment.

        // <summary>
        /// Calling the constructor and initializing most of the card values
        // </summary>
        public Card() 
        {
            // face = '11';

            Random rand = new Random();
            faceValue = rand.Next(1,14);

            trueCard = cardModify();

            // Console.WriteLine($"{faceValue}, {trueCard}");
        }

    // 3) Created a cardModify() method. Use the following method comment.
        
        // <summary>
        /// This changes the card values to represent that of an actual deck (minus the suite)
        // </summary>
        public string cardModify()
        {
            if (faceValue == 1)
            {
                trueCard = "A";
            }
            else if (faceValue == 11)
            {
                trueCard = "J";
            }
            else if (faceValue == 12)
            {
                trueCard = "Q";
            }
            else if (faceValue == 13)
            {
                trueCard = "K";
            }
            else
            {
                trueCard = Convert.ToString(faceValue);
            }
            return trueCard;


            // <summary>
            /// 
            // </summary>
            
            /* if (faceValue < 15)
            {
            }
            else 
            {
            } */
            
        }
    }
}