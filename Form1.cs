using System.Windows.Forms;

namespace SpotifyKeys
{
    public partial class Form1 : Form
    {
        Hook.globalKeyboardHook hook;
        Hook.KeyProcesser.kbShortcut currShortcut;

        public Form1()
        {
            InitializeComponent();
            currShortcut = new();

            hook = new();

            hook.HookedKeys.Add(Keys.LControlKey);
            //hook.HookedKeys.Add(Keys.LShiftKey);
            //hook.HookedKeys.Add(Keys.LMenu);

            hook.HookedKeys.Add(Keys.A);
            hook.HookedKeys.Add(Keys.B);
            hook.HookedKeys.Add(Keys.C);

            hook.KeyDown += this.Hook_KeyDown;
            hook.KeyUp += this.Hook_KeyUp;
        }

        private void Hook_KeyDown(Keys key)
        {
            if (currShortcut.keys.Add(key))
            {
                var text = Hook.KeyProcesser.ShortcatViewer(currShortcut);
                if (text is not null)
                    richTextBox1.Text += text + Environment.NewLine;
            }
        }

        private void Hook_KeyUp(Keys key)
        {
            if (currShortcut.keys.Remove(key))
            {
                var text = Hook.KeyProcesser.ShortcatViewer(currShortcut);
                if (text is not null)
                    richTextBox1.Text += text + Environment.NewLine;
            }
        }
    }
}