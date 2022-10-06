/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
using Game;
using System;
using System.Collections.Generic;

namespace Unit02
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}
