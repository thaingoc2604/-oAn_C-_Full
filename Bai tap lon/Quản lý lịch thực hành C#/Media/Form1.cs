using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Media
{
    public partial class Form1 : Form
    {
        private bool fileopenning = false;
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        public Form1()
        {
            InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackWave.Value = CalcVol / (ushort.MaxValue / 10);
        }

        [DllImport("winmm.dll")]
        public static extern long mciSendString(string stay, StringBuilder strbuilder, int width, IntPtr sign);
        private StringBuilder sbf = new StringBuilder();
        public string Status()
        {
            mciSendString("status mediafile mode", sbf, sbf.Capacity, IntPtr.Zero);
            return sbf.ToString();
        }
        string staying;
        private void button_openfile_Click(object sender, EventArgs e)
        {
            if (Status() == "playing")
            {
                staying = "close mediafile";
                mciSendString(staying, null, 0, IntPtr.Zero);
                openFileDialog1.Title = "Chon Files nhac (*.mpg,*.avi,*.dat)";
                openFileDialog1.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
                openFileDialog1.ShowDialog();
                fileopenning = true;
            }
            else
            {
                staying = "close mediafile";
                mciSendString(staying, null, 0, IntPtr.Zero);
                openFileDialog1.Title = "Chon Files nhac (*.mpg,*.avi,*.dat)";
                openFileDialog1.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3,*.mkv)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv;*.mkv";
                openFileDialog1.ShowDialog();
                fileopenning = true;
            }     
        }

        private void button_palyfile_Click(object sender, EventArgs e)
        {
            staying = "open \"" + this.openFileDialog1.FileName + "\" type mpegvideo alias mediafile style child parent " + this.pictureBox1.Handle.ToInt32();
            mciSendString(staying, null, 0, IntPtr.Zero);
            staying = "put mediafile window at 0 0 " + this.pictureBox1.Width + " " + this.pictureBox1.Height;
            if (fileopenning)
            {
                this.Text = openFileDialog1.FileName;
                staying = "play mediafile";
                mciSendString(staying, null, 0, IntPtr.Zero);

            }
            else
            {
                MessageBox.Show("Please chose file!");
            }
        }

        private void button_stopfile_Click(object sender, EventArgs e)
        {
            this.Text = openFileDialog1.FileName;
            staying = "close mediafile";
            mciSendString(staying, null, 0, IntPtr.Zero);
        }

        private void trackWave_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * trackWave.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}