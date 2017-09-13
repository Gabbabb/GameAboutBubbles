using System;

namespace Bubbles
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (BubblesGame game = new BubblesGame())
            {
                game.Run();
            }
        }
    }
#endif
}

