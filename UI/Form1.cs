using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            double a, b, c;
            
            try
            {
                if(txtA.Text == "")
                {
                    MessageBox.Show("Chưa nhập a !!!" , "Thông báo !");
                    return;
                }
                a = Convert.ToDouble(txtA.Text);

                if (txtB.Text == "")
                {
                    MessageBox.Show("Chưa nhập b !!!", "Thông báo !");
                    return;
                }
                b = Convert.ToDouble(txtB.Text);

                if (txtC.Text == "")
                {
                    MessageBox.Show("Chưa nhập c !!!", "Thông báo !");
                    return;
                }
                c = Convert.ToDouble(txtC.Text);

                double delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta < 0)
                {
                    txtKetqua.Text = "Phương trình vô nghiệm !";
                }
                else if (delta == 0)
                {
                    double X1 = (b * -1) / 2 * a;

                    double rounded1 = Math.Round(X1,3);
                    txtX1.Text = rounded1.ToString();
                    txtKetqua.Text = "Phương trình có nghiệm kép ";
                }
                else
                {
                    double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double rounded1 = Math.Round(X1,3);
                    double rounded2 = Math.Round(X2,3);
                    txtX1.Text = rounded1.ToString();
                    txtX2.Text = rounded2.ToString();
                    txtKetqua.Text = "Phương trình có 2 nghiệm phân biệt";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?" , "Thông báo !",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
