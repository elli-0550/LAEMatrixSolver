using LAEMatrixSolver.Properties;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAEMatrixSolver
{
    public partial class Frm3x3Solved : Form

    {
        string equation1;
        string equation2;
        string equation3;

        double x1, y1, z1;
        double x2, y2, z2;
        double x3, y3, z3;

        double c1, c2, c3;
        double determinant;
        double C11, C12, C13;
        double C21, C22, C23;
        double C31, C32, C33;
        public Frm3x3Solved()
        {
            InitializeComponent();
            //2x + 3y - z = 5
            //7x + y + 2z = 3  
            //2x + 4y + 5z = 4
            equation1 = "";
            equation2 = "";
            equation3 = "";

            using (SqliteConnection connection = new SqliteConnection(@"Data Source=C:\ProgramData\LAEMatrixSolver\LAEMatrixSolver.db"))
            {
                connection.Open();

                string query = "SELECT Equation1, Equation2, Equation3 FROM CurrentEquation";

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
            DisplayCoefficientMatrix();
            DisplayDeterminant();

            // CHECK DETERMINANT
            if (determinant != 0)
            {
                DisplayCofactorMatrix();
                DisplayAdjointMatrix();
                DisplayInverseMatrix();
                DisplaySolutionSystem();
            }
        }

        private void DisplaySolutionSystem()
        {
            // STEP 6: DISPLAY CONSTANTS MATRIX B
            label181.Text = c1.ToString();
            label180.Text = c2.ToString();
            label179.Text = c3.ToString();

            // STEP 7: DISPLAY INVERSE MATRIX VALUES
            label173.Text = SimplifyFraction(C11, determinant);
            label172.Text = SimplifyFraction(C21, determinant);
            label108.Text = SimplifyFraction(C31, determinant);

            label170.Text = SimplifyFraction(C12, determinant);
            label175.Text = SimplifyFraction(C22, determinant);
            label107.Text = SimplifyFraction(C32, determinant);

            label174.Text = SimplifyFraction(C13, determinant);
            label171.Text = SimplifyFraction(C23, determinant);
            label103.Text = SimplifyFraction(C33, determinant);


            // ROW 1 CALCULATIONS
            label186.Text = SimplifyFraction(C11 * c1, determinant);
            label185.Text = SimplifyFraction(C21 * c2, determinant);
            label118.Text = SimplifyFraction(C31 * c3, determinant);

            // ROW 2 CALCULATIONS
            label178.Text = SimplifyFraction(C12 * c1, determinant);
            label188.Text = SimplifyFraction(C22 * c2, determinant);
            label117.Text = SimplifyFraction(C32 * c3, determinant);

            // ROW 3 CALCULATIONS
            label187.Text = SimplifyFraction(C13 * c1, determinant);
            label184.Text = SimplifyFraction(C23 * c2, determinant);
            label102.Text = SimplifyFraction(C33 * c3, determinant);

            // STEP 7: CALCULATE SOLUTION MATRIX X
            double resultX = (C11 * c1) + (C21 * c2) + (C31 * c3);
            double resultY = (C12 * c1) + (C22 * c2) + (C32 * c3);
            double resultZ = (C13 * c1) + (C23 * c2) + (C33 * c3);


            // DISPLAY SOLUTION MATRIX
            lblX1.Text = SimplifyFraction(resultX, determinant);
            lblX2.Text = SimplifyFraction(resultY, determinant);
            label215.Text = SimplifyFraction(resultZ, determinant);


            // STEP 8: DISPLAY FINAL ANSWERS
            label216.Text = SimplifyFraction(resultX, determinant);
            label129.Text = SimplifyFraction(resultY, determinant);
            label128.Text = SimplifyFraction(resultZ, determinant);

            //STEP 9: DISPLAY FINAL ANSWERS IN FRACTION FORM
            label166.Text = SimplifyFraction(resultX, determinant);
            label167.Text = SimplifyFraction(resultY, determinant);
            label168.Text = SimplifyFraction(resultZ, determinant);
        }
        private void DisplayInverseMatrix()
        {
            // DISPLAY ADJOINT MATRIX
            label154.Text = C11.ToString();
            label155.Text = C21.ToString();
            label148.Text = C31.ToString();

            label156.Text = C12.ToString();
            label153.Text = C22.ToString();
            label89.Text = C32.ToString();

            label151.Text = C13.ToString();
            label149.Text = C23.ToString();
            label88.Text = C33.ToString();

            // DISPLAY SIMPLIFIED FRACTIONS
            label162.Text = SimplifyFraction(C11, determinant);
            label163.Text = SimplifyFraction(C21, determinant);
            label157.Text = SimplifyFraction(C31, determinant);

            label164.Text = SimplifyFraction(C12, determinant);
            label161.Text = SimplifyFraction(C22, determinant);
            label95.Text = SimplifyFraction(C32, determinant);

            label160.Text = SimplifyFraction(C13, determinant);
            label158.Text = SimplifyFraction(C23, determinant);
            label94.Text = SimplifyFraction(C33, determinant);
        }
        private string SimplifyFraction(double numerator, double denominator)
        {
            int num = (int)numerator;
            int den = (int)denominator;

            int a = Math.Abs(num);
            int b = Math.Abs(den);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            num /= a;
            den /= a;

            if (den < 0)
            {
                num = -num;
                den = -den;
            }

            if (den == 1)
                return num.ToString();

            return $"{num}/{den}";
        }

        private void DisplayAdjointMatrix()
        {
            // TRANSPOSE COFACTOR MATRIX

            label145.Text = C11.ToString();
            label143.Text = C21.ToString();
            label139.Text = C31.ToString();

            label144.Text = C12.ToString();
            label142.Text = C22.ToString();
            label75.Text = C32.ToString();

            label141.Text = C13.ToString();
            label140.Text = C23.ToString();
            label74.Text = C33.ToString();
        }

        private void DisplayCofactorMatrix()
        {
            // MINOR CALCULATIONS
            double M11 = (y2 * z3) - (z2 * y3);
            double M12 = (x2 * z3) - (z2 * x3);
            double M13 = (x2 * y3) - (y2 * x3);

            double M21 = (y1 * z3) - (z1 * y3);
            double M22 = (x1 * z3) - (z1 * x3);
            double M23 = (x1 * y3) - (y1 * x3);

            double M31 = (y1 * z2) - (z1 * y2);
            double M32 = (x1 * z2) - (z1 * x2);
            double M33 = (x1 * y2) - (y1 * x2);


            // COFACTOR VALUES
            C11 = M11;
            C12 = -M12;
            C13 = M13;

            C21 = -M21;
            C22 = M22;
            C23 = -M23;

            C31 = M31;
            C32 = -M32;
            C33 = M33;


            // DISPLAY MINOR VALUES
            lblC11.Text = M11.ToString();
            lblC12.Text = M12.ToString();
            label69.Text = M13.ToString();

            label100.Text = M21.ToString();
            label87.Text = M22.ToString();
            label60.Text = M23.ToString();

            label136.Text = M31.ToString();
            label127.Text = M32.ToString();
            label113.Text = M33.ToString();


            // DISPLAY FINAL COFACTORS
            lblCof11.Text = C11.ToString();
            lblCof12.Text = C12.ToString();
            label66.Text = C13.ToString();

            label92.Text = C21.ToString();
            label82.Text = C22.ToString();
            label42.Text = C23.ToString();

            label132.Text = C31.ToString();
            label116.Text = C32.ToString();
            label106.Text = C33.ToString();


            // DISPLAY FINAL COFACTOR MATRIX
            label62.Text = C11.ToString();
            label61.Text = C12.ToString();
            label51.Text = C13.ToString();

            label58.Text = C21.ToString();
            label54.Text = C22.ToString();
            label47.Text = C23.ToString();

            label44.Text = C31.ToString();
            label40.Text = C32.ToString();
            label37.Text = C33.ToString();
        }

        private void DisplayDeterminant()
        {
            // POSITIVE DIAGONALS
            double first = x1 * y2 * z3;
            double second = x2 * y3 * z1;
            double third = x3 * y1 * z2;

            // NEGATIVE DIAGONALS
            double fourth = x3 * y2 * z1;
            double fifth = x1 * y3 * z2;
            double sixth = x2 * y1 * z3;

            // CALCULATE BOTH SIDES
            double positive = first + second + third;
            double negative = fourth + fifth + sixth;

            // FINAL DETERMINANT
            determinant = positive - negative;
            // DISPLAY DETERMINANT
            lblDet.Text =
                $"det(A) = ({x1})({y2})({z3}) + ({y1})({z2})({x3}) + ({z1})({x2})({y3})\n" +
                $"             - [({x3})({y2})({z1}) + ({y3})({z2})({x1}) + ({z3})({x2})({y1})]\n" +
                $"                         = {positive} - ({negative})\n" +
                $"                              = {determinant}";
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

        private void DisplayCoefficientMatrix()
        {
            // EQUATION 1
            string[] sides1 = equation1.Replace(" ", "").Split('=');
            string[] terms1 = sides1[0].Replace("-", "+-")
                .Split('+', StringSplitOptions.RemoveEmptyEntries);

            string xVal1 = terms1[0].Replace("x", "").Trim();
            string yVal1 = terms1[1].Replace("y", "").Trim();
            string zVal1 = terms1[2].Replace("z", "").Trim();

            // For empty string, x, -x
            if (xVal1 == "")
                x1 = 1;
            else if (xVal1 == "-")
                x1 = -1;
            else
                x1 = double.Parse(xVal1);

            if (yVal1 == "")
                y1 = 1;
            else if (yVal1 == "-")
                y1 = -1;
            else
                y1 = double.Parse(yVal1);

            if (zVal1 == "")
                z1 = 1;
            else if (zVal1 == "-")
                z1 = -1;
            else
                z1 = double.Parse(zVal1);

            c1 = double.Parse(sides1[1]);


            // EQUATION 2
            string[] sides2 = equation2.Replace(" ", "").Split('=');
            string[] terms2 = sides2[0].Replace("-", "+-")
                .Split('+', StringSplitOptions.RemoveEmptyEntries);

            string xVal2 = terms2[0].Replace("x", "").Trim();
            string yVal2 = terms2[1].Replace("y", "").Trim();
            string zVal2 = terms2[2].Replace("z", "").Trim();

            if (xVal2 == "")
                x2 = 1;
            else if (xVal2 == "-")
                x2 = -1;
            else
                x2 = double.Parse(xVal2);

            if (yVal2 == "")
                y2 = 1;
            else if (yVal2 == "-")
                y2 = -1;
            else
                y2 = double.Parse(yVal2);

            if (zVal2 == "")
                z2 = 1;
            else if (zVal2 == "-")
                z2 = -1;
            else
                z2 = double.Parse(zVal2);

            c2 = double.Parse(sides2[1]);


            // EQUATION 3
            string[] sides3 = equation3.Replace(" ", "").Split('=');
            string[] terms3 = sides3[0].Replace("-", "+-")
                .Split('+', StringSplitOptions.RemoveEmptyEntries);

            string xVal3 = terms3[0].Replace("x", "").Trim();
            string yVal3 = terms3[1].Replace("y", "").Trim();
            string zVal3 = terms3[2].Replace("z", "").Trim();

            if (xVal3 == "")
                x3 = 1;
            else if (xVal3 == "-")
                x3 = -1;
            else
                x3 = double.Parse(xVal3);

            if (yVal3 == "")
                y3 = 1;
            else if (yVal3 == "-")
                y3 = -1;
            else
                y3 = double.Parse(yVal3);

            if (zVal3 == "")
                z3 = 1;
            else if (zVal3 == "-")
                z3 = -1;
            else
                z3 = double.Parse(zVal3);

            c3 = double.Parse(sides3[1]);


            // DISPLAY COEFFICIENT MATRIX A
            lblA11.Text = x1.ToString();
            lblA12.Text = y1.ToString();
            lblA13.Text = z1.ToString();

            lblA21.Text = x2.ToString();
            lblA22.Text = y2.ToString();
            lblA23.Text = z2.ToString();

            lblA31.Text = x3.ToString();
            lblA32.Text = y3.ToString();
            lblA33.Text = z3.ToString();


            // DISPLAY CONSTANTS MATRIX B
            lblB11.Text = c1.ToString();
            lblB21.Text = c2.ToString();
            label169.Text = c3.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {//clear
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

            // CLEAR COEFFICIENT MATRIX AND DETERMINANT
            lblA11.Text = "";
            lblA12.Text = "";
            lblA13.Text = "";
            lblA21.Text = "";
            lblA22.Text = "";
            lblA23.Text = "";
            lblA31.Text = "";
            lblA32.Text = "";
            lblA33.Text = "";

            lblB11.Text = "";
            lblB21.Text = "";
            label169.Text = "";
            lblDet.Text = "";

            // CLEAR MINOR VALUES
            lblC11.Text = "";
            lblC12.Text = "";
            label69.Text = "";
            label100.Text = "";
            label87.Text = "";
            label60.Text = "";
            label136.Text = "";
            label127.Text = "";
            label113.Text = "";

            // CLEAR COFACTOR VALUES
            lblCof11.Text = "";
            lblCof12.Text = "";
            label66.Text = "";
            label92.Text = "";
            label82.Text = "";
            label42.Text = "";
            label132.Text = "";
            label116.Text = "";
            label106.Text = "";

            // CLEAR COFACTOR MATRIX
            label62.Text = "";
            label61.Text = "";
            label51.Text = "";
            label58.Text = "";
            label54.Text = "";
            label47.Text = "";
            label44.Text = "";
            label40.Text = "";
            label37.Text = "";

            // CLEAR ADJOINT MATRIX
            label145.Text = "";
            label143.Text = "";
            label139.Text = "";
            label144.Text = "";
            label142.Text = "";
            label75.Text = "";
            label141.Text = "";
            label140.Text = "";
            label74.Text = "";

            // CLEAR INVERSE MATRIX
            label154.Text = "";
            label155.Text = "";
            label148.Text = "";
            label156.Text = "";
            label153.Text = "";
            label89.Text = "";
            label151.Text = "";
            label149.Text = "";
            label88.Text = "";

            label162.Text = "";
            label163.Text = "";
            label157.Text = "";
            label164.Text = "";
            label161.Text = "";
            label95.Text = "";
            label160.Text = "";
            label158.Text = "";
            label94.Text = "";

            // CLEAR SOLUTION CALCULATIONS
            label181.Text = "";
            label180.Text = "";
            label179.Text = "";

            label173.Text = "";
            label172.Text = "";
            label108.Text = "";
            label170.Text = "";
            label175.Text = "";
            label107.Text = "";
            label174.Text = "";
            label171.Text = "";
            label103.Text = "";

            label186.Text = "";
            label185.Text = "";
            label118.Text = "";
            label178.Text = "";
            label188.Text = "";
            label117.Text = "";
            label187.Text = "";
            label184.Text = "";
            label102.Text = "";

            lblX1.Text = "";
            lblX2.Text = "";
            label215.Text = "";

            // CLEAR FINAL ANSWERS
            label216.Text = "";
            label129.Text = "";
            label128.Text = "";

            label166.Text = "";
            label167.Text = "";
            label168.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {//solve
            if (CheckEquation(txtBoxEq1.Text) == false ||
                CheckEquation(txtBoxEq2.Text) == false ||
                CheckEquation(txtBoxEq3.Text) == false)
            {
                return;
            }

            equation1 = txtBoxEq1.Text;
            equation2 = txtBoxEq2.Text;
            equation3 = txtBoxEq3.Text;

            DisplayCoefficientMatrix();
            DisplayDeterminant();

            // CHECK DETERMINANT
            if (determinant == 0)
            {
                MessageBox.Show(
                    "The determinant of the coefficient matrix is zero.\n\n" +
                    "Therefore, the inverse matrix does not exist, and " +
                    "the system cannot be solved using the Adjoint Method.",
                    "Cannot Solve System",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // EXECUTE ONLY IF DETERMINANT IS NOT ZERO
            DisplayCofactorMatrix();
            DisplayAdjointMatrix();
            DisplayInverseMatrix();
            DisplaySolutionSystem();
        }

        private void Frm3x3Solved_Load(object sender, EventArgs e)
        {

        }

        private void pnlCof_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
