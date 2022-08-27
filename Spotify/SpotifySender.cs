using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyKeys.Spotify
{
    internal class SpotifySender
    {
    }
}

//Енто работает

//public enum AppComandCode : uint
//{
//    BASS_BOOST = 20,
//    BASS_DOWN = 19,
//    BASS_UP = 21,
//    BROWSER_BACKWARD = 1,
//    BROWSER_FAVORITES = 6,
//    BROWSER_FORWARD = 2,
//    BROWSER_HOME = 7,
//    BROWSER_REFRESH = 3,
//    BROWSER_SEARCH = 5,
//    BROWSER_STOP = 4,
//    LAUNCH_APP1 = 17,
//    LAUNCH_APP2 = 18,
//    LAUNCH_MAIL = 15,
//    LAUNCH_MEDIA_SELECT = 16,
//    MEDIA_NEXTTRACK = 11,
//    MEDIA_PLAY_PAUSE = 14,
//    MEDIA_PREVIOUSTRACK = 12,
//    MEDIA_STOP = 13,
//    TREBLE_DOWN = 22,
//    TREBLE_UP = 23,
//    VOLUME_DOWN = 9,
//    VOLUME_MUTE = 8,
//    VOLUME_UP = 10,
//    MICROPHONE_VOLUME_MUTE = 24,
//    MICROPHONE_VOLUME_DOWN = 25,
//    MICROPHONE_VOLUME_UP = 26,
//    CLOSE = 31,
//    COPY = 36,
//    CORRECTION_LIST = 45,
//    CUT = 37,
//    DICTATE_OR_COMMAND_CONTROL_TOGGLE = 43,
//    FIND = 28,
//    FORWARD_MAIL = 40,
//    HELP = 27,
//    MEDIA_CHANNEL_DOWN = 52,
//    MEDIA_CHANNEL_UP = 51,
//    MEDIA_FASTFORWARD = 49,
//    MEDIA_PAUSE = 47,
//    MEDIA_PLAY = 46,
//    MEDIA_RECORD = 48,
//    MEDIA_REWIND = 50,
//    MIC_ON_OFF_TOGGLE = 44,
//    NEW = 29,
//    OPEN = 30,
//    PASTE = 38,
//    PRINT = 33,
//    REDO = 35,
//    REPLY_TO_MAIL = 39,
//    SAVE = 32,
//    SEND_MAIL = 41,
//    SPELL_CHECK = 42,
//    UNDO = 34,
//    DELETE = 53,
//    DWM_FLIP3D = 54
//}

//class Program
//{
//    [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
//    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

//    [DllImport("USER32.DLL")]
//    public static extern bool SetForegroundWindow(IntPtr hWnd);

//    [DllImport("USER32.DLL")]
//    public static extern IntPtr GetActiveWindow();

//    [DllImport("User32.dll")]
//    public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

//    [DllImport("user32.dll")]
//    static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

//    [DllImport("user32.dll")]
//    static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
//    static int WM_APPCOMMAND = 0x0319;

//    IntPtr spotifyWindow;

//    public static void Main()
//    {
//        var ptr = FindWindow(null, "Spotify Free");
//        SendMessageW(ptr, WM_APPCOMMAND, ptr, (IntPtr)((int)AppComandCode.MEDIA_PREVIOUSTRACK << 16));

//        Console.WriteLine(ptr);
//    }
//}
