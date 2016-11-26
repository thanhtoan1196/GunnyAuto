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

        int dem = 3;
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (dem == 0)
            {
                dem = 2;
                webBrowser1.Document.GetElementById("zme-registerwg").InvokeMember("click");

            }
            if (dem == 2)
            {
                dem = 6;
                webBrowser1.Document.GetElementById("zaccount").SetAttribute("value", user);
                webBrowser1.Document.GetElementById("zpwpd").SetAttribute("value", pass);
                webBrowser1.Document.GetElementById("btn - login").InvokeMember("click");
            }

            if (dem == 10)
            {
                dem = 11;
                webBrowser1.Document.GetElementById("u").SetAttribute("value", user);
                webBrowser1.Document.GetElementById("p").SetAttribute("value", pass);
                webBrowser1.Document.GetElementById("btnLogin").InvokeMember("click");
            }

            if (dem == 11)
            {
                dem = 12;
                webBrowser1.Navigate(@"http://idgunny.360game.vn/play-game?_svid=228&");
            }

            if (dem == 3)
            {
                webBrowser1.Document.GetElementById("u").SetAttribute("value", user);
                webBrowser1.Document.GetElementById("p").SetAttribute("value", pass);

                HtmlElementCollection elc = webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement item in elc)
                {
                    if (item.GetAttribute("type").Equals("submit"))
                    {
                        item.InvokeMember("click");
                    }

                }
                dem++;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ass = @"http://gunny.360game.vn/";
            string s = @"http://login.me.zing.vn";
            string s1 = @"http://idgunny.360game.vn/play-game?_svid=228&";
            webBrowser1.Navigate(s1);
        }

        string user, pass;
        public void GetUserPass(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
    }
}
