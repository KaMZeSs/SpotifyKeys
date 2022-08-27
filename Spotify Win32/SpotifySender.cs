using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyKeys.Spotify_Win32
{
    internal class SpotifySender
    {
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetActiveWindow();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

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
    }
}
