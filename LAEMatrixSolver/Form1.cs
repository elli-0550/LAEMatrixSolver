namespace LAEMatrixSolver
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Microsoft.Data.Sqlite;
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation1 = NULL, Equation2 = NULL, Equation3 = NULL";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.ExecuteNonQuery();
            }

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();
                string query = "UPDATE CurrentEquation SET MatrixSize = 2";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.ExecuteNonQuery();
            }
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
    }
}
