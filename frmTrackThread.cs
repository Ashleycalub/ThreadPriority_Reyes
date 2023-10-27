using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriority_Reyes
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }
        
        private void frmTrackThread_Load(object sender, EventArgs e)
        {
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" - Thread Strats -");

            Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.thread1));

            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.thread2));

            Thread ThreadC = new Thread(new ThreadStart(MyThreadClass.thread1));

            Thread ThreadD = new Thread(new ThreadStart(MyThreadClass.thread2));

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            lblThreadStart.Text = " - End of thread - ";
            Console.WriteLine(lblThreadStart.Text.ToString());
        }
    }
}

