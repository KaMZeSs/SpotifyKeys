using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Input;
using Timer = System.Windows.Forms.Timer;

namespace SpotifyKeys
{
    public partial class Form1 : Form
    {
        Hook.globalKeyboardHook MainHook;
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

            MainHook = new();
            MainHook.KeyUp = this.MainHook_KeyUp;
            MainHook.KeyDown = this.MainHook_KeyDown;

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
            try
            {
                if (currShortcut.Keys.Add(key))
                {
                    foreach (var item in shortcuts)
                    {
                        if (item.Value.isEqual(currShortcut))
                        {
                            ExecuteCommand(item.Key);
                            return;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void ExecuteCommand(String command)
        {
            switch (command)
            {
                case "PauseStart":
                {
                    spotifySender.SendMessage(Spotify_Win32.AppComandCode.MEDIA_PLAY_PAUSE);                 
                    break;
                }
                case "NextTrack":
                {
                    spotifySender.SendMessage(Spotify_Win32.AppComandCode.MEDIA_NEXTTRACK);
                    break;
                }
                case "PreviousTrack":
                {
                    spotifySender.SendMessage(Spotify_Win32.AppComandCode.MEDIA_PREVIOUSTRACK);
                    break;
                }
                case "FastForwardTrack":
                {
                    spotifySender.SendMessage(Spotify_Win32.AppComandCode.MEDIA_FASTFORWARD);
                    break;
                }
                case "RewindTrack":
                {
                    spotifySender.SendMessage(Spotify_Win32.AppComandCode.MEDIA_REWIND);
                    break;
                }
            }
        }

        private void MainHook_KeyUp(Keys key)
        {
            if (currShortcut.Keys.Remove(key))
            {
            }
        }

        TextBox currSettingTextBox;
        String currSettingName;
        Button senderButton;

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
                    shortcuts.Remove(currSettingName);
                    shortcuts.Add(currSettingName, maxCurrSettingShortcut);
                    currSettingShortcut.Keys.Clear();
                    maxCurrSettingShortcut = new();
                    currSettingName = string.Empty;
                    senderButton.Enabled = true;

                    MainHook.HookedKeys = GetKeys(shortcuts).ToList();

                    MainHook.unhook();
                    MainHook.KeyUp -= SettingHook_KeyUp;
                    MainHook.KeyDown -= SettingHook_KeyDown;

                    MainHook.KeyUp += MainHook_KeyUp;
                    MainHook.KeyDown += MainHook_KeyDown;
                    MainHook.hook();
                }
            }
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            MainHook.unhook();
            MainHook.KeyUp -= MainHook_KeyUp;
            MainHook.KeyDown -= MainHook_KeyDown;
            MainHook.HookedKeys.Clear();

            MainHook.KeyUp += SettingHook_KeyUp;
            MainHook.KeyDown += SettingHook_KeyDown;
            MainHook.hook();

            senderButton = sender as Button;

            if (senderButton == PauseStart_button)
            {
                currSettingTextBox = this.PauseStart_textbox;
                currSettingName = "PauseStart";
            }
            else if (senderButton == NextTrack_button)
            {
                currSettingTextBox = this.NextTrack_textbox;
                currSettingName = "NextTrack";
            }
            else if (senderButton == PreviousTrack_button)
            {
                currSettingTextBox = this.PreviousTrack_textbox;
                currSettingName = "PreviousTrack";
            }
            else if (senderButton == FastForwardTrack_button)
            {
                currSettingTextBox = this.FastForwardTrack_textbox;
                currSettingName = "FastForwardTrack";
            }
            else if (senderButton == RewindTrack_button)
            {
                currSettingTextBox = this.RewindTrack_textbox;
                currSettingName = "RewindTrack";
            }

            senderButton.Enabled = false;
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "settings file (*.setprogr)|*.setprogr"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                using (var stream = new StreamWriter(dialog.FileName))
                {
                    foreach (var item in shortcuts)
                    {
                        stream.WriteLine($"{item.Key} // {item.Value}");
                    }
                }
            }
        }

        private void Load_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "settings file (*.setprogr)|*.setprogr"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new StreamReader(dialog.FileName))
                {
                    var lines = stream.ReadToEnd().Split(Environment.NewLine);
                    foreach (var line in lines)
                    {
                        var info = line.Split(" // ");
                        Keys key;
                        switch (info[0])
                        {
                            case "PauseStart":
                            {
                                if (Enum.TryParse(info[1], out key))//Надо сделать split(" + ") и по каждой кнопке
                                {
                                    
                                    this.PauseStart_textbox.Text = info[1];
                                }
                                break;
                            }
                            case "NextTrack":
                            {
                                this.NextTrack_textbox.Text = info[1];
                                break;
                            }
                            case "PreviousTrack":
                            {
                                this.PreviousTrack_textbox.Text = info[1];
                                break;
                            }
                            case "FastForwardTrack":
                            {
                                this.FastForwardTrack_textbox.Text = info[1];
                                break;
                            }
                            case "RewindTrack":
                            {
                                this.RewindTrack_textbox.Text = info[1];
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static HashSet<Keys> GetKeys(Dictionary<String, Hook.KbShortcut> vs)
        {
            HashSet<Keys> keys = new();

            foreach (var set in vs)
            {
                foreach (var key in set.Value.Keys)
                {
                    keys.Add(key);
                }
            }
            
            return keys;
        }
    }
}