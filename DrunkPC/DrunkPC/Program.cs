using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace System.Wlndows
{
    class Program
    {
        public static Random _random = new Random();

        public static int _startupDelaySeconds = 10;
        public static int _totalDurationSeconds = 10;
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                _startupDelaySeconds = Convert.ToInt32(args[0]);
                _totalDurationSeconds = Convert.ToInt32(args[1]);
            }
            //Create all threads that manipulare all of the inputs and outputs to the system
            var drunkMouseThread = new Thread(DrunkMouseThread);
            var drunkKeyboardThread = new Thread(DrunkKeyboardThread);
            var drunkSoundThread = new Thread(DrunkSoundThread);
            var drunkPopupThread = new Thread(DrunkPopupThread);

            DateTime future = DateTime.Now.AddSeconds(_startupDelaySeconds);
            Console.WriteLine("Waiting 10 seconds before starting threads");
            while (future > DateTime.Now)
            {
                Thread.Sleep(1000);
            }

            //Start all of the threads
            drunkMouseThread.Start();
            drunkKeyboardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThread.Start();

            future = DateTime.Now.AddSeconds(_totalDurationSeconds);
            while (future > DateTime.Now)
            {
                Thread.Sleep(1000);
            }


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
                if (_random.Next(100) > 80)
                {
                    var key = (char)(_random.Next(25) + 65);

                    if (_random.Next(2) == 0)
                    {
                        key = char.ToLower(key);
                    }

                    SendKeys.SendWait(key.ToString());
                }
                Thread.Sleep(_random.Next(1000));
            }
        }

        private static void DrunkSoundThread()
        {
            Console.WriteLine("DrunkSoundThread started");
            while (true)
            {
                if (_random.Next(100) > 80)
                {
                    switch (_random.Next(5))
                    {
                        case 0:
                            SystemSounds.Beep.Play();
                            break;
                        case 1:
                            SystemSounds.Asterisk.Play();
                            break;
                        case 2:
                            SystemSounds.Exclamation.Play();
                            break;
                        case 3:
                            SystemSounds.Hand.Play();
                            break;
                        case 4:
                            SystemSounds.Question.Play();
                            break;
                    }
                }
                Thread.Sleep(500);
            }
        }

        private static void DrunkPopupThread()
        {
            Console.WriteLine("DrunkPopupThread started");
            while (true)
            {
                if (_random.Next(100) > 30)
                {
                    switch (_random.Next(2))
                    {
                        case 0:
                            MessageBox.Show("Internet explorer has stopped working", "Internet Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            MessageBox.Show("Your system is running low on resources", "Microsoft Windows", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }


                }
                Thread.Sleep(10000);
            }
        }

    }
}
