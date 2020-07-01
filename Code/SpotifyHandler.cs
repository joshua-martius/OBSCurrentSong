using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSCurrentSong
{
    public sealed class SpotifyHandler
    {
        private Process _process = null;
        private OutputStyles _outputStyle = 0;
        private string _previousSong = string.Empty;
        private string _currentSong = string.Empty;

        public enum OutputStyles
        {
            FULL = 0,
            ARTIST_ONLY = 1,
            SONG_ONLY = 2
        }

        public OutputStyles OutputStyle { get => _outputStyle; set => _outputStyle = value; }

        public bool IsRunning { get => (_process != null && !_process.HasExited); }

        public bool IsPlaying { get => !_process.MainWindowTitle.Contains("Spotify") && !_process.MainWindowTitle.Equals(""); }

        public override string ToString()
        {
            this.RefreshProcess();
            if (!this.IsRunning || !this.IsPlaying) return "No song playing right now";
            switch(_outputStyle)
            {
                case OutputStyles.FULL:
                    return _process.MainWindowTitle;
                case OutputStyles.ARTIST_ONLY:
                    return _process.MainWindowTitle.Substring(0, _process.MainWindowTitle.IndexOf("-") - 1);
                case OutputStyles.SONG_ONLY:
                    return _process.MainWindowTitle.Substring(_process.MainWindowTitle.IndexOf("-") + 1);
                default:
                    return string.Empty;
            }
        }

        public SpotifyHandler()
        {
            this.RefreshProcess();
        }

        public SpotifyHandler(OutputStyles outputStyle) : this()
        {
            _outputStyle = outputStyle;
        }

        private void RefreshProcess() => _process = Process.GetProcesses().ToList().Find(p => p.ProcessName.Equals("Spotify") && !p.MainWindowTitle.Equals(""));
    }
}
