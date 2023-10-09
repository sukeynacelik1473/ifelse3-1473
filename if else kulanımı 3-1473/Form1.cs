using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_kulanımı_3_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbRenk1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnDeıstır_Click(object sender, EventArgs e)
        {
            if (rbRenk1.Checked)
            {
                this.BackColor=Color.Yellow;
            }
            else if (rbSayı2.Checked)
            {
                this.BackColor= Color.Green;
            }
            else if (rbSayı3.Checked)
            {
                this.BackColor = Color.Black;
            }
            else if(rbSayı4.Checked)
            {
                this.BackColor =Color.Orange;
            }
        }
    }
}
