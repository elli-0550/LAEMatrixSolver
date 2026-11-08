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

            string equation1 = "";
            string equation2 = "";
            string equation3 = "";

            using (SqliteConnection connection = new SqliteConnection(
                @"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET MatrixSize = 3";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                query = "SELECT Equation1, Equation2, Equation3 FROM CurrentEquation";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        equation1 = reader["Equation1"].ToString();
                        equation2 = reader["Equation2"].ToString();
                        equation3 = reader["Equation3"].ToString();
                    }
                }
            }

            // Load after closing the database connection
            txtBoxEq1.Text = equation1;
            txtBoxEq2.Text = equation2;
            txtBoxEq3.Text = equation3;

        }


        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (CheckEquation(txtBoxEq1.Text) == false ||
                CheckEquation(txtBoxEq2.Text) == false ||
                CheckEquation(txtBoxEq3.Text) == false)
            {
                return;
            }

            txtBoxEq1_Leave(sender, e);
            txtBoxEq2_Leave(sender, e);
            txtBoxEq3_Leave(sender, e);

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
            if (txtBoxEq1.Text.Trim() == "")
                return;

            if (CheckEquation(txtBoxEq1.Text) == false)
                return;

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
            if (txtBoxEq2.Text.Trim() == "")
                return;

            if (CheckEquation(txtBoxEq2.Text) == false)
                return;

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
            if (txtBoxEq3.Text.Trim() == "")
                return;

            if (CheckEquation(txtBoxEq3.Text) == false)
                return;

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation3 = @Eq3";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Eq3", txtBoxEq3.Text);

                command.ExecuteNonQuery();
            }
        }

        private bool CheckEquation(string equation)
        {
            bool hasX = false;
            bool hasY = false;
            bool hasZ = false;
            bool hasEqual = false;

            equation = equation.Replace(" ", "").ToLower();

            for (int i = 0; i < equation.Length; i++)
            {
                char letter = equation[i];

                if (letter == 'x')
                    hasX = true;

                if (letter == 'y')
                    hasY = true;

                if (letter == 'z')
                    hasZ = true;

                if (letter == '=')
                    hasEqual = true;

                if (!char.IsDigit(letter) &&
                    letter != 'x' && letter != 'y' &&
                    letter != 'z' && letter != '+' &&
                    letter != '-' && letter != '=' &&
                    letter != '.')
                {
                    MessageBox.Show("Invalid character in equation.");
                    return false;
                }

                if (i < equation.Length - 1)
                {
                    if ((letter == 'x' || letter == 'y' || letter == 'z') &&
                        (equation[i + 1] == 'x' ||
                         equation[i + 1] == 'y' ||
                         equation[i + 1] == 'z'))
                    {
                        MessageBox.Show(
                            "Multiplication between variables is not allowed.",
                            "Invalid Equation");

                        return false;
                    }
                }
            }

            if (hasX == false || hasY == false ||
                hasZ == false || hasEqual == false)
            {
                MessageBox.Show(
                    "Please enter a complete equation using x, y, z, and =.",
                    "Incomplete Equation");

                return false;
            }

            return true;
        }

    }
}


    