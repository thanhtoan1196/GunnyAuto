using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GunnyAuto
{
    public delegate void GetUserPassDelegate(string user, string pass);

    public partial class MainForm : Form
    {
        public GetUserPassDelegate GetUserPassCallBack;

        public MainForm()
        {
            InitializeComponent();
        }

        Accounts.GunnyAuto a = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

            XmlSerializer xml = new XmlSerializer(typeof(Accounts.GunnyAuto));

            using (TextReader tr = new StreamReader("Accounts.xml"))
            {
                object obj = xml.Deserialize(tr);
                a = (Accounts.GunnyAuto)obj;
            }

            foreach (var item in a.Game)
            {
                dataGridView1.Rows.Add(false, item.LoginTab.player, "OFFLINE");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        int isRowSelected = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isRowSelected = e.RowIndex;
            if (e.RowIndex == -1) return;
            txtTaikhoan.Text = a.Game[e.RowIndex].LoginTab.user;
            txtPass.Text = Pass.Decrypt(a.Game[0].LoginTab.pass);
            txtTenNhanVat.Text = a.Game[e.RowIndex].LoginTab.player;
            cbMayChu.Text = a.Game[e.RowIndex].LoginTab.server;

            if (e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell c1 = (DataGridViewCheckBoxCell)dataGridView1[0, e.RowIndex];
                if (c1.Value == null)
                {
                    c1.Value = false;
                }
                if ((bool)c1.Value == false)
                {
                    c1.Value = true;
                    Form1 f1 = new Form1();
                    f1.Text = string.Format("Gunny - [{0} # {1}]", a.Game[e.RowIndex].LoginTab.player, a.Game[e.RowIndex].LoginTab.server);
                    GetUserPassCallBack += new GetUserPassDelegate(f1.GetUserPass);
                    GetUserPassCallBack(a.Game[e.RowIndex].LoginTab.user, Pass.Decrypt(a.Game[e.RowIndex].LoginTab.pass));
                    f1.Show();
                }
                else
                {
                    c1.Value = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accounts.GunnyAutoGameLoginTab t = new Accounts.GunnyAutoGameLoginTab();
            t.user = txtTaikhoan.Text;
            t.player = txtTenNhanVat.Text;
            t.pass = Pass.Encrypt(txtPass.Text);
            t.server = cbMayChu.Text;
            a.Game.Add(new Accounts.GunnyAutoGame() { LoginTab = t });

            XmlSerializer xml = new XmlSerializer(typeof(Accounts.GunnyAuto));
            using (TextWriter tw = new StreamWriter("Accounts.xml"))
            {
                xml.Serialize(tw, a);
            }
            dataGridView1.Rows.Add(false, t.player, "OFFLINE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isRowSelected > -1)
            {
                a.Game[isRowSelected].LoginTab.user = txtTaikhoan.Text;
                a.Game[isRowSelected].LoginTab.player = txtTenNhanVat.Text;
                a.Game[isRowSelected].LoginTab.pass = Pass.Encrypt(txtPass.Text);
                a.Game[isRowSelected].LoginTab.server = cbMayChu.Text;
                dataGridView1.Rows[isRowSelected].Cells[1].Value = a.Game[isRowSelected].LoginTab.player;

                XmlSerializer xml = new XmlSerializer(typeof(Accounts.GunnyAuto));
                using (TextWriter tw = new StreamWriter("Accounts.xml"))
                {
                    xml.Serialize(tw, a);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isRowSelected > -1)
            {
                a.Game.RemoveAt(isRowSelected);
                dataGridView1.Rows.RemoveAt(isRowSelected);

                XmlSerializer xml = new XmlSerializer(typeof(Accounts.GunnyAuto));
                using (TextWriter tw = new StreamWriter("Accounts.xml"))
                {
                    xml.Serialize(tw, a);
                }
            }
        }
    }
}
