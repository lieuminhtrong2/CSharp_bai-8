using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_bai_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        String can, chi;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(txtDuongLich.Text.Substring(3, 1)))
            {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Quý";
                    break;
                case 4:
                    can = "Giáp";
                    break;
                case 5:
                    can = "Ắt";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                    break;
                case 9:
                    can = "Kỷ";
                    break;

                    switch (Convert.ToInt32(txtDuongLich.Text) % 12)
                    {
                        case 1:
                            chi = "Tý";
                            break;
                        case 2:
                            chi = "Sủ";
                            break;
                        case 3:
                            chi = "Dần";
                            break;
                        case 4:
                            chi = "Mão";
                            break;
                        case 5:
                            can = "Thìn";
                            break;
                        case 6:
                            can = "Tỵ";
                            break;
                        case 7:
                            can = "Ngọ";
                            break;
                        case 8:
                            can = "Mùi";
                            break;
                        case 9:
                            can = "Thân";
                            break;
                        case 10:
                            can = "Dậu";
                            break;
                        case 11:
                            can = "Tuất";
                            break;
                        case 12:
                            can = "Hợi";
                            break;

                    }
                    txtAmLich.Text = can + " " + chi;
            }
        }
    }
}



