using System;


namespace Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        // <summary>
        /// 
        // </summary> 
    public class Card
    {
        public string face;
        public int faceValue;

    // 2) Create the class constructor (function). Use the following method comment.

        // <summary>
        /// 
        // </summary>
        public Cards() 
        {
            face = '11';
            faceValue = 0;
        }

    // 3) Create the Roll() method. Use the following method comment.
        
        // <summary>
        /// 
        // </summary>
        public void Draw()
        {
            Random rand = new Random();
            faceValue = rand.Next(1,14);

            /*
            if (dieValue == 1)
            else if (dieValue == 5)
            else
            */
            // <summary>
            /// 
            // </summary>
            
            if (faceValue < 15)
            {
            }
            else 
            {
            }
            
        }
    }
}