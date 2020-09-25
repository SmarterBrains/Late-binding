namespace Late_binding
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLabToolStripMenuItem,
            this.startLabToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addLabToolStripMenuItem
            // 
            this.addLabToolStripMenuItem.Name = "addLabToolStripMenuItem";
            this.addLabToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.addLabToolStripMenuItem.Text = "Add Lab";
            // 
            // startLabToolStripMenuItem
            // 
            this.startLabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halfWaveToolStripMenuItem});
            this.startLabToolStripMenuItem.Name = "startLabToolStripMenuItem";
            this.startLabToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.startLabToolStripMenuItem.Text = "Start Lab";
            // 
            // halfWaveToolStripMenuItem
            // 
            this.halfWaveToolStripMenuItem.Name = "halfWaveToolStripMenuItem";
            this.halfWaveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.halfWaveToolStripMenuItem.Text = "Half wave";
            this.halfWaveToolStripMenuItem.Click += new System.EventHandler(this.halfWaveToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfWaveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

