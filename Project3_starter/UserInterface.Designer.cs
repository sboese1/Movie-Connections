namespace Project3_starter
{
    partial class UserInterface
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
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxFindMovies = new System.Windows.Forms.Button();
            this.uxFindPath = new System.Windows.Forms.Button();
            this.uxResultTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // uxFindMovies
            // 
            this.uxFindMovies.Location = new System.Drawing.Point(94, 300);
            this.uxFindMovies.Name = "uxFindMovies";
            this.uxFindMovies.Size = new System.Drawing.Size(200, 49);
            this.uxFindMovies.TabIndex = 3;
            this.uxFindMovies.Text = "Find Movies";
            this.uxFindMovies.UseVisualStyleBackColor = true;
            this.uxFindMovies.Click += new System.EventHandler(this.uxFindMovies_Click);
            // 
            // uxFindPath
            // 
            this.uxFindPath.Location = new System.Drawing.Point(494, 300);
            this.uxFindPath.Name = "uxFindPath";
            this.uxFindPath.Size = new System.Drawing.Size(208, 49);
            this.uxFindPath.TabIndex = 4;
            this.uxFindPath.Text = "Find Path";
            this.uxFindPath.UseVisualStyleBackColor = true;
            this.uxFindPath.Click += new System.EventHandler(this.uxFindPath_Click);
            // 
            // uxResultTextBox
            // 
            this.uxResultTextBox.Location = new System.Drawing.Point(14, 395);
            this.uxResultTextBox.Multiline = true;
            this.uxResultTextBox.Name = "uxResultTextBox";
            this.uxResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResultTextBox.Size = new System.Drawing.Size(775, 206);
            this.uxResultTextBox.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 184);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(414, 71);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(374, 184);
            this.listBox2.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uxResultTextBox);
            this.Controls.Add(this.uxFindPath);
            this.Controls.Add(this.uxFindMovies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button uxFindMovies;
        private System.Windows.Forms.Button uxFindPath;
        private System.Windows.Forms.TextBox uxResultTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

