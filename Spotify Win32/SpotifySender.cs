using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyKeys.Spotify_Win32
{
    internal class SpotifySender
    {
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        static int WM_APPCOMMAND = 0x0319;

        IntPtr spotifyWindow;
        public IntPtr SpotifyWindow { get { return spotifyWindow; } }

        public void FindSpotifyWindow()
        {
            var ptr = FindWindow(null, "Spotify Free");
            if (ptr == IntPtr.Zero)
            {
                ptr = FindWindow(null, "Spotify");
                if (ptr == IntPtr.Zero)
                {
                    throw new Exception("Cannot find Spotify Window");
                }
            }
            spotifyWindow = ptr;
        }

        public void FindSpecifiedSpotifyWindow(String windowName)
        {
            var ptr = FindWindow(null, windowName);
            if (ptr == IntPtr.Zero)
            {
                throw new Exception($"Cannot find Spotify window, named \'{windowName}\'");
            }
            spotifyWindow = ptr;
        }

        public void SendMessage(AppComandCode code)
        {
            SendMessageW(spotifyWindow, WM_APPCOMMAND, 
                spotifyWindow, (IntPtr)((int)code << 16));
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr handle, out uint processId);
        public String FindSpotifyExecutable()
        {
            if (spotifyWindow == IntPtr.Zero)
            {
                throw new Exception("Cannot find Spotify Window");
            }
            
            uint pid;
            GetWindowThreadProcessId(spotifyWindow, out pid);

            Process proc = Process.GetProcessById((int)pid); //Gets the process by ID.
            return proc.MainModule.FileName.ToString();    //Returns the path.
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowTextLength(HandleRef hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(HandleRef hWnd, StringBuilder lpString, int nMaxCount);

        public String GetSpotifyWindowName()
        {
            if (spotifyWindow == IntPtr.Zero)
            {
                throw new Exception("Cannot find Spotify Window");
            }

            var capacity = GetWindowTextLength(new(this, spotifyWindow)) * 2;
            var sb = new StringBuilder(capacity);

            GetWindowText(new(this, spotifyWindow), sb, sb.Capacity);

            return sb.ToString();
        }

        public void CloseSpotifyWindow()
        {
            uint pid;
            GetWindowThreadProcessId(spotifyWindow, out pid);

            var proc = Process.GetProcessById((int)pid); //Gets the process by ID.

            proc.Kill(true);

            spotifyWindow = IntPtr.Zero;
        }
    }
}

