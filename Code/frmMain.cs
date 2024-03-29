﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace OBSCurrentSong
{
    public partial class frmMain : Form
    {
        private SpotifyHandler _spotify = null;
        private Timer _timer = null;
        private readonly string outputFilePath = string.Format("{0}/{1}", Application.StartupPath, "currentsong.txt");

        public frmMain()
        {
            InitializeComponent();
            lblVersion.Text = string.Format("V{0} by Yoshi", Application.ProductVersion.ToString());
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += this._timer_Tick;
            _timer.Start();

            _spotify = new SpotifyHandler();
            this.RefreshLabel();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if(File.Exists(outputFilePath))
            {
                string lastSong = File.ReadAllText(outputFilePath);
                if (lastSong.Equals(_spotify.ToString())) return;
            }
            this.RefreshLabel();
            if (_spotify.IsPlaying) File.WriteAllText(outputFilePath, _spotify.ToString());
            else if (_spotify.IsRunning && (File.Exists(outputFilePath) && File.ReadAllText(outputFilePath).Length != 0)) File.WriteAllText(outputFilePath, "");
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked) _spotify.OutputStyle = SpotifyHandler.OutputStyles.FULL;
            else if (radArtist.Checked) _spotify.OutputStyle = SpotifyHandler.OutputStyles.ARTIST_ONLY;
            else if (radSong.Checked) _spotify.OutputStyle = SpotifyHandler.OutputStyles.SONG_ONLY;
            else throw new Exception("No radio button checked (somehow)");
            this.RefreshLabel();
        }

        private void RefreshLabel() => lblCurrentSong.Text = "Current output: " + _spotify.ToString();

        private void numIntervall_ValueChanged(object sender, EventArgs e)
        {
            _timer.Interval = Convert.ToInt32(numIntervall.Value * 1000);
        }

        private void lblVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/y0sh1DE/OBSCurrentSong");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
        }
    }
}
