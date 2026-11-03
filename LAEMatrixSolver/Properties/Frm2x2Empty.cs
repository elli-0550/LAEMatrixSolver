using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LAEMatrixSolver.Properties
{
    public partial class Frm2x2Empty : Form
    {
        public Frm2x2Empty()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            Frm2x2Solved form3 = new Frm2x2Solved();

            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
            this.Hide();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            Frm2x2Empty form2 = new Frm2x2Empty();

            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }
        private void rb3x3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3x3.Checked)
            {
                Frm3x3Empty form4 = new Frm3x3Empty();

                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
        }
    }
}
