namespace sample_winforms
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            progressToolStripMenuItem = new ToolStripMenuItem();
            progress1ToolStripMenuItem = new ToolStripMenuItem();
            progress2WithObjectToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { progressToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(964, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // progressToolStripMenuItem
            // 
            progressToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { progress1ToolStripMenuItem, progress2WithObjectToolStripMenuItem });
            progressToolStripMenuItem.Name = "progressToolStripMenuItem";
            progressToolStripMenuItem.Size = new Size(64, 20);
            progressToolStripMenuItem.Text = "Progress";
            // 
            // progress1ToolStripMenuItem
            // 
            progress1ToolStripMenuItem.Name = "progress1ToolStripMenuItem";
            progress1ToolStripMenuItem.Size = new Size(276, 22);
            progress1ToolStripMenuItem.Text = "Progress1 (Simple Threading Example)";
            progress1ToolStripMenuItem.Click += progress1ToolStripMenuItem_Click;
            // 
            // progress2WithObjectToolStripMenuItem
            // 
            progress2WithObjectToolStripMenuItem.Name = "progress2WithObjectToolStripMenuItem";
            progress2WithObjectToolStripMenuItem.Size = new Size(276, 22);
            progress2WithObjectToolStripMenuItem.Text = "Progress2 (With Object)";
            progress2WithObjectToolStripMenuItem.Click += progress2WithObjectToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 492);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sample Main";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem progressToolStripMenuItem;
        private ToolStripMenuItem progress1ToolStripMenuItem;
        private ToolStripMenuItem progress2WithObjectToolStripMenuItem;
    }
}
