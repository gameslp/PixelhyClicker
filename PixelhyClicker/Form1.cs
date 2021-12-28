using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;
using System.Runtime.InteropServices;

namespace PixelhyClicker
{
    public partial class PixelhyClicker : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        InputSimulator sim = new InputSimulator();
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
   
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public PixelhyClicker()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("enable"))
            {
                btnToggle.Text = "disable";
            }
            else if (btnToggle.Text.Contains("disable"))
            {
                btnToggle.Text = "enable";
            }
        }

        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();
                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch
            {}
            return null;
        }

        private void btnToggle_TextChanged(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable"))
            {
                siticoneButton1.Enabled = false; 
                btnToggle.FillColor = Color.FromArgb(0, 192, 192);
                btnToggle.ForeColor = Color.FromArgb(80, 80, 80);
                if (siticoneButton1.Text.Contains("hold"))
                {
                    AutoClicker.Start();
                }
                else
                {
                    holdTick.Start();
                }
            }
            else
            {
                siticoneButton1.Enabled = true;
                btnToggle.FillColor = Color.FromArgb(80, 80, 80);
                btnToggle.ForeColor = Color.White;
                if (siticoneButton1.Text.Contains("hold"))
                {
                    AutoClicker.Stop();
                }
                else
                {
                    dziala = false;
                    holdTick.Stop();
                    PostMessage(hWnd, 0x0202, 0, 0);
                }
            }
        }

        IntPtr hWnd;
        public bool clicker = true;
        private async void AutoClicker_Tick(object sender, EventArgs e)
        {
            try
            {
                AutoClicker.Interval = 1000 / CPSTrackBar.Value;
            }
            catch { }
            if (btnToggle.Text.Contains("disable"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = getActiveWindowName();
                if (currentwindow == null)
                {
                    return;
                }

                if (currentwindow.Contains("javaw"))
                {
                    PostMessage(hWnd, 0x0201, 0, 0);
                    await Task.Delay(30);
                    PostMessage(hWnd, 0x0202, 0, 0);
                }
            }
        }

        private void bindBtn_Click(object sender, EventArgs e)
        {
            bindBtn.Text = "...";
        }

        KeysConverter Key = new KeysConverter();

        private void Binding_Tick(object sender, EventArgs e)
        {
            if (bindBtn.Text != "none" && bindBtn.Text != "...")
            {
                Keys binding = (Keys)Key.ConvertFromString(bindBtn.Text.Replace("...", ""));
                if (GetAsyncKeyState(binding) < 0)
                {
                    if (btnToggle.Text.Contains("disable"))
                    {
                        btnToggle.Text = "enable";
                    }
                    else if (btnToggle.Text.Contains("enable"))
                    {
                        btnToggle.Text = "disable";
                    }

                    while (GetAsyncKeyState(binding) < 0)
                    {
                        Thread.Sleep(20);
                    }
                    return;
                }
            }
        }

        private void bindBtn_KeyDown(object sender, KeyEventArgs e)
        {
            {
                string keydata = e.KeyData.ToString();
                if (!keydata.Contains("Alt"))
                {
                    if (GetAsyncKeyState(Keys.Escape) < 0)
                    {
                        bindBtn.Text = "none";
                    }
                    else
                    {
                        bindBtn.Text = keydata;
                    }
                }
            }
            KeysConverter Key = new KeysConverter();
        }

        private async void AntiAFK_Tick(object sender, EventArgs e)
        {
            if (AFKToggle.Text.Contains("disable"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = getActiveWindowName();
                if (currentwindow == null)
                {
                    return;
                }

                if (currentwindow.Contains("javaw"))
                {
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_A);
                    await Task.Delay(30);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_A);
                    await Task.Delay(1000);
                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_D);
                    await Task.Delay(30);
                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_D);
                    await Task.Delay(1000);
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void AFKToggle_Click(object sender, EventArgs e)
        {
            if (AFKToggle.Text.Contains("disable"))
            {
                AFKToggle.Text = "enable";
            }
            else if (AFKToggle.Text.Contains("enable"))
            {
                AFKToggle.Text = "disable";
            }
        }

        private void AFKToggle_TextChanged(object sender, EventArgs e)
        {
            if (AFKToggle.Text.Contains("disable"))
            {
                AFKToggle.FillColor = Color.FromArgb(0, 192, 192);
                AFKToggle.ForeColor = Color.FromArgb(80, 80, 80);
                AntiAFK.Start();
            }
            else
            {
                AFKToggle.FillColor = Color.FromArgb(80, 80, 80);
                AFKToggle.ForeColor = Color.White;
                AntiAFK.Stop();
            }
        }

        private void CPSTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            CPSValueText.Text = (CPSTrackBar.Value.ToString() + " CPS");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneButton1.Text.Contains("hold"))
            {
                siticoneButton1.Text = "tap";
            }
            else if (siticoneButton1.Text.Contains("tap"))
            {
                siticoneButton1.Text = "hold";
            }
        }

        private void siticoneButton1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool dziala = false;
        private void holdTick_Tick(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = getActiveWindowName();
                if (currentwindow == null)
                {
                    dziala = false;
                    PostMessage(hWnd, 0x0202, 0, 0);
                }

                else if (currentwindow.Contains("javaw"))
                {
                    if (dziala == false)
                    {
                        dziala = true;
                        PostMessage(hWnd, 0x0201, 0, 0);
                    }
                }
                else
                {
                    dziala = false;
                    PostMessage(hWnd, 0x0202, 0, 0);
                }

            }
        }
    }
}
