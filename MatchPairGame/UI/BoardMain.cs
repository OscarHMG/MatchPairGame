using CardMatch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMatch.UI
{
    public partial class BoardMain : Form
    {
        Timer timer;
        Stopwatch sw;

        public BoardMain()
        {
            InitializeComponent();
            startTimer();
            Card myText = new Card(1,1,null);
            myText.Location = new Point(10, 10);
            this.Controls.Add(myText);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void startTimer()
        {
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer_Tick);
            sw = new Stopwatch();
            timer.Start();
            sw.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string hour = formatString(sw.Elapsed.Hours);
            string minute = formatString(sw.Elapsed.Minutes);
            string seconds = formatString(sw.Elapsed.Seconds);
            labelTimer.Text = hour +":"+minute+":"+seconds;
            labelTimer.Refresh();
        }

        public string formatString(int value)
        {
            if (value <= 9)
            {
                return "0"+value;
            }
            else
            {
                return ""+value;
            }
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoJuegoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            BoardMain b = new BoardMain();
            b.containerLayout.Visible = true;
            b.labelTimer.Visible = true;
            b.Show();
            
        }

        private void BoardMain_Load(object sender, EventArgs e)
        {

        }
    }
}
