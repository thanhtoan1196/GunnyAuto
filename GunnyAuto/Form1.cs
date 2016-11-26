using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diendan.goonline.vn_Hock;

namespace GunnyAuto
{
    public partial class Form1 : Form
    {
        private void WriteRegister()
        {
            List<string> keys = new List<string>();
            keys.Add("GunnyAuto.exe");
            keys.Add("GunnyAuto.vshost.exe");
            keys.Add("GunnyAutoTest.exe");
            string str = @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(str);

            foreach (var item in keys)
            {
                rk.SetValue(item.ToString(), "11001", RegistryValueKind.DWord);
            }
        }

        Keylogger kl = new Keylogger();
        private void SetupKeyLogger()
        {
            kl.VKCodeDown += new Keylogger.ValueChangedEventHandler2(kl_VKCodeDown);
            kl.VKCodeUp += new Keylogger.ValueChangedEventHandler2(kl_VKcodeUp);
            kl.Keylogger_Mode = Keylogger.Keylogger_Modes.Hooks;
            kl.Enabled = false;
        }

        private void KeyLoggerEn()
        {
            kl.Enabled = true;
        }
        private void KeyLoggerDis()
        {
            kl.Enabled = false;
        }

        public Form1()
        {
            SetupKeyLogger();
            WriteRegister();
            InitializeComponent();
        }

        private void kl_VKcodeUp(int vkcode)
        {
            switch (vkcode)
            {
                case 76: // l
                    buffDame1ToolStripMenuItem_Click(null, null);
                    break;
                case 75: // k
                    buffDame2ToolStripMenuItem_Click(null, null);
                    break;
                case 74: // j
                    buffDame3ToolStripMenuItem_Click(null, null);
                    break;
            }
            keyToolStripMenuItem.Text = "key - " + vkcode.ToString();
        }

        private void kl_VKCodeDown(int vkcode)
        {
            keyToolStripMenuItem.Text = "key + " + vkcode.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBangLuc formBangLuc = new FormBangLuc();

            formBangLuc.Show();
        }

        ProcessKeyboard pk = new ProcessKeyboard();
        private void buffDame1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pk.SendKey("1445678");
        }

        private void buffDame2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pk.SendKey("3445678");
        }

        private void buffDame3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pk.SendKey("1245678");
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyLoggerDis();
            disableToolStripMenuItem.Checked = true;
            enableToolStripMenuItem.Checked = false;
        }
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyLoggerEn();
            disableToolStripMenuItem.Checked = false;
            enableToolStripMenuItem.Checked = true;
        }
    }
}
