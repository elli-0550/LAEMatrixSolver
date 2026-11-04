using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LAEMatrixSolver.Properties
{
    public partial class Frm2x2Empty : Form
    {
        public Frm2x2Empty()
        {
            InitializeComponent();

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET MatrixSize = 2";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.ExecuteNonQuery();

                query = "SELECT Equation1, Equation2 FROM CurrentEquation";

                command = new SqliteCommand(query, connection);
                SqliteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtBoxEq1.Text = reader["Equation1"].ToString();
                    txtBoxEq2.Text = reader["Equation2"].ToString();
                }

                reader.Close();
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (CheckEquation(txtBoxEq1.Text) == false || CheckEquation(txtBoxEq2.Text) == false)
            {
                return;
            }

            txtBoxEq1_Leave(sender, e);
            txtBoxEq2_Leave(sender, e);

            Frm2x2Solved form3 = new Frm2x2Solved();

            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
            this.Hide();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtBoxEq1.Text = "";
            txtBoxEq2.Text = "";

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation1 = NULL, Equation2 = NULL, Equation3 = NULL";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
        private void rb3x3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3x3.Checked)
            {
                using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
                {
                    connection.Open();

                    string query = "UPDATE CurrentEquation SET MatrixSize = 3";

                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                Frm3x3Empty form4 = new Frm3x3Empty();

                this.Hide();
                form4.ShowDialog();
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
                if (CheckEquation(txtBoxEq2.Text) == false)
                {
                    return;
                }
                connection.Open();

                string query = "UPDATE CurrentEquation SET Equation2 = @Eq2";

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Eq2", txtBoxEq2.Text);

                command.ExecuteNonQuery();
            }
        }

        //checking of inputs
        private bool CheckEquation(string equation)
        {
            bool hasX = false;
            bool hasY = false;
            bool hasZ = false;

            equation = equation.Replace(" ", "").ToLower();

            for (int i = 0; i < equation.Length; i++)
            {
                char letter = equation[i];

                if (letter == 'x')
                    hasX = true;

                if (letter == 'y')
                    hasY = true;

                if (letter == '=')
                    hasZ = true;

                if (!char.IsDigit(letter) &&
           letter != 'x' && letter != 'y' &&
           letter != '+' && letter != '-' &&
           letter != '=' && letter != '.')
                {
                    MessageBox.Show("Invalid character in equation.");
                    return false;
                }

                if (i < equation.Length - 1)
                {
                    if ((letter == 'x' && equation[i + 1] == 'y') ||
                        (letter == 'y' && equation[i + 1] == 'x'))
                    {
                        MessageBox.Show(
                            "Multiplication between variables is not allowed.",
                            "Invalid Equation");

                        return false;
                    }
                }
            }

            if (hasX == false || hasY == false || hasZ == false)
            {
                MessageBox.Show(
                    "Please enter a complete equation using x, y, and z.",
                    "Incomplete Equation");

                return false;
            }

            return true;
        }
    }
}
