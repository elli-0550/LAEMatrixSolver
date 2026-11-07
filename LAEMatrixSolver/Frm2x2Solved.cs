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
    public partial class Frm2x2Solved : Form
    {
        string equation1;
        string equation2;
        double x1, y1, x2, y2;
        double c1, c2;
        double determinant;
        double C11, C12, C21, C22;
        double n11, n12, n21, n22;

        public Frm2x2Solved()
        {
            InitializeComponent();
            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "SELECT Equation1, Equation2 FROM CurrentEquation";

                SqliteCommand command = new SqliteCommand(query, connection);
                SqliteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    equation1 = reader["Equation1"].ToString();
                    equation2 = reader["Equation2"].ToString();

                    txtBoxEq1.Text = equation1;
                    txtBoxEq2.Text = equation2;
                }

                reader.Close();
                try
                {
                    DisplayCoefficientMatrix();
                    DisplayDeterminant();
                    DisplayCofactorMatrix();
                    DisplayAdjointMatrix();
                    DisplayInverseMatrix();
                    DisplayComputeX();
                    DisplaySolution();
                    SaveHistory();
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Invalid equation format. Please check your inputs.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {

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
                Frm3x3Empty form4 = new Frm3x3Empty();

                form4.FormClosed += (s, args) => this.Close();
                form4.Show();
                this.Hide();

                rb2x2.Checked = true;
            }
        }

        private void DisplayCoefficientMatrix()
        {
            // EQUATION 1
            string[] sides1 = equation1.Replace(" ", "").Split('=');
            string[] terms1 = sides1[0].Replace("-", "+-").Split('+', StringSplitOptions.RemoveEmptyEntries);

            string xVal1 = terms1[0].Replace("x", "").Trim();
            string yVa1 = terms1[1].Replace("y", "").Trim();

            //for empty string, x, -x
            if (xVal1 == "")
                x1 = 1;
            else if (xVal1 == "-")
                x1 = -1;
            else
                x1 = double.Parse(xVal1);

            if (yVa1 == "")
                y1 = 1;
            else if (yVa1 == "-")
                y1 = -1;
            else
                y1 = double.Parse(yVa1);

            c1 = double.Parse(sides1[1]);


            // EQUATION 2
            string[] sides2 = equation2.Replace(" ", "").Split('=');
            string[] terms2 = sides2[0].Replace("-", "+-").Split('+', StringSplitOptions.RemoveEmptyEntries);

            string xValue2 = terms2[0].Replace("x", "").Trim();
            string yValue2 = terms2[1].Replace("y", "").Trim();

            if (xValue2 == "")
                x2 = 1;
            else if (xValue2 == "-")
                x2 = -1;
            else
                x2 = double.Parse(xValue2);

            if (yValue2 == "")
                y2 = 1;
            else if (yValue2 == "-")
                y2 = -1;
            else
                y2 = double.Parse(yValue2);

            c2 = double.Parse(sides2[1]);

            double[,] A =
            {
        { x1, y1 },
        { x2, y2 }
    };
            // Display for Coe
            lblA11.Text = A[0, 0].ToString();
            lblA12.Text = A[0, 1].ToString();
            lblA21.Text = A[1, 0].ToString();
            lblA22.Text = A[1, 1].ToString();

            //Display for Constants
            lblB11.Text = c1.ToString();
            lblB21.Text = c2.ToString();
        }

        private void DisplayDeterminant()
        {
            // DETERMINANT OF A
            double first = x1 * y2;
            double second = y1 * x2;

            determinant = first - second;

            // DISPLAY DETERMINANT
            lblDet.Text =
                $"det(A) = ({x1})({y2}) - ({y1})({x2})\n" +
                $"             = {first} - ({second})\n" +
                $"             = {determinant}";
        }

        private void DisplayCofactorMatrix()
        {
            // COFACTOR VALUES
            C11 = y2;
            C12 = -x2;
            C21 = -y1;
            C22 = x1;

            // DISPLAY MINOR VALUES
            lblC11.Text = y2.ToString();
            lblC12.Text = x2.ToString();
            lblC21.Text = y1.ToString();
            lblC22.Text = x1.ToString();

            // DISPLAY FINAL COFACTORS
            lblCof11.Text = C11.ToString();
            lblCof12.Text = C12.ToString();
            lblCof21.Text = C21.ToString();
            lblCof22.Text = C22.ToString();

            // DISPLAY IN BRACKET
            lblCofMat11.Text = C11.ToString();
            lblCofMat12.Text = C12.ToString();
            lblCofMat21.Text = C21.ToString();
            lblCofMat22.Text = C22.ToString();
        }

        private void DisplayAdjointMatrix()
        {
            double A11 = C11;
            double A12 = C21;
            double A21 = C12;
            double A22 = C22;

            lblAdj11.Text = A11.ToString();
            lblAdj12.Text = A12.ToString();
            lblAdj21.Text = A21.ToString();
            lblAdj22.Text = A22.ToString();
        }
        private void DisplayInverseMatrix()
        {

            double I11 = C11;
            double I12 = C21;
            double I21 = C12;
            double I22 = C22;

            //placeholder for inverse matrix display
            lblDetA.Text = determinant.ToString();
            lblDetA1.Text = determinant.ToString();
            lblInvC11.Text = I11.ToString();
            lblInvC12.Text = I12.ToString();
            lblInvC21.Text = I21.ToString();
            lblInvC22.Text = I22.ToString();

            n11 = C11;
            n12 = C21;
            n21 = C12;
            n22 = C22;

            double denominator = determinant;

            // MAKE DENOMINATOR POSITIVE
            if (denominator < 0)
            {
                n11 = -n11;
                n12 = -n12;
                n21 = -n21;
                n22 = -n22;

                denominator = -denominator;
            }
            lblInv11.Text = $"{n11}/{denominator}";
            lblInv12.Text = $"{n12}/{denominator}";
            lblInv21.Text = $"{n21}/{denominator}";
            lblInv22.Text = $"{n22}/{denominator}";
        }

        private void DisplayComputeX()
        {
            //DISPLAY SOLVED VALS
            lblInvMat11.Text = lblInv11.Text;
            lblInvMat12.Text = lblInv12.Text;
            lblInvMat21.Text = lblInv21.Text;
            lblInvMat22.Text = lblInv22.Text;

            lblCon11.Text = c1.ToString();
            lblCon21.Text = c2.ToString();

            // GET NUMERIC INVERSE VALUES
            double i11 = C11 / determinant;
            double i12 = C21 / determinant;
            double i21 = C12 / determinant;
            double i22 = C22 / determinant;

            // ROW × COLUMN MULTIPLICATION
            double X11 = i11 * c1;
            double X12 = i12 * c2;
            double X21 = i21 * c1;
            double X22 = i22 * c2;

            double den = determinant;

            if (den < 0)
                den = -den;

            lblX11.Text = den == 1 ? X11.ToString() : $"{Math.Round(X11 * den, 8)}/{den}";
            lblX12.Text = den == 1 ? X12.ToString() : $"{Math.Round(X12 * den, 8)}/{den}";
            lblX21.Text = den == 1 ? X21.ToString() : $"{Math.Round(X21 * den, 8)}/{den}";
            lblX22.Text = den == 1 ? X22.ToString() : $"{Math.Round(X22 * den, 8)}/{den}";

            // ADD EACH ROW
            double resultX = X11 + X12;
            double resultY = X21 + X22;

            den = Math.Abs(determinant);

           // DISPLAY UNSIMPLIFIED X
if (den == 1)
    lblX1.Text = resultX.ToString();
else
    lblX1.Text = $"{Math.Round(resultX * den, 8)}/{den}";

// DISPLAY UNSIMPLIFIED Y
if (den == 1)
    lblX2.Text = resultY.ToString();
else
    lblX2.Text = $"{Math.Round(resultY * den, 8)}/{den}";

            // SIMPLIFY FINAL X
            if (resultX % 1 == 0)
                SolX.Text = resultX.ToString();
            else
                SolX.Text = resultX.ToString("0.####");

            // SIMPLIFY FINAL Y
            if (resultY % 1 == 0)
                SolY.Text = resultY.ToString();
            else
                SolY.Text = resultY.ToString("0.####");
        }

        private void DisplaySolution()
        {
            SolSys.Text = $"x = {SolX.Text}     y = {SolY.Text}";
        }

        private void SaveHistory()
        {
            using (SqliteConnection connection = new SqliteConnection(
                @"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                using (SqliteTransaction transaction = connection.BeginTransaction())
                {
                    // SAVE EQUATIONS TO HISTORY
                    string query = @"INSERT INTO History
                             (Equation1, Equation2, MatrixSize)
                             VALUES (@eq1, @eq2, 2)";

                    using (SqliteCommand command = new SqliteCommand(query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@eq1", equation1);
                        command.Parameters.AddWithValue("@eq2", equation2);

                        command.ExecuteNonQuery();
                    }

                    // CLEAR CURRENT EQUATIONS
                    query = @"UPDATE CurrentEquation
                      SET Equation1 = NULL,
                          Equation2 = NULL,
                          Equation3 = NULL";

                    using (SqliteCommand command = new SqliteCommand(query, connection, transaction))
                    {
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
        }
    }
}
