using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyKeys.Hook
{
    public struct KbShortcut
    {
        private HashSet<Keys> keys;
        public HashSet<Keys> Keys { get { return keys; } }

        public KbShortcut()
        {
            this.keys = new();
        }

        public override string ToString()
        {
            if (keys.Count is 0)
                return null;
            StringBuilder sb = new();
            var list = keys.ToList();
            sb.Append(list.First().ToString());
            for (int i = 1; i < list.Count; i++)
            {
                sb.Append(" + " + list[i].ToString());
            }
            return sb.ToString();
        }

        public bool isEqual(KbShortcut obj)
        {
            if (this.Keys.Count != obj.Keys.Count)
            {
                return false;
            }
            foreach (var el in this.keys)
            {
                if (!obj.Keys.Contains(el))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
