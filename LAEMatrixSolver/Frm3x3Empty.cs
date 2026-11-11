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
    public partial class Frm3x3Empty : Form
    {
        public Frm3x3Empty()
        {
            InitializeComponent();

            string equation1 = "";
            string equation2 = "";
            string equation3 = "";

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
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
            // CHECK EQUATIONS
            if (CheckEquation(txtBoxEq1.Text) == false ||
                CheckEquation(txtBoxEq2.Text) == false ||
                CheckEquation(txtBoxEq3.Text) == false)
            {
                return;
            }

            // SAVE EQUATIONS
            txtBoxEq1_Leave(sender, e);
            txtBoxEq2_Leave(sender, e);
            txtBoxEq3_Leave(sender, e);

            // OPEN SOLVED FORM
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

            // CHECK EMPTY EQUATION
            if (equation.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter an equation.",
                    "Empty Equation");

                return false;
            }

            // REMOVE SPACES AND CONVERT TO LOWERCASE
            equation = Regex.Replace(equation, @"\s+", "").ToLower();

            // CHECK CHARACTERS AND VARIABLES
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

                // CHECK INVALID CHARACTERS
                if (!char.IsDigit(letter) &&
                    letter != 'x' && letter != 'y' &&
                    letter != 'z' && letter != '+' &&
                    letter != '-' && letter != '=' &&
                    letter != '.')
                {
                    MessageBox.Show(
                        "Invalid character in equation.",
                        "Invalid Equation");

                    return false;
                }

                // CHECK MULTIPLICATION BETWEEN VARIABLES
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

            // CHECK MISSING VARIABLES
            if (!hasX || !hasY || !hasZ)
            {
                MessageBox.Show(
                    "Please include x, y, and z in your equation.",
                    "Missing Variable");

                return false;
            }

            // CHECK MISSING EQUAL SIGN
            if (!hasEqual)
            {
                MessageBox.Show(
                    "Please include an equal sign (=).",
                    "Missing Equal Sign");

                return false;
            }

            // CHECK MULTIPLE EQUAL SIGNS
            if (equation.Split('=').Length != 2)
            {
                MessageBox.Show(
                    "Please use exactly one equal sign (=).",
                    "Invalid Equation");

                return false;
            }

            // CHECK MISSING CONSTANT
            if (equation.Split('=')[1] == "")
            {
                MessageBox.Show(
                    "Please enter a constant after the equal sign.",
                    "Missing Constant");

                return false;
            }

            // CHECK EQUATION STRUCTURE
            string pattern = @"^[+-]?(\d+(\.\d*)?|\.\d+)?x[+-](\d+(\.\d*)?|\.\d+)?y[+-](\d+(\.\d*)?|\.\d+)?z=[+-]?(\d+(\.\d*)?|\.\d+)$";

            if (!Regex.IsMatch(equation, pattern))
            {
                MessageBox.Show(
                    "Invalid equation format.\n\n" +
                    "Correct format: ax + by + cz = d",
                    "Invalid Equation");

                return false;
            }

            return true;
        }
    }
}
