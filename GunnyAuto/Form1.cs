using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Form1()
        {
            WriteRegister();
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBangLuc formBangLuc = new FormBangLuc();

            formBangLuc.Show();
        }
    }
}
