using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Snake_mond
{
    public partial class Window1 : Window
    {
        public int PKT;
        public string move;

        public Window1()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            var dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Click;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 75);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Click(object sender, EventArgs e)
        {
            var postop = Canvas.GetTop(ellipse1);
            var posleft = Canvas.GetLeft(ellipse1);

            if (postop > 0 && postop <= 725 && posleft > 0 && posleft <= 975)
            {
                if (move == "Left")
                {
                    randomz();
                    var e1l = Canvas.GetLeft(ellipse1);
                    var e1t = Canvas.GetTop(ellipse1);
                    var e2l = Canvas.GetLeft(ellipse2);
                    var e2t = Canvas.GetTop(ellipse2);
                    var e3t = Canvas.GetTop(ellipse3);
                    var e3l = Canvas.GetLeft(ellipse3);
                    var e4t = Canvas.GetTop(ellipse4);
                    var e4l = Canvas.GetLeft(ellipse4);
                    var e5t = Canvas.GetTop(ellipse5);
                    var e5l = Canvas.GetLeft(ellipse5);
                    var e6t = Canvas.GetTop(ellipse6);
                    var e6l = Canvas.GetLeft(ellipse6);
                    var e7t = Canvas.GetTop(ellipse7);
                    var e7l = Canvas.GetLeft(ellipse7);

                    Canvas.SetLeft(ellipse1, e1l - 25);
                    Canvas.SetLeft(ellipse2, e1l);
                    Canvas.SetTop(ellipse2, e1t);
                    Canvas.SetLeft(ellipse3, e2l);
                    Canvas.SetTop(ellipse3, e2t);
                    Canvas.SetLeft(ellipse4, e3l);
                    Canvas.SetTop(ellipse4, e3t);
                    Canvas.SetLeft(ellipse5, e4l);
                    Canvas.SetTop(ellipse5, e4t);
                    Canvas.SetLeft(ellipse6, e5l);
                    Canvas.SetTop(ellipse6, e5t);
                    Canvas.SetLeft(ellipse7, e6l);
                    Canvas.SetTop(ellipse7, e6t);
                    Canvas.SetLeft(ellipse8, e7l);
                    Canvas.SetTop(ellipse8, e7t);
                }
                else if (move == "Right")
                {
                    randomz();
                    var e1l = Canvas.GetLeft(ellipse1);
                    var e1t = Canvas.GetTop(ellipse1);
                    var e2l = Canvas.GetLeft(ellipse2);
                    var e2t = Canvas.GetTop(ellipse2);
                    var e3t = Canvas.GetTop(ellipse3);
                    var e3l = Canvas.GetLeft(ellipse3);
                    var e4t = Canvas.GetTop(ellipse4);
                    var e4l = Canvas.GetLeft(ellipse4);
                    var e5t = Canvas.GetTop(ellipse5);
                    var e5l = Canvas.GetLeft(ellipse5);
                    var e6t = Canvas.GetTop(ellipse6);
                    var e6l = Canvas.GetLeft(ellipse6);
                    var e7t = Canvas.GetTop(ellipse7);
                    var e7l = Canvas.GetLeft(ellipse7);

                    Canvas.SetLeft(ellipse1, e1l + 25);
                    Canvas.SetLeft(ellipse2, e1l);
                    Canvas.SetTop(ellipse2, e1t);
                    Canvas.SetLeft(ellipse3, e2l);
                    Canvas.SetTop(ellipse3, e2t);
                    Canvas.SetLeft(ellipse4, e3l);
                    Canvas.SetTop(ellipse4, e3t);
                    Canvas.SetLeft(ellipse5, e4l);
                    Canvas.SetTop(ellipse5, e4t);
                    Canvas.SetLeft(ellipse6, e5l);
                    Canvas.SetTop(ellipse6, e5t);
                    Canvas.SetLeft(ellipse7, e6l);
                    Canvas.SetTop(ellipse7, e6t);
                    Canvas.SetLeft(ellipse8, e7l);
                    Canvas.SetTop(ellipse8, e7t);
                }

                else if (move == "Up")
                {
                    randomz();
                    var e1l = Canvas.GetLeft(ellipse1);
                    var e1t = Canvas.GetTop(ellipse1);
                    var e2l = Canvas.GetLeft(ellipse2);
                    var e2t = Canvas.GetTop(ellipse2);
                    var e3t = Canvas.GetTop(ellipse3);
                    var e3l = Canvas.GetLeft(ellipse3);
                    var e4t = Canvas.GetTop(ellipse4);
                    var e4l = Canvas.GetLeft(ellipse4);
                    var e5t = Canvas.GetTop(ellipse5);
                    var e5l = Canvas.GetLeft(ellipse5);
                    var e6t = Canvas.GetTop(ellipse6);
                    var e6l = Canvas.GetLeft(ellipse6);
                    var e7t = Canvas.GetTop(ellipse7);
                    var e7l = Canvas.GetLeft(ellipse7);

                    Canvas.SetTop(ellipse1, e1t - 25);
                    Canvas.SetLeft(ellipse2, e1l);
                    Canvas.SetTop(ellipse2, e1t);
                    Canvas.SetLeft(ellipse3, e2l);
                    Canvas.SetTop(ellipse3, e2t);
                    Canvas.SetLeft(ellipse4, e3l);
                    Canvas.SetTop(ellipse4, e3t);
                    Canvas.SetLeft(ellipse5, e4l);
                    Canvas.SetTop(ellipse5, e4t);
                    Canvas.SetLeft(ellipse6, e5l);
                    Canvas.SetTop(ellipse6, e5t);
                    Canvas.SetLeft(ellipse7, e6l);
                    Canvas.SetTop(ellipse7, e6t);
                    Canvas.SetLeft(ellipse8, e7l);
                    Canvas.SetTop(ellipse8, e7t);
                }

                else if (move == "Down")
                {
                    randomz();
                    var e1l = Canvas.GetLeft(ellipse1);
                    var e1t = Canvas.GetTop(ellipse1);
                    var e2l = Canvas.GetLeft(ellipse2);
                    var e2t = Canvas.GetTop(ellipse2);
                    var e3t = Canvas.GetTop(ellipse3);
                    var e3l = Canvas.GetLeft(ellipse3);
                    var e4t = Canvas.GetTop(ellipse4);
                    var e4l = Canvas.GetLeft(ellipse4);
                    var e5t = Canvas.GetTop(ellipse5);
                    var e5l = Canvas.GetLeft(ellipse5);
                    var e6t = Canvas.GetTop(ellipse6);
                    var e6l = Canvas.GetLeft(ellipse6);
                    var e7t = Canvas.GetTop(ellipse7);
                    var e7l = Canvas.GetLeft(ellipse7);

                    Canvas.SetTop(ellipse1, e1t + 25);
                    Canvas.SetLeft(ellipse2, e1l);
                    Canvas.SetTop(ellipse2, e1t);
                    Canvas.SetLeft(ellipse3, e2l);
                    Canvas.SetTop(ellipse3, e2t);
                    Canvas.SetLeft(ellipse4, e3l);
                    Canvas.SetTop(ellipse4, e3t);
                    Canvas.SetLeft(ellipse5, e4l);
                    Canvas.SetTop(ellipse5, e4t);
                    Canvas.SetLeft(ellipse6, e5l);
                    Canvas.SetTop(ellipse6, e5t);
                    Canvas.SetLeft(ellipse7, e6l);
                    Canvas.SetTop(ellipse7, e6t);
                    Canvas.SetLeft(ellipse8, e7l);
                    Canvas.SetTop(ellipse8, e7t);
                }
            }
            else
            {
                Canvas.SetTop(ellipse1, 370);
                Canvas.SetLeft(ellipse1, 600);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left) move = "Left";

            if (e.Key == Key.Right) move = "Right";

            if (e.Key == Key.Up) move = "Up";

            if (e.Key == Key.Down) move = "Down";
        }

        public void randomz()
        {
            var postop = Canvas.GetTop(ellipse1);
            var posleft = Canvas.GetLeft(ellipse1);
            var eggtop = Canvas.GetTop(ellipse9);
            var eggleft = Canvas.GetLeft(ellipse9);
            if (postop + 25 >= eggtop && postop <= eggtop + 25 && posleft + 25 >= eggleft && posleft <= eggleft + 25)
            {
                ellipse9.Visibility = Visibility.Hidden;
                PKT = PKT + 10;
                label1.Content = "PKT = " + PKT;
                var rd = new Random();
                var x = rd.Next(650);
                var y = rd.Next(900);
                Canvas.SetTop(ellipse9, x);
                Canvas.SetLeft(ellipse9, y);
                ellipse9.Visibility = Visibility.Visible;
            }
        }
    }
}