﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;

namespace Snake_mond
{
    public partial class Window1 : Window
    {
        public int PKT = 0;
        public string move;
        public Window1()
        {          
            InitializeComponent();          
            this.WindowState = WindowState.Maximized;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Click);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 75);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Click(object sender, EventArgs e)
        {
            double postop = Canvas.GetTop(ellipse1);
            double posleft = Canvas.GetLeft(ellipse1);                     

            if (postop > 0 && postop <= 725 && posleft>0 && posleft<=975)
            {            
                if (move == "Left")
                {
                    randomz();
                    double e1l = Canvas.GetLeft(ellipse1);//get
                    double e1t = Canvas.GetTop(ellipse1);
                    double e2l = Canvas.GetLeft(ellipse2);
                    double e2t = Canvas.GetTop(ellipse2);
                    double e3t = Canvas.GetTop(ellipse3);
                    double e3l = Canvas.GetLeft(ellipse3);
                    double e4t = Canvas.GetTop(ellipse4);
                    double e4l = Canvas.GetLeft(ellipse4);
                    double e5t = Canvas.GetTop(ellipse5);
                    double e5l = Canvas.GetLeft(ellipse5);
                    double e6t = Canvas.GetTop(ellipse6);
                    double e6l = Canvas.GetLeft(ellipse6);
                    double e7t = Canvas.GetTop(ellipse7);
                    double e7l = Canvas.GetLeft(ellipse7);
                    
                    Canvas.SetLeft(ellipse1,  e1l-25);//set                    
                    Canvas.SetLeft(ellipse2, e1l);
                    Canvas.SetTop(ellipse2,e1t);                    
                    Canvas.SetLeft(ellipse3,e2l);
                    Canvas.SetTop(ellipse3,e2t);
                    Canvas.SetLeft(ellipse4,e3l);
                    Canvas.SetTop(ellipse4,e3t);
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
                    double e1l = Canvas.GetLeft(ellipse1);//get
                    double e1t = Canvas.GetTop(ellipse1);
                    double e2l = Canvas.GetLeft(ellipse2);
                    double e2t = Canvas.GetTop(ellipse2);
                    double e3t = Canvas.GetTop(ellipse3);
                    double e3l = Canvas.GetLeft(ellipse3);
                    double e4t = Canvas.GetTop(ellipse4);
                    double e4l = Canvas.GetLeft(ellipse4);
                    double e5t = Canvas.GetTop(ellipse5);
                    double e5l = Canvas.GetLeft(ellipse5);
                    double e6t = Canvas.GetTop(ellipse6);
                    double e6l = Canvas.GetLeft(ellipse6);
                    double e7t = Canvas.GetTop(ellipse7);
                    double e7l = Canvas.GetLeft(ellipse7);

                    Canvas.SetLeft(ellipse1,e1l + 25);//set
                    Canvas.SetLeft(ellipse2,e1l);
                    Canvas.SetTop(ellipse2,e1t);
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

                else if(move == "Up")
                {
                    randomz();
                    double e1l = Canvas.GetLeft(ellipse1);//get
                    double e1t = Canvas.GetTop(ellipse1);
                    double e2l = Canvas.GetLeft(ellipse2);
                    double e2t = Canvas.GetTop(ellipse2);
                    double e3t = Canvas.GetTop(ellipse3);
                    double e3l = Canvas.GetLeft(ellipse3);
                    double e4t = Canvas.GetTop(ellipse4);
                    double e4l = Canvas.GetLeft(ellipse4);
                    double e5t = Canvas.GetTop(ellipse5);
                    double e5l = Canvas.GetLeft(ellipse5);
                    double e6t = Canvas.GetTop(ellipse6);
                    double e6l = Canvas.GetLeft(ellipse6);
                    double e7t = Canvas.GetTop(ellipse7);
                    double e7l = Canvas.GetLeft(ellipse7);

                    Canvas.SetTop(ellipse1, e1t - 25);//set
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

                else if(move == "Down")
                {
                    randomz();
                    double e1l = Canvas.GetLeft(ellipse1);//get
                    double e1t = Canvas.GetTop(ellipse1);
                    double e2l = Canvas.GetLeft(ellipse2);
                    double e2t = Canvas.GetTop(ellipse2);
                    double e3t = Canvas.GetTop(ellipse3);
                    double e3l = Canvas.GetLeft(ellipse3);
                    double e4t = Canvas.GetTop(ellipse4);
                    double e4l = Canvas.GetLeft(ellipse4);
                    double e5t = Canvas.GetTop(ellipse5);
                    double e5l = Canvas.GetLeft(ellipse5);
                    double e6t = Canvas.GetTop(ellipse6);
                    double e6l = Canvas.GetLeft(ellipse6);
                    double e7t = Canvas.GetTop(ellipse7);
                    double e7l = Canvas.GetLeft(ellipse7);

                    Canvas.SetTop(ellipse1, e1t + 25);//set
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
                Canvas.SetTop(ellipse1,370);
                Canvas.SetLeft(ellipse1,600);               
                
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {                
                move = "Left";                
            }

            if (e.Key == Key.Right)
            {
                move = "Right";               
            }
            
            if (e.Key == Key.Up)
            {
                move = "Up";               
            }

            if (e.Key == Key.Down)
            {
                move = "Down";               
            }
        }

        public void randomz()
        {
            double postop = Canvas.GetTop(ellipse1);
            double posleft = Canvas.GetLeft(ellipse1);
            double eggtop = Canvas.GetTop(ellipse9);
            double eggleft = Canvas.GetLeft(ellipse9);
            if ((postop + 25) >= eggtop && postop <= (eggtop + 25) && (posleft + 25) >= eggleft && posleft <= (eggleft + 25))
            {
                ellipse9.Visibility = Visibility.Hidden;
                PKT = PKT + 10;
                label1.Content = "PKT = " + PKT;
                Random rd = new Random();
                int x = rd.Next(650);
                int y = rd.Next(900);
                Canvas.SetTop(ellipse9, x);
                Canvas.SetLeft(ellipse9, y);
                ellipse9.Visibility = Visibility.Visible;
            }
        }





       
    }
}