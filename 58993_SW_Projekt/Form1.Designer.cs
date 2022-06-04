namespace _58993_SW_Projekt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytmMatematycznyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytmSortujacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorytmKompresujacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorytmMatematycznyToolStripMenuItem,
            this.algorytmSortujacyToolStripMenuItem,
            this.algorytmKompresujacyToolStripMenuItem});
            this.programToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // algorytmMatematycznyToolStripMenuItem
            // 
            this.algorytmMatematycznyToolStripMenuItem.Name = "algorytmMatematycznyToolStripMenuItem";
            this.algorytmMatematycznyToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.algorytmMatematycznyToolStripMenuItem.Text = "Algorytm matematyczny";
            this.algorytmMatematycznyToolStripMenuItem.Click += new System.EventHandler(this.algorytmMatematycznyToolStripMenuItem_Click);
            // 
            // algorytmSortujacyToolStripMenuItem
            // 
            this.algorytmSortujacyToolStripMenuItem.Name = "algorytmSortujacyToolStripMenuItem";
            this.algorytmSortujacyToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.algorytmSortujacyToolStripMenuItem.Text = "Algorytm sortujacy";
            this.algorytmSortujacyToolStripMenuItem.Click += new System.EventHandler(this.algorytmSortujacyToolStripMenuItem_Click);
            // 
            // algorytmKompresujacyToolStripMenuItem
            // 
            this.algorytmKompresujacyToolStripMenuItem.Name = "algorytmKompresujacyToolStripMenuItem";
            this.algorytmKompresujacyToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.algorytmKompresujacyToolStripMenuItem.Text = "Algorytm kompresujacy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 402);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 182);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Praca zaliczeniowa Sandry Wisniewskiej";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytmMatematycznyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytmSortujacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorytmKompresujacyToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
