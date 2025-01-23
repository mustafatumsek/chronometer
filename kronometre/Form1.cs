namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ms, sec, min, hr;       //saat deðiþkenleri
        int lapMs, lapSec, lapMin, lapHr;       //tur deðiþkenleri
        int lap = 1;        //tur sayacý

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBasla.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnLap.Enabled = true;
            lblClock.Text = (String.Format("{0:D2}", hr) + "." + String.Format("{0:D2}", min) + "." + String.Format("{0:D2}", sec) + "." + String.Format("{0:D2}", ms));
            ms++;
            if (ms == 60) { sec++; ms = 0; }
            if (sec == 60) { min++; sec = 0; }
            if (min == 60) { hr++; min = 0; }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStop.Enabled = false;
            btnBasla.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ms = 0; sec = 0; min = 0; hr = 0;
            lblClock.Text = (String.Format("{0:D2}", hr) + "." + String.Format("{0:D2}", min) + "." + String.Format("{0:D2}", sec) + "." + String.Format("{0:D2}", ms));
            lap = 1;
            listBox1.Items.Clear();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            if (lap == 1)
            {
                lapTimer.Start();
                listBox1.Items.Add("Lap " + lap + " - " + lblClock.Text);
            }
            else { listBox1.Items.Add("Lap " + lap + " - " + lblClock.Text + " - " + (String.Format("{0:D2}", lapHr) + "." + String.Format("{0:D2}", lapMin) + "." + String.Format("{0:D2}", lapSec) + "." + String.Format("{0:D2}", lapMs)));
            }
            lapMs = 0; lapSec = 0; lapMin = 0; lapHr = 0;
            lap++;
            btnLap.Enabled = false;
        }

        private void lapTimer_Tick(object sender, EventArgs e)
        {
            lapMs++;
            if (lapMs == 60) { lapSec++; lapMs = 0; }
            if (lapSec == 60) { lapMin++; lapSec = 0; }
            if (lapMin == 60) { lapHr++; lapMin = 0; }
        }
    }
}
