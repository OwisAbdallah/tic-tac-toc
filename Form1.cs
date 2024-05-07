using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        int dor = 0,p1=0,p2=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (dor % 2 == 0)
            {
                btn.Text = "X";
                btn.BackColor = Color.Red;
                dor++;
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "O";
                btn.BackColor = Color.Green;
                dor++;
                btn.Enabled = false;
            }

            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Enabled == false ||
                button4.Text == button5.Text && button4.Text == button6.Text && button4.Enabled == false ||
                button7.Text == button8.Text && button7.Text == button9.Text && button7.Enabled == false ||
                button1.Text == button4.Text && button1.Text == button7.Text && button1.Enabled == false ||
                button2.Text == button5.Text && button2.Text == button8.Text && button2.Enabled == false ||
                button3.Text == button6.Text && button3.Text == button9.Text && button3.Enabled == false ||
                button1.Text == button5.Text && button1.Text == button9.Text && button1.Enabled == false ||
                button3.Text == button5.Text && button3.Text == button7.Text && button3.Enabled == false)
            {
                if (dor % 2 != 0)
                {
                    MessageBox.Show("اللاعب الأول يفوز");
                    p1++;
                }
                else
                {
                    MessageBox.Show("اللاعب الثاني يفوز");
                    p2++;
                }
                End();
            }
            if (dor == 9)
            {
                MessageBox.Show("تعادل");
                End();
            }

                    
        }
        public void End()
        {
            button1.Text = "";
            button1.Enabled = true;
            button1.BackColor = Color.PowderBlue;
            button2.Text = "";
            button2.Enabled = true;
            button2.BackColor = Color.PowderBlue;
            button3.Text = "";
            button3.Enabled = true;
            button3.BackColor = Color.PowderBlue;
            button4.Text = "";
            button4.Enabled = true;
            button4.BackColor = Color.PowderBlue;
            button5.Text = "";
            button5.Enabled = true;
            button5.BackColor = Color.PowderBlue;
            button6.Text = "";
            button6.Enabled = true;
            button6.BackColor = Color.PowderBlue;
            button7.Text = "";
            button7.Enabled = true;
            button7.BackColor = Color.PowderBlue;
            button8.Text = "";
            button8.Enabled = true;
            button8.BackColor = Color.PowderBlue;
            button9.Text = "";
            button9.Enabled = true;
            button9.BackColor = Color.PowderBlue;
            dor = 0;
            label3.Text = p1.ToString();
            label4.Text = p2.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
            p1 = 0; p2 = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
