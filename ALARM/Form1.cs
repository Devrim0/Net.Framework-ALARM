using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALARM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saat.Text == DateTime.Now.Hour.ToString() && dakika.Text == DateTime.Now.Minute.ToString() && saniye.Text == DateTime.Now.Second.ToString() ||
                saat.Text == DateTime.Now.Hour.ToString() && dakika.Text == (DateTime.Now.Minute + 1).ToString() && saniye.Text == DateTime.Now.Second.ToString() ||
                saat.Text == DateTime.Now.Hour.ToString() && dakika.Text == (DateTime.Now.Minute + 2).ToString() && saniye.Text == DateTime.Now.Second.ToString()
)
            {

                if (dakika.Text == comboBox2.Text && saat.Text == comboBox1.Text && saniye.Text == comboBox3.Text)
                {

                    axWindowsMediaPlayer1.URL = "C:\\Users\\Devrim\\Desktop\\alarm.mp3";

                    MessageBox.Show("UYANMA ZAMANI");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;


            for (int i = 0; i < 24; i++) {
                comboBox1.Items.Add(i);
            }
            for (int j = 0; j < 60; j++) {
                comboBox2.Items.Add(j);
            }
            for (int k = 0; k < 60; k++)
            {
                comboBox3.Items.Add(k);
            }
            { 
            }        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.Hour.ToString();
            dakika.Text = DateTime.Now.Minute.ToString();
            saniye.Text = DateTime.Now.Second.ToString();
            if (saat.Text == DateTime.Now.Hour.ToString() && dakika.Text == DateTime.Now.Minute.ToString() && saniye.Text == DateTime.Now.Second.ToString() || 
                saat.Text == DateTime.Now.Hour.ToString() && dakika.Text == (DateTime.Now.Minute+1).ToString() && saniye.Text == DateTime.Now.Second.ToString() ||
                saat.Text == DateTime.Now.Hour.ToString() && dakika.Text == (DateTime.Now.Minute + 2).ToString() && saniye.Text == DateTime.Now.Second.ToString()
)
            {

                if (dakika.Text == comboBox2.Text && saat.Text == comboBox1.Text && saniye.Text == comboBox3.Text)
                {

                    axWindowsMediaPlayer1.URL = "C:\\Users\\Devrim\\Desktop\\alarm.mp3";

                    MessageBox.Show("UYANMA ZAMANI");
                }
            }
        }
    }
}
