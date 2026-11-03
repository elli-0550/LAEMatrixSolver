namespace LAEMatrixSolver
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);

            lblPercent.Text = "Loading...." +
                              progressBar1.Value.ToString() + "%";

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();

                FrmMain mainForm = new FrmMain();

                mainForm.FormClosed += (s, args) => this.Close();

                mainForm.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void lblPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
