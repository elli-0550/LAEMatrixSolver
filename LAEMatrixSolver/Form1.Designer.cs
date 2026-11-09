namespace LAEMatrixSolver
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            label2 = new Label();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            lblPercent = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 444);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 41);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Nirmala UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(223, 241, 255);
            label1.Location = new Point(85, 46);
            label1.Name = "label1";
            label1.Size = new Size(437, 79);
            label1.TabIndex = 1;
            label1.Text = "LAE Matrix Solver";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.MediumTurquoise;
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.MediumTurquoise;
            progressBar1.Location = new Point(0, 200);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(610, 17);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.BackColor = Color.Transparent;
            lblPercent.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercent.ForeColor = Color.FromArgb(223, 241, 255);
            lblPercent.Location = new Point(270, 135);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(88, 21);
            lblPercent.TabIndex = 3;
            lblPercent.Text = "Loading....";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 46, 80);
            ClientSize = new Size(610, 217);
            Controls.Add(lblPercent);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.MintCream;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 8, 4, 8);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAE SOLVER";
            TransparencyKey = Color.MintCream;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private Label lblPercent;
        private System.Windows.Forms.Timer timer1;
    }
}
