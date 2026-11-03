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
    public partial class Frm3x3Empty : Form
    {
        public Frm3x3Empty()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            Frm3x3Solved form = new Frm3x3Solved();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {

        }

        private void rb2x2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2x2.Checked)
            {
                Frm2x2Empty form = new Frm2x2Empty();

                this.Hide();
                form.ShowDialog();
                this.Show();

                rb3x3.Checked = true;
            }
        }
    }
}
