using LAEMatrixSolver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAEMatrixSolver
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm2x2Empty dashForm = new Frm2x2Empty();
            dashForm.FormClosed += (s, args) => this.Close();
            dashForm.Show();
            this.Hide();
        }
    }
}
