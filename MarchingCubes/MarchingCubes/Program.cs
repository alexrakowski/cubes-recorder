using System;

namespace MarchingCubes
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            MainForm form = new MainForm();
            form.Show();
            using (MainGame game = new MainGame(form))
            {
                game.Run();
            }
        }
    }
#endif
}

