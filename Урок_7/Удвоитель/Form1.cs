using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Удвоитель
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int lbl_1_count = 0;
        int lbl_2_count = 0;
        int lbl_3_count = 0;


        private void btnCommfnd1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lbl_1_count++;
            lbl_1.Text = lbl_1_count.ToString();
        }

        private void btnConnfnd2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lbl_2_count++;
            lbl_2.Text = lbl_2_count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lbl_3_count++;
            lbl_3.Text = lbl_3_count.ToString();
        }
    }
}
