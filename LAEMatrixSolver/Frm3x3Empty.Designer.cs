namespace LAEMatrixSolver.Properties
{
    partial class Frm3x3Empty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm3x3Empty));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel3 = new Panel();
            tblSol = new TableLayoutPanel();
            panel12 = new Panel();
            lblConstants = new Label();
            label21 = new Label();
            label22 = new Label();
            panel13 = new Panel();
            lblCompute = new Label();
            label23 = new Label();
            label24 = new Label();
            panel14 = new Panel();
            lblSolSys = new Label();
            label26 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            panel2 = new Panel();
            tblInv = new TableLayoutPanel();
            pnlCoe = new Panel();
            lblCoe = new Label();
            label12 = new Label();
            label10 = new Label();
            pnlDet = new Panel();
            lblDet = new Label();
            label13 = new Label();
            label14 = new Label();
            pnlCof = new Panel();
            lblCof = new Label();
            label15 = new Label();
            label16 = new Label();
            pnlAdj = new Panel();
            lblAdj = new Label();
            label17 = new Label();
            label18 = new Label();
            pnlInvRes = new Panel();
            lblInvRes = new Label();
            label19 = new Label();
            label20 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            pnlIn = new Panel();
            txtBoxEq3 = new TextBox();
            label11 = new Label();
            btnClr = new Button();
            btnSolve = new Button();
            label5 = new Label();
            txtBoxEq2 = new TextBox();
            txtBoxEq1 = new TextBox();
            label4 = new Label();
            rb3x3 = new RadioButton();
            rb2x2 = new RadioButton();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel3.SuspendLayout();
            tblSol.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            tblInv.SuspendLayout();
            pnlCoe.SuspendLayout();
            pnlDet.SuspendLayout();
            pnlCof.SuspendLayout();
            pnlAdj.SuspendLayout();
            pnlInvRes.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlIn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Location = new Point(347, 7);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 32);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(40, 65, 95);
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(375, 12);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 7;
            label2.Text = "Using Adjoint Method";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(40, 65, 95);
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(109, 5);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 6;
            label1.Text = "LAE Matrix Solver  ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(40, 65, 98);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1904, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(40, 65, 95);
            pictureBox2.BackgroundImage = Resources.sigma;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(49, 7);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 32);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel3
            // 
            panel3.Controls.Add(tblSol);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1136, 71);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 924);
            panel3.TabIndex = 3;
            // 
            // tblSol
            // 
            tblSol.ColumnCount = 1;
            tblSol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSol.Controls.Add(panel12, 0, 0);
            tblSol.Controls.Add(panel13, 0, 1);
            tblSol.Controls.Add(panel14, 0, 2);
            tblSol.Dock = DockStyle.Fill;
            tblSol.Location = new Point(0, 46);
            tblSol.Margin = new Padding(0);
            tblSol.Name = "tblSol";
            tblSol.RowCount = 3;
            tblSol.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblSol.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSol.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblSol.Size = new Size(765, 878);
            tblSol.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Azure;
            panel12.Controls.Add(lblConstants);
            panel12.Controls.Add(label21);
            panel12.Controls.Add(label22);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 2);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(759, 215);
            panel12.TabIndex = 0;
            // 
            // lblConstants
            // 
            lblConstants.BackColor = Color.LightCyan;
            lblConstants.Dock = DockStyle.Fill;
            lblConstants.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConstants.ForeColor = Color.FromArgb(40, 65, 95);
            lblConstants.Location = new Point(0, 41);
            lblConstants.Name = "lblConstants";
            lblConstants.Size = new Size(759, 174);
            lblConstants.TabIndex = 4;
            lblConstants.Text = "Enter your equations and click Solve\r\nto view the constants matrix";
            lblConstants.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(40, 65, 95);
            label21.Location = new Point(205, 9);
            label21.Name = "label21";
            label21.Size = new Size(20, 19);
            label21.TabIndex = 3;
            label21.Text = "B";
            // 
            // label22
            // 
            label22.Dock = DockStyle.Top;
            label22.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(40, 65, 95);
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(759, 41);
            label22.TabIndex = 2;
            label22.Text = "6. Constants Matrix";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Azure;
            panel13.Controls.Add(lblCompute);
            panel13.Controls.Add(label23);
            panel13.Controls.Add(label24);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(3, 221);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(759, 435);
            panel13.TabIndex = 1;
            // 
            // lblCompute
            // 
            lblCompute.BackColor = Color.LightCyan;
            lblCompute.Dock = DockStyle.Fill;
            lblCompute.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompute.ForeColor = Color.FromArgb(40, 65, 95);
            lblCompute.Location = new Point(0, 41);
            lblCompute.Name = "lblCompute";
            lblCompute.Size = new Size(759, 394);
            lblCompute.TabIndex = 4;
            lblCompute.Text = "Enter your equations and click Solve\r\nto view the computation of X";
            lblCompute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(40, 65, 95);
            label23.Location = new Point(126, 9);
            label23.Name = "label23";
            label23.Size = new Size(72, 19);
            label23.TabIndex = 3;
            label23.Text = "X = A⁻¹ B";
            // 
            // label24
            // 
            label24.Dock = DockStyle.Top;
            label24.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.FromArgb(40, 65, 95);
            label24.Location = new Point(0, 0);
            label24.Name = "label24";
            label24.Size = new Size(759, 41);
            label24.TabIndex = 2;
            label24.Text = "7. Compute ";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Azure;
            panel14.Controls.Add(lblSolSys);
            panel14.Controls.Add(label26);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(3, 660);
            panel14.Margin = new Padding(3, 2, 3, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(759, 216);
            panel14.TabIndex = 2;
            // 
            // lblSolSys
            // 
            lblSolSys.BackColor = Color.LightCyan;
            lblSolSys.Dock = DockStyle.Fill;
            lblSolSys.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSolSys.ForeColor = Color.FromArgb(40, 65, 95);
            lblSolSys.Location = new Point(0, 41);
            lblSolSys.Name = "lblSolSys";
            lblSolSys.Size = new Size(759, 175);
            lblSolSys.TabIndex = 3;
            lblSolSys.Text = "Enter your equations and click Solve\r\nto view the solution of the system";
            lblSolSys.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.Dock = DockStyle.Top;
            label26.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(40, 65, 95);
            label26.Location = new Point(0, 0);
            label26.Name = "label26";
            label26.Size = new Size(759, 41);
            label26.TabIndex = 2;
            label26.Text = "8. Solution of the System";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGreen;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(765, 46);
            panel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(338, 11);
            label9.Name = "label9";
            label9.Size = new Size(115, 25);
            label9.TabIndex = 3;
            label9.Text = "( X= A⁻¹B )\r\n";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Resources.axis;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 46);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(83, 7);
            label7.Name = "label7";
            label7.Size = new Size(245, 37);
            label7.TabIndex = 2;
            label7.Text = "Solution of the System\r\n\r\n";
            // 
            // panel2
            // 
            panel2.Controls.Add(tblInv);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 71);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1127, 924);
            panel2.TabIndex = 2;
            // 
            // tblInv
            // 
            tblInv.AutoSize = true;
            tblInv.ColumnCount = 2;
            tblInv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInv.Controls.Add(pnlCoe, 0, 0);
            tblInv.Controls.Add(pnlDet, 1, 0);
            tblInv.Controls.Add(pnlCof, 0, 1);
            tblInv.Controls.Add(pnlAdj, 1, 1);
            tblInv.Controls.Add(pnlInvRes, 1, 2);
            tblInv.Dock = DockStyle.Fill;
            tblInv.Location = new Point(0, 46);
            tblInv.Margin = new Padding(3, 2, 3, 2);
            tblInv.Name = "tblInv";
            tblInv.RowCount = 3;
            tblInv.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblInv.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tblInv.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblInv.Size = new Size(1127, 878);
            tblInv.TabIndex = 0;
            // 
            // pnlCoe
            // 
            pnlCoe.BackColor = Color.Azure;
            pnlCoe.Controls.Add(lblCoe);
            pnlCoe.Controls.Add(label12);
            pnlCoe.Controls.Add(label10);
            pnlCoe.Dock = DockStyle.Fill;
            pnlCoe.Location = new Point(3, 2);
            pnlCoe.Margin = new Padding(3, 2, 3, 2);
            pnlCoe.Name = "pnlCoe";
            pnlCoe.Size = new Size(557, 215);
            pnlCoe.TabIndex = 0;
            // 
            // lblCoe
            // 
            lblCoe.BackColor = Color.LightCyan;
            lblCoe.Dock = DockStyle.Fill;
            lblCoe.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoe.ForeColor = Color.FromArgb(40, 65, 95);
            lblCoe.Location = new Point(0, 41);
            lblCoe.Margin = new Padding(9, 8, 9, 8);
            lblCoe.Name = "lblCoe";
            lblCoe.Size = new Size(557, 174);
            lblCoe.TabIndex = 5;
            lblCoe.Text = "Enter your equations and click Solve\r\n to view the coefficient matrix.";
            lblCoe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(40, 65, 95);
            label12.Location = new Point(216, 9);
            label12.Name = "label12";
            label12.Size = new Size(20, 19);
            label12.TabIndex = 4;
            label12.Text = "A";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(40, 65, 95);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(557, 41);
            label10.TabIndex = 0;
            label10.Text = "1. Coefficient Matrix";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDet
            // 
            pnlDet.BackColor = Color.Azure;
            pnlDet.Controls.Add(lblDet);
            pnlDet.Controls.Add(label13);
            pnlDet.Controls.Add(label14);
            pnlDet.Dock = DockStyle.Fill;
            pnlDet.Location = new Point(566, 2);
            pnlDet.Margin = new Padding(3, 2, 3, 2);
            pnlDet.Name = "pnlDet";
            pnlDet.Size = new Size(558, 215);
            pnlDet.TabIndex = 1;
            // 
            // lblDet
            // 
            lblDet.BackColor = Color.LightCyan;
            lblDet.Dock = DockStyle.Fill;
            lblDet.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDet.ForeColor = Color.FromArgb(40, 65, 95);
            lblDet.Location = new Point(0, 41);
            lblDet.Margin = new Padding(9, 8, 9, 8);
            lblDet.Name = "lblDet";
            lblDet.Size = new Size(558, 174);
            lblDet.TabIndex = 4;
            lblDet.Text = "Enter your equations and click Solve\r\nto view the determinant";
            lblDet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(40, 65, 95);
            label13.Location = new Point(186, 9);
            label13.Name = "label13";
            label13.Size = new Size(20, 19);
            label13.TabIndex = 3;
            label13.Text = "A";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(40, 65, 95);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(558, 41);
            label14.TabIndex = 2;
            label14.Text = "2. Determinant of ";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCof
            // 
            pnlCof.BackColor = Color.Azure;
            pnlCof.Controls.Add(lblCof);
            pnlCof.Controls.Add(label15);
            pnlCof.Controls.Add(label16);
            pnlCof.Dock = DockStyle.Fill;
            pnlCof.Location = new Point(3, 221);
            pnlCof.Margin = new Padding(3, 2, 3, 2);
            pnlCof.Name = "pnlCof";
            tblInv.SetRowSpan(pnlCof, 2);
            pnlCof.Size = new Size(557, 655);
            pnlCof.TabIndex = 2;
            // 
            // lblCof
            // 
            lblCof.BackColor = Color.LightCyan;
            lblCof.Dock = DockStyle.Fill;
            lblCof.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCof.ForeColor = Color.FromArgb(40, 65, 95);
            lblCof.Location = new Point(0, 41);
            lblCof.Margin = new Padding(9, 8, 9, 8);
            lblCof.Name = "lblCof";
            lblCof.Size = new Size(557, 614);
            lblCof.TabIndex = 4;
            lblCof.Text = "Enter your equations and click Solve\r\nto view the cofactor matrix\r\n";
            lblCof.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(40, 65, 95);
            label15.Location = new Point(192, 10);
            label15.Name = "label15";
            label15.Size = new Size(20, 19);
            label15.TabIndex = 3;
            label15.Text = "C";
            // 
            // label16
            // 
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(40, 65, 95);
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(557, 41);
            label16.TabIndex = 2;
            label16.Text = "3. Cofactor Matrix";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlAdj
            // 
            pnlAdj.BackColor = Color.Azure;
            pnlAdj.Controls.Add(lblAdj);
            pnlAdj.Controls.Add(label17);
            pnlAdj.Controls.Add(label18);
            pnlAdj.Dock = DockStyle.Fill;
            pnlAdj.Location = new Point(566, 221);
            pnlAdj.Margin = new Padding(3, 2, 3, 2);
            pnlAdj.Name = "pnlAdj";
            pnlAdj.Size = new Size(558, 303);
            pnlAdj.TabIndex = 3;
            // 
            // lblAdj
            // 
            lblAdj.BackColor = Color.LightCyan;
            lblAdj.Dock = DockStyle.Fill;
            lblAdj.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdj.ForeColor = Color.FromArgb(40, 65, 95);
            lblAdj.Location = new Point(0, 41);
            lblAdj.Margin = new Padding(9, 8, 9, 8);
            lblAdj.Name = "lblAdj";
            lblAdj.Size = new Size(558, 262);
            lblAdj.TabIndex = 4;
            lblAdj.Text = "Enter your equations and click Solve\r\nto view the adjoint matrix\r\n";
            lblAdj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(40, 65, 95);
            label17.Location = new Point(175, 8);
            label17.Name = "label17";
            label17.Size = new Size(86, 25);
            label17.TabIndex = 3;
            label17.Text = "(adj(A))";
            // 
            // label18
            // 
            label18.Dock = DockStyle.Top;
            label18.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(40, 65, 95);
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(558, 41);
            label18.TabIndex = 2;
            label18.Text = "4. Adjoint Matrix";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlInvRes
            // 
            pnlInvRes.BackColor = Color.Azure;
            pnlInvRes.Controls.Add(lblInvRes);
            pnlInvRes.Controls.Add(label19);
            pnlInvRes.Controls.Add(label20);
            pnlInvRes.Dock = DockStyle.Fill;
            pnlInvRes.Location = new Point(566, 528);
            pnlInvRes.Margin = new Padding(3, 2, 3, 2);
            pnlInvRes.Name = "pnlInvRes";
            pnlInvRes.Size = new Size(558, 348);
            pnlInvRes.TabIndex = 4;
            // 
            // lblInvRes
            // 
            lblInvRes.BackColor = Color.LightCyan;
            lblInvRes.Dock = DockStyle.Fill;
            lblInvRes.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvRes.ForeColor = Color.FromArgb(40, 65, 95);
            lblInvRes.Location = new Point(0, 41);
            lblInvRes.Margin = new Padding(9, 8, 9, 8);
            lblInvRes.Name = "lblInvRes";
            lblInvRes.Size = new Size(558, 307);
            lblInvRes.TabIndex = 4;
            lblInvRes.Text = "Enter your equations and click Solve\r\nto view the inverse matrix";
            lblInvRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(40, 65, 95);
            label19.Location = new Point(179, 10);
            label19.Name = "label19";
            label19.Size = new Size(57, 19);
            label19.TabIndex = 3;
            label19.Text = "A⁻¹ \r\n";
            // 
            // label20
            // 
            label20.Dock = DockStyle.Top;
            label20.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(40, 65, 95);
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(558, 41);
            label20.TabIndex = 2;
            label20.Text = "5. Inverse Matrix";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1127, 46);
            panel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(40, 65, 95);
            label6.Location = new Point(82, 5);
            label6.Name = "label6";
            label6.Size = new Size(168, 38);
            label6.TabIndex = 1;
            label6.Text = "Inverse Matrix \r\n\r\n";
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(40, 65, 95);
            label8.Location = new Point(256, 10);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 2;
            label8.Text = "( A⁻¹ )\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Resources.matrix;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 46);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pnlIn
            // 
            pnlIn.BackColor = Color.Azure;
            tableLayoutPanel1.SetColumnSpan(pnlIn, 2);
            pnlIn.Controls.Add(txtBoxEq3);
            pnlIn.Controls.Add(label11);
            pnlIn.Controls.Add(btnClr);
            pnlIn.Controls.Add(btnSolve);
            pnlIn.Controls.Add(label5);
            pnlIn.Controls.Add(txtBoxEq2);
            pnlIn.Controls.Add(txtBoxEq1);
            pnlIn.Controls.Add(label4);
            pnlIn.Controls.Add(rb3x3);
            pnlIn.Controls.Add(rb2x2);
            pnlIn.Controls.Add(label3);
            pnlIn.Dock = DockStyle.Fill;
            pnlIn.Location = new Point(3, 2);
            pnlIn.Margin = new Padding(3, 2, 3, 2);
            pnlIn.Name = "pnlIn";
            pnlIn.Size = new Size(1898, 65);
            pnlIn.TabIndex = 0;
            // 
            // txtBoxEq3
            // 
            txtBoxEq3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEq3.Location = new Point(1116, 16);
            txtBoxEq3.Name = "txtBoxEq3";
            txtBoxEq3.Size = new Size(167, 33);
            txtBoxEq3.TabIndex = 11;
            txtBoxEq3.Leave += txtBoxEq3_Leave;
            // 
            // label11
            // 
            label11.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(1001, 19);
            label11.Name = "label11";
            label11.Size = new Size(109, 26);
            label11.TabIndex = 10;
            label11.Text = "Equation 3:";
            // 
            // btnClr
            // 
            btnClr.Anchor = AnchorStyles.Top;
            btnClr.BackColor = Color.Azure;
            btnClr.FlatStyle = FlatStyle.Flat;
            btnClr.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClr.Location = new Point(1599, 14);
            btnClr.Margin = new Padding(3, 2, 3, 2);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(248, 35);
            btnClr.TabIndex = 9;
            btnClr.Text = "\t↻ Clear";
            btnClr.UseVisualStyleBackColor = false;
            btnClr.Click += btnClr_Click;
            // 
            // btnSolve
            // 
            btnSolve.Anchor = AnchorStyles.Top;
            btnSolve.BackColor = Color.FromArgb(8, 102, 233);
            btnSolve.FlatStyle = FlatStyle.Flat;
            btnSolve.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolve.ForeColor = Color.White;
            btnSolve.Location = new Point(1328, 15);
            btnSolve.Margin = new Padding(3, 2, 3, 2);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(248, 35);
            btnSolve.TabIndex = 8;
            btnSolve.Text = "▶  Solve";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(676, 19);
            label5.Name = "label5";
            label5.Size = new Size(109, 26);
            label5.TabIndex = 6;
            label5.Text = "Equation 2:";
            // 
            // txtBoxEq2
            // 
            txtBoxEq2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEq2.Location = new Point(802, 15);
            txtBoxEq2.Margin = new Padding(3, 2, 3, 2);
            txtBoxEq2.Name = "txtBoxEq2";
            txtBoxEq2.Size = new Size(167, 33);
            txtBoxEq2.TabIndex = 5;
            txtBoxEq2.Leave += txtBoxEq2_Leave;
            // 
            // txtBoxEq1
            // 
            txtBoxEq1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEq1.Location = new Point(484, 17);
            txtBoxEq1.Margin = new Padding(3, 2, 3, 2);
            txtBoxEq1.Name = "txtBoxEq1";
            txtBoxEq1.Size = new Size(165, 33);
            txtBoxEq1.TabIndex = 4;
            txtBoxEq1.Leave += txtBoxEq1_Leave;
            // 
            // label4
            // 
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(354, 21);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 3;
            label4.Text = "Equation 1:";
            // 
            // rb3x3
            // 
            rb3x3.Checked = true;
            rb3x3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb3x3.Location = new Point(277, 23);
            rb3x3.Margin = new Padding(3, 2, 3, 2);
            rb3x3.Name = "rb3x3";
            rb3x3.Size = new Size(67, 28);
            rb3x3.TabIndex = 2;
            rb3x3.TabStop = true;
            rb3x3.Text = "3 x 3";
            rb3x3.UseVisualStyleBackColor = true;
            // 
            // rb2x2
            // 
            rb2x2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb2x2.Location = new Point(204, 22);
            rb2x2.Margin = new Padding(3, 2, 3, 2);
            rb2x2.Name = "rb2x2";
            rb2x2.Size = new Size(76, 30);
            rb2x2.TabIndex = 1;
            rb2x2.Text = "2 x 2";
            rb2x2.UseVisualStyleBackColor = true;
            rb2x2.CheckedChanged += rb2x2_CheckedChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 19);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 0;
            label3.Text = "Matrix Size:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.52381F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.47619F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(pnlIn, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 44);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93F));
            tableLayoutPanel1.Size = new Size(1904, 997);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // Frm3x3Empty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm3x3Empty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAE Matrix Solver";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel3.ResumeLayout(false);
            tblSol.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tblInv.ResumeLayout(false);
            pnlCoe.ResumeLayout(false);
            pnlDet.ResumeLayout(false);
            pnlCof.ResumeLayout(false);
            pnlAdj.ResumeLayout(false);
            pnlInvRes.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlIn.ResumeLayout(false);
            pnlIn.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FileSystemWatcher fileSystemWatcher1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlIn;
        private Button btnClr;
        private Button btnSolve;
        private Label label5;
        private TextBox txtBoxEq2;
        private TextBox txtBoxEq1;
        private Label label4;
        private RadioButton rb3x3;
        private RadioButton rb2x2;
        private Label label3;
        private Panel panel2;
        private TableLayoutPanel tblInv;
        private Panel pnlCoe;
        private Label lblCoe;
        private Label label12;
        private Label label10;
        private Panel pnlDet;
        private Label lblDet;
        private Label label13;
        private Label label14;
        private Panel pnlCof;
        private Label lblCof;
        private Label label15;
        private Label label16;
        private Panel pnlAdj;
        private Label lblAdj;
        private Label label17;
        private Label label18;
        private Panel pnlInvRes;
        private Label lblInvRes;
        private Label label19;
        private Label label20;
        private Panel panel4;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel3;
        private TableLayoutPanel tblSol;
        private Panel panel12;
        private Label lblConstants;
        private Label label21;
        private Label label22;
        private Panel panel13;
        private Label lblCompute;
        private Label label23;
        private Label label24;
        private Panel panel14;
        private Label lblSolSys;
        private Label label26;
        private Panel panel5;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label11;
        private TextBox txtBoxEq3;
    }
}