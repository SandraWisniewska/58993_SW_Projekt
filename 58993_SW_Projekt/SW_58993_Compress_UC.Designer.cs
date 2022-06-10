namespace _58993_SW_Projekt
{
    partial class SW_58993_Compress_UC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="SW_58993_disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool SW_58993_disposing)
        {
            if (SW_58993_disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(SW_58993_disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SW_58993_label1 = new System.Windows.Forms.Label();
            this.SW_58993_textBox1 = new System.Windows.Forms.TextBox();
            this.SW_58993_label2 = new System.Windows.Forms.Label();
            this.SW_58993_button1 = new System.Windows.Forms.Button();
            this.SW_58993_label3 = new System.Windows.Forms.Label();
            this.SW_58993_textBox2 = new System.Windows.Forms.TextBox();
            this.SW_58993_label4 = new System.Windows.Forms.Label();
            this.SW_58993_textBox3 = new System.Windows.Forms.TextBox();
            this.SW_58993_label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.SW_58993_label1.AutoSize = true;
            this.SW_58993_label1.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_label1.Location = new System.Drawing.Point(18, 55);
            this.SW_58993_label1.Name = "SW_58993_label1";
            this.SW_58993_label1.Size = new System.Drawing.Size(295, 30);
            this.SW_58993_label1.TabIndex = 0;
            this.SW_58993_label1.Text = "Wpisz tekst do kompresji:";
            // 
            // textBox1
            // 
            this.SW_58993_textBox1.Location = new System.Drawing.Point(18, 97);
            this.SW_58993_textBox1.MaxLength = 300;
            this.SW_58993_textBox1.Multiline = true;
            this.SW_58993_textBox1.Name = "SW_58993_textBox1";
            this.SW_58993_textBox1.Size = new System.Drawing.Size(513, 99);
            this.SW_58993_textBox1.TabIndex = 1;
            this.SW_58993_textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.SW_58993_label2.AutoSize = true;
            this.SW_58993_label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_label2.Location = new System.Drawing.Point(18, 199);
            this.SW_58993_label2.Name = "SW_58993_label2";
            this.SW_58993_label2.Size = new System.Drawing.Size(153, 25);
            this.SW_58993_label2.TabIndex = 2;
            this.SW_58993_label2.Text = "Max. 300 znaków";
            // 
            // button1
            // 
            this.SW_58993_button1.Location = new System.Drawing.Point(18, 236);
            this.SW_58993_button1.Name = "SW_58993_button1";
            this.SW_58993_button1.Size = new System.Drawing.Size(153, 34);
            this.SW_58993_button1.TabIndex = 3;
            this.SW_58993_button1.Text = "KOMPRESUJ";
            this.SW_58993_button1.UseVisualStyleBackColor = true;
            this.SW_58993_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.SW_58993_label3.AutoSize = true;
            this.SW_58993_label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_label3.Location = new System.Drawing.Point(18, 434);
            this.SW_58993_label3.Name = "SW_58993_label3";
            this.SW_58993_label3.Size = new System.Drawing.Size(205, 30);
            this.SW_58993_label3.TabIndex = 4;
            this.SW_58993_label3.Text = "Wynik kompresji:";
            this.SW_58993_label3.Visible = false;
            // 
            // textBox2
            // 
            this.SW_58993_textBox2.Location = new System.Drawing.Point(18, 467);
            this.SW_58993_textBox2.Multiline = true;
            this.SW_58993_textBox2.Name = "SW_58993_textBox2";
            this.SW_58993_textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SW_58993_textBox2.Size = new System.Drawing.Size(510, 115);
            this.SW_58993_textBox2.TabIndex = 5;
            this.SW_58993_textBox2.Visible = false;
            // 
            // label4
            // 
            this.SW_58993_label4.AutoSize = true;
            this.SW_58993_label4.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_label4.Location = new System.Drawing.Point(18, 273);
            this.SW_58993_label4.Name = "SW_58993_label4";
            this.SW_58993_label4.Size = new System.Drawing.Size(238, 30);
            this.SW_58993_label4.TabIndex = 6;
            this.SW_58993_label4.Text = "Zestawienie znakow:";
            this.SW_58993_label4.Visible = false;
            // 
            // textBox3
            // 
            this.SW_58993_textBox3.Location = new System.Drawing.Point(21, 306);
            this.SW_58993_textBox3.Multiline = true;
            this.SW_58993_textBox3.Name = "SW_58993_textBox3";
            this.SW_58993_textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SW_58993_textBox3.Size = new System.Drawing.Size(510, 115);
            this.SW_58993_textBox3.TabIndex = 7;
            this.SW_58993_textBox3.Visible = false;
            // 
            // label5
            // 
            this.SW_58993_label5.AutoSize = true;
            this.SW_58993_label5.ForeColor = System.Drawing.Color.Yellow;
            this.SW_58993_label5.Location = new System.Drawing.Point(187, 199);
            this.SW_58993_label5.Name = "SW_58993_label5";
            this.SW_58993_label5.Size = new System.Drawing.Size(0, 25);
            this.SW_58993_label5.TabIndex = 10;
            this.SW_58993_label5.Visible = false;
            // 
            // Compress_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.SW_58993_label5);
            this.Controls.Add(this.SW_58993_textBox3);
            this.Controls.Add(this.SW_58993_label4);
            this.Controls.Add(this.SW_58993_textBox2);
            this.Controls.Add(this.SW_58993_label3);
            this.Controls.Add(this.SW_58993_button1);
            this.Controls.Add(this.SW_58993_label2);
            this.Controls.Add(this.SW_58993_textBox1);
            this.Controls.Add(this.SW_58993_label1);
            this.Name = "SW_58993_Compress_UC";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SW_58993_label1;
        private System.Windows.Forms.TextBox SW_58993_textBox1;
        private System.Windows.Forms.Label SW_58993_label2;
        private System.Windows.Forms.Button SW_58993_button1;
        private System.Windows.Forms.Label SW_58993_label3;
        private System.Windows.Forms.TextBox SW_58993_textBox2;
        private System.Windows.Forms.Label SW_58993_label4;
        private System.Windows.Forms.TextBox SW_58993_textBox3;
        private System.Windows.Forms.Label SW_58993_label5;
    }
}
