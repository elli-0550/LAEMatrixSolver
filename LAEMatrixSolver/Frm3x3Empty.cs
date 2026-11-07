using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Data.Sqlite;

namespace LAEMatrixSolver.Properties
{
    public partial class Frm3x3Empty : Form
    {
        public Frm3x3Empty()
        {
            InitializeComponent();

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET MatrixSize = 3";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.ExecuteNonQuery();
            }

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "SELECT Equation1, Equation2, Equation3 FROM CurrentEquation";

                SqliteCommand command = new SqliteCommand(query, connection);

                SqliteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string equation1 = reader["Equation1"].ToString();
                    string equation2 = reader["Equation2"].ToString();
                    string equation3 = reader["Equation3"].ToString();

                    txtBoxEq1.Text = equation1;
                    txtBoxEq2.Text = equation2;
                    txtBoxEq3.Text = equation3;
                }

                reader.Close();
            }

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            Frm3x3Solved form = new Frm3x3Solved();

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtBoxEq1.Text = "";
            txtBoxEq2.Text = "";
            txtBoxEq3.Text = "";

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation1 = NULL, Equation2 = NULL, Equation3 = NULL";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }


        private void rb2x2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2x2.Checked)
            {

                using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
                {
                    connection.Open();

                    string query = "UPDATE CurrentEquation SET MatrixSize = 2";

                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                Frm2x2Empty form = new Frm2x2Empty();

                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void txtBoxEq1_Leave(object sender, EventArgs e)
        {
            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation1 = @Eq1";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Eq1", txtBoxEq1.Text);

                command.ExecuteNonQuery();


            }
        }

        private void txtBoxEq2_Leave(object sender, EventArgs e)
        {
            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation2 = @Eq2";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Eq2", txtBoxEq2.Text);

                command.ExecuteNonQuery();


            }

        }

        private void txtBoxEq3_Leave(object sender, EventArgs e)
        {
            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation3 = @Eq3";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Eq3", txtBoxEq3.Text);

                command.ExecuteNonQuery();


            }


        }

        private void txtBoxEq3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


    