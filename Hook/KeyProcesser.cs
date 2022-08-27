using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic.Devices;

namespace SpotifyKeys.Hook
{
    internal class KeyProcesser
    {
        public struct kbShortcut
        {
            public HashSet<Keys> keys;

            public kbShortcut()
            {
                this.keys = new();
            }
        }

        public static string? ShortcatViewer(kbShortcut args)
        {
            if (args.keys.Count is 0)
                return null;
            StringBuilder sb = new();
            var list = args.keys.ToList();
            sb.Append(list.First().ToString());
            for (int i = 1; i < list.Count; i++)
            {
                sb.Append(" + " + list[i].ToString());
            }
            return sb.ToString();
        }
    }
}
