using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Hardcodet.Wpf.TaskbarNotification;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Threading;
using System.Windows.Threading;
using System.Diagnostics;
using System.Windows.Automation;
using System.IO;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
/*shatlin*/

namespace Samples.Tutorials.Balloons
{

    public partial class BalloonSampleWindow : System.Windows.Window
    {
       

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);


        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
       
        

        

        public BalloonSampleWindow()
        {
            InitializeComponent();
            //   Timer.Tick += new EventHandler(Timer_Tick);
            //   Timer.Interval = new TimeSpan(0, 0, 1);

        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            //clean up notifyicon (would otherwise stay open until application finishes)
            MyNotifyIcon.Dispose();
            base.OnClosing(e);
        }

    
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Drawing.Point point = System.Windows.Forms.Control.MousePosition;
            TB1.Text= point.X.ToString();
            TB2.Text= point.Y.ToString();
        }

      

    }
}