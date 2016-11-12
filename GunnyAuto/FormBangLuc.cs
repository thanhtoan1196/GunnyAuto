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
    public partial class FormBangLuc : Form
    {
        List<Label> listLabel = new List<Label>();
        public FormBangLuc()
        {
            InitializeComponent();
            listLabel.Add(lblLuc1);
            listLabel.Add(lblLuc2);
            listLabel.Add(lblLuc3);
            listLabel.Add(lblLuc4);
            listLabel.Add(lblLuc5);
            listLabel.Add(lblLuc6);
            listLabel.Add(lblLuc7);
            listLabel.Add(lblLuc8);
            listLabel.Add(lblLuc9);
            listLabel.Add(lblLuc10);
            listLabel.Add(lblLuc11);
            listLabel.Add(lblLuc12);
            listLabel.Add(lblLuc13);
            listLabel.Add(lblLuc14);
            listLabel.Add(lblLuc15);
            listLabel.Add(lblLuc16);
            listLabel.Add(lblLuc17);
            listLabel.Add(lblLuc18);
            listLabel.Add(lblLuc19);
            listLabel.Add(lblLuc20);
            button1.Click += new EventHandler(Button_Click);
            button2.Click += new EventHandler(Button_Click);
            button3.Click += new EventHandler(Button_Click);
            button4.Click += new EventHandler(Button_Click);
            button5.Click += new EventHandler(Button_Click);
            button6.Click += new EventHandler(Button_Click);
            button7.Click += new EventHandler(Button_Click);
            button8.Click += new EventHandler(Button_Click);
            button9.Click += new EventHandler(Button_Click);
            button10.Click += new EventHandler(Button_Click);
            button11.Click += new EventHandler(Button_Click);
            button12.Click += new EventHandler(Button_Click);
            FillLucToLabel();
        }

        int goc = 20;
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "button1":
                    goc = 20;
                    break;
                case "button2":
                    goc = 30;
                    break;
                case "button3":
                    goc = 35;
                    break;
                case "button4":
                    goc = 40;
                    break;
                case "button5":
                    goc = 45;
                    break;
                case "button6":
                    goc = 50;
                    break;
                case "button7":
                    goc = 55;
                    break;
                case "button8":
                    goc = 60;
                    break;
                case "button9":
                    goc = 65;
                    break;
                case "button10":
                    goc = 70;
                    break;
                case "button11":
                    goc = 75;
                    break;
                case "button12":
                    goc = 80;
                    break;
                default:
                    goc = 20;
                    break;
            }

            FillLucToLabel();
        }

        int[] gocAvailable = { 20, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };
        int[,] lucTheoGoc =
        {
            { 10, 19, 25, 30, 36, 40, 44, 48, 51, 54, 57, 60, 63, 66, 69, 72, 74, 76, 78, 80}, // 20
            { 14, 20, 24, 28, 32, 35, 39, 42, 44, 47, 50, 53, 55, 58, 60, 63, 65, 67, 69, 72}, // 30
            { 11, 19, 14, 28, 32, 34, 38, 41, 44, 47, 50, 52, 54, 56, 58, 61, 63, 65, 67, 69}, // 35
            { 10, 19, 24, 28, 31, 34, 38, 41, 43, 46, 49, 51, 53, 56, 58, 60, 62, 64, 66, 68}, // 40
            { 11, 19, 24, 28, 31, 34, 38, 41, 44, 46, 49, 51, 54, 56, 58, 61, 63, 65, 67, 69}, // 45
            { 11, 19, 24, 28, 32, 35, 38, 41, 44, 47, 50, 52, 55, 57, 59, 62, 64, 66, 68, 71}, // 50
            { 12, 20, 25, 29, 33, 36, 40, 43, 46, 49, 52, 54, 57, 59, 62, 64, 67, 69, 71, 74}, // 55
            { 12, 21, 26, 31, 35, 38, 42, 45, 49, 52, 55, 57, 60, 63, 66, 68, 71, 74, 76, 78}, // 60
            { 13, 21, 26, 32, 37, 41, 45, 49, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 85}, // 65
            { 15, 25, 31, 37, 41, 45, 50, 55, 59, 62, 66, 70, 73, 77, 80, 84, 87, 90, 93, 96}, // 70
            { 17, 29, 36, 43, 48, 52, 58, 64, 68, 73, 78, 82, 87, 91, 95, 99,  0,  0,  0,  0}, // 75
            { 21, 35, 45, 53, 60, 67, 74, 82, 88, 93,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0}  // 80
        };

        private int indexOfIntegerFirst(int[] listNum, int num)
        {
            for (int i = 0; i < listNum.Length; i++)
            {
                if (listNum[i].Equals(num))
                {
                    return i;
                }
            }

            return 0;
        }

        private void FillLucToLabel()
        {
            //int.TryParse(txtBangLucGoc.Text, out goc);
            if (goc != 0)
            {
                if (gocAvailable.Contains(goc))
                {
                    for (int i = 0; i < 20; i++)
                    {
                        listLabel[i].Text = lucTheoGoc[indexOfIntegerFirst(gocAvailable, goc), i].ToString();
                    }

                }
            }
        }
    }
}
