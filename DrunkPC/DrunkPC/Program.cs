using System;
using System.Threading;
using System.Windows.Forms;

namespace DrunkPC
{
    class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            //Create all threads that manipulare all of the inputs and outputs to the system
            var drunkMouseThread = new Thread(DrunkMouseThread);
            var drunkKeyboardThread = new Thread(DrunkKeyboardThread);
            var drunkSoundThread = new Thread(DrunkSoundThread);
            var drunkPopupThread = new Thread(DrunkPopupThread);

            //Start all of the threads
            drunkMouseThread.Start();
            drunkKeyboardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThread.Start();

            //Wait For user input
            Console.ReadLine();

            //Kill the application
            drunkMouseThread.Abort();
            drunkKeyboardThread.Abort();
            drunkSoundThread.Abort();
            drunkPopupThread.Abort();
        }

        private static void DrunkMouseThread()
        {
            Console.WriteLine("DrunkMouseThread started");
            while (true)
            {
                //Console.WriteLine(Cursor.Position);

                var moveX = _random.Next(20) - 10;
                var moveY = _random.Next(20) - 10;

                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(_random.Next(100));
            }
        }

        private static void DrunkKeyboardThread()
        {
            Console.WriteLine("DrunkKeyboardThread started");


            while (true)
            {
                var key = (char) (_random.Next(25)+65);

                if (_random.Next(2) == 0)
                {
                    key = char.ToLower(key);
                }

                SendKeys.SendWait(key.ToString());
                Thread.Sleep(_random.Next(1000));
            }
        }

        private static void DrunkSoundThread()
        {
            Console.WriteLine("DrunkSoundThread started");
            while (true)
            {
                Thread.Sleep(500);
            }
        }

        private static void DrunkPopupThread()
        {
            Console.WriteLine("DrunkPopupThread started");
            while (true)
            {
                Thread.Sleep(500);
            }
        }

    }
}
