using System.Windows.Forms;

namespace SpotifyKeys
{
    public partial class Form1 : Form
    {
        Hook.globalKeyboardHook MainHook, SettingHook;
        Hook.KbShortcut currShortcut;
        Hook.KbShortcut currSettingShortcut, maxCurrSettingShortcut;

        Spotify_Win32.SpotifySender spotifySender;

        Dictionary<String, Hook.KbShortcut> shortcuts = new();

        public Form1()
        {
            InitializeComponent();
            
            currShortcut = new();
            currSettingShortcut = new();
            maxCurrSettingShortcut = new();

            MainHook = new() { IsAllKeys = true }; //Временно
            MainHook.KeyUp = this.MainHook_KeyUp;
            MainHook.KeyDown = this.MainHook_KeyDown;

            SettingHook = new() { IsAllKeys = true };
            SettingHook.KeyDown = this.SettingHook_KeyDown;
            SettingHook.KeyUp = this.SettingHook_KeyUp;

            spotifySender = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                spotifySender.FindSpotifyWindow();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void MainHook_KeyDown(Keys key)
        {
            if (currShortcut.Keys.Add(key))
            {
                foreach (var item in shortcuts)
                {
                    if (item.Value.isEqual(currShortcut))
                    {
                        ExecuteCommand(item.Key);
                    }
                }
            }
        }

        private void ExecuteCommand(String command)
        {
            switch (command)
            {
                case "PauseStart":
                {
                    spotifySender.SendMessage(Spotify_Win32.AppComandCode.MEDIA_PLAY_PAUSE);
                    break;
                }
            }
        }

        private void MainHook_KeyUp(Keys key)
        {
            if (currShortcut.Keys.Remove(key))
            {
                //var text = Hook.KeyProcesser.ShortcatViewer(currShortcut);
                //if (text is not null)
                //    richTextBox1.Text += text + Environment.NewLine;
            }
        }

        TextBox currSettingTextBox;

        private void SettingHook_KeyDown(Keys key)
        {
            if (currSettingShortcut.Keys.Add(key))
            {
                maxCurrSettingShortcut.Keys.Add(key);
                currSettingTextBox.Text = currSettingShortcut.ToString();
            }
        }

        private void SettingHook_KeyUp(Keys key)
        {
            if (currSettingShortcut.Keys.Remove(key))
            {
                if (currSettingShortcut.Keys.Count is 0)
                {
                    SettingHook.unhook();
                    currSettingTextBox.Text = String.Empty;
                    shortcuts.Add("PauseStart", maxCurrSettingShortcut);
                    currSettingShortcut.Keys.Clear();
                    maxCurrSettingShortcut = new();
                    MainHook.hook();
                }
            }
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            var senderButton = sender as Button;
            if (senderButton.Text is "Настроить")
            {
                currSettingTextBox = this.PauseStart_textbox;
            }
            MainHook.unhook();
            SettingHook.hook();
        }

        private void WorkState_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            item.Checked = !item.Checked;
            if (item.Checked)
            {
                SettingHook.unhook();
                MainHook.hook();
            }
        }
    }
}