using App_csharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using icp = Interceptor;

namespace SecureHotKey
{
    public partial class frmMain : Form
    {
        icp.Input input;

        public frmMain()
        {
            InitializeComponent();
        }

        #region "热键设置相关代码"

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(
            IntPtr hWnd,
            int id,                            // 热键标识
            KeyModifiers modkey,  //  修改键
            Keys vk                         //  虚键码
        );

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,              // 窗口句柄 
            int id                          // 热键标识 
        );

        void reg_hotkey()
        {
            RegisterHotKey(this.Handle, 80, 0, Keys.F8);
            RegisterHotKey(this.Handle, 90, 0, Keys.F9);

        }

        void unreg_hotkey()
        {
            UnregisterHotKey(this.Handle, 80);
            UnregisterHotKey(this.Handle, 90);
            UnregisterHotKey(this.Handle, 100);
            UnregisterHotKey(this.Handle, 200);                     //缷载3个快捷键
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;                        //0x0312表示用户热键
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    ProcessHotkey(m);                                      //调用ProcessHotkey()函数
                    break;
            }
            base.WndProc(ref m);
        }

        private void ProcessHotkey(Message msg)              //按下设定的键时调用该函数
        {
            switch (msg.WParam.ToInt32())
            {
                case 80:
                    Fun80();
                    break;
                case 90:
                    Fun90();
                    break;

            }
        }

        // F8
        private void Fun80()
        {
            var txt = txtF8.Text;
            SendKey(txt);
        }

        // F9
        private void Fun90()
        {
            var txt = txtF9.Text;
            SendKey(txt);
        }


        #endregion

        private void SendKey(string txt) {
            input.SendText(txt);

            // enter
            if (chkReturn.Checked)
            {
                input.SendKeys(icp.Keys.Enter);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            reg_hotkey(); // 注册热键

            input = new icp.Input();
            input.KeyPressDelay = 2;

            // Be sure to set your keyboard filter to be able to capture key presses and simulate key presses
            // KeyboardFilterMode.All captures all events; 'Down' only captures presses for non-special keys; 'Up' only captures releases for non-special keys; 'E0' and 'E1' capture presses/releases for special keys
            input.KeyboardFilterMode = icp.KeyboardFilterMode.All;
            // You can set a MouseFilterMode as well, but you don't need to set a MouseFilterMode to simulate mouse clicks

            // Finally, load the driver
            input.Load();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            unreg_hotkey();
        }

        private void chkVisiableF8_CheckedChanged(object sender, EventArgs e)
        {
            txtF8.PasswordChar = (sender as CheckBox).Checked ? (char)0 : '*';
        }

        private void chkVisiableF9_CheckedChanged(object sender, EventArgs e)
        {
            txtF9.PasswordChar = (sender as CheckBox).Checked ? (char)0 : '*';
        }
    }
}
