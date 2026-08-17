namespace process_communication
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnSend = new Button();
            txtIn = new TextBox();
            txtOut = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(txtIn);
            groupBox1.Location = new Point(5, 359);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 56);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(709, 22);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 24);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtIn
            // 
            txtIn.Location = new Point(8, 23);
            txtIn.Name = "txtIn";
            txtIn.Size = new Size(694, 21);
            txtIn.TabIndex = 0;
            // 
            // txtOut
            // 
            txtOut.BackColor = Color.Black;
            txtOut.ForeColor = Color.FromArgb(255, 255, 128);
            txtOut.Location = new Point(3, 3);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(793, 351);
            txtOut.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(txtOut);
            Controls.Add(groupBox1);
            Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIn;
        private Button btnSend;
        private TextBox txtOut;
    }
}
