namespace sample_winforms
{
    partial class frmProgress_Test2
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
            btnStart = new Button();
            groupBox1 = new GroupBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(20, 250);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Location = new Point(11, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 84);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(11, 38);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(813, 10);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(115, 250);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmProgress_Test2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 279);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnStart);
            Name = "frmProgress_Test2";
            Text = "Progress Bar Test";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnStart;
        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private Button button1;
    }
}
