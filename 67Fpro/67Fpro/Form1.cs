using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using OpenCvSharp;

namespace _67Fpro
{
    public partial class Form1 : Form
    {
        Thread thAutoThread;

        public Form1()
        {
            InitializeComponent();
            thAutoThread = new Thread(new ThreadStart(MainThread));
            thAutoThread.Start();
        }

        void MainThread()
        {
            while(true)
            {

                Thread.Sleep(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mat source = new Mat(@"1.bmp", ImreadModes.Color);
            Cv2.ImShow("Demo", source);
            Cv2.WaitKey(0);
        }
    }
}