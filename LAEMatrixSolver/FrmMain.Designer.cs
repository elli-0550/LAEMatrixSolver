namespace LAEMatrixSolver
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(40, 65, 98);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 65, 95);
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(125, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 41);
            label1.TabIndex = 1;
            label1.Text = "LAE Matrix Solver  l";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(40, 65, 95);
            pictureBox2.BackgroundImage = Properties.Resources.sigma;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(56, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 42);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(40, 65, 95);
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(426, 17);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 3;
            label2.Text = "Using Adjoint Method";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Location = new Point(400, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 42);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 94, 247);
            panel2.Location = new Point(56, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 10);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCyan;
            label3.Location = new Point(45, 463);
            label3.Name = "label3";
            label3.Size = new Size(573, 81);
            label3.TabIndex = 6;
            label3.Text = "LAE Matrix Solver  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCyan;
            label4.Location = new Point(56, 532);
            label4.Name = "label4";
            label4.Size = new Size(385, 50);
            label4.TabIndex = 7;
            label4.Text = "Using Adjoint Method";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(56, 657);
            label5.Name = "label5";
            label5.Size = new Size(445, 123);
            label5.TabIndex = 8;
            label5.Text = "Solve systems of linear algebraic\r\nequations and find the inverse\r\nmatrix using adjoint method\r\n";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightCyan;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(134, 861);
            button1.Name = "button1";
            button1.Size = new Size(217, 65);
            button1.TabIndex = 9;
            button1.Text = "▶  Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1055);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = Color.LightCyan;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAE Matrix Solver   ";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}