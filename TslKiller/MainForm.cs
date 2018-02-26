using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace TslKiller
{
    public partial class MainForm : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 1;

        //windows hotkey id
        private const int WM_HOTKEY = 0x0312;

        private const int ALT = 0x0001;
        private const int CTRL = 0x0002;
        private const int SHIFT = 0x0004;
        private const int WIN = 0x0008;

        private Settings settings;
        
        public MainForm()
        {
            InitializeComponent();

            settings = new Settings();
            loadPrefs();
            registerHotkey();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            savePrefs();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                Hide();
            }
            else
            {
                notifyIcon.Visible = false;
            }
        }

        private void loadPrefs()
        {
            keyTextBox.Text = settings.Char;
            altBox.Checked = settings.AltEnabled;
            ctrlBox.Checked = settings.CtrlEnabled;
            shiftBox.Checked = settings.ShiftEnabled;
            relaunchBox.Checked = settings.Relaunch;
            steamTextBox.Text = settings.SteamPath;
        }

        private void savePrefs()
        {
            if (keyTextBox.Text.Length != 1)
            {
                MessageBox.Show("Please set a character in the Key field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (relaunchBox.Checked && !steamTextBox.Text.ToLower().EndsWith("steam.exe"))
            {
                MessageBox.Show("Steam path doesn't point to a valid Steam.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            settings.Char = keyTextBox.Text;
            settings.AltEnabled = altBox.Checked;
            settings.CtrlEnabled = ctrlBox.Checked;
            settings.ShiftEnabled = shiftBox.Checked;
            settings.Relaunch = relaunchBox.Checked;
            settings.SteamPath = steamTextBox.Text;

            registerHotkey();
        }

        private void registerHotkey()
        {
            int hotkeyModifier = 0;
            if (settings.AltEnabled)
            {
                hotkeyModifier += ALT;
            }

            if (settings.CtrlEnabled)
            {
                hotkeyModifier += CTRL;
            }

            if (settings.ShiftEnabled)
            {
                hotkeyModifier += SHIFT;
            }

            UnregisterHotKey(Handle, HOTKEY_ID);
            RegisterHotKey(Handle, HOTKEY_ID, hotkeyModifier, settings.Char.ToCharArray()[0]);
        }

        private void startGame()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = settings.SteamPath;
                startInfo.Arguments = "-applaunch 578080";
                Process.Start(startInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to launch PUBG", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(Handle, HOTKEY_ID);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_HOTKEY)
            {
                if (m.WParam.ToInt32() == HOTKEY_ID)
                {
                    foreach (var process in Process.GetProcessesByName("TslGame"))
                    {
                        process.Kill();
                    }

                    if (settings.Relaunch)
                    {
                        startGame();
                    }
                }
            }
        }

        private void relaunchBox_CheckedChanged(object sender, EventArgs e)
        {
            steamTextBox.ReadOnly = !relaunchBox.Checked;
            browseButton.Enabled = relaunchBox.Checked;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            steamTextBox.Text = dialog.FileName;
        }

        private void bitcoinButton_Click(object sender, EventArgs e)
        {
            new BitcoinForm().Show();
        }
    }
}
