﻿namespace _58993_SW_Projekt
{
    partial class SW_58993_Sort_UC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SW_58993_textBox1 = new System.Windows.Forms.TextBox();
            this.SW_58993_label1 = new System.Windows.Forms.Label();
            this.SW_58993_radioBubble = new System.Windows.Forms.RadioButton();
            this.SW_58993_radioInsertion = new System.Windows.Forms.RadioButton();
            this.SW_58993_button1 = new System.Windows.Forms.Button();
            this.SW_58993_textBox2 = new System.Windows.Forms.TextBox();
            this.SW_58993_label2 = new System.Windows.Forms.Label();
            this.SW_58993_label3 = new System.Windows.Forms.Label();
            this.SW_58993_label4 = new System.Windows.Forms.Label();
            this.SW_58993_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SW_58993_textBox1
            // 
            this.SW_58993_textBox1.Location = new System.Drawing.Point(24, 100);
            this.SW_58993_textBox1.Name = "SW_58993_textBox1";
            this.SW_58993_textBox1.Size = new System.Drawing.Size(411, 31);
            this.SW_58993_textBox1.TabIndex = 0;
            this.SW_58993_textBox1.TextChanged += new System.EventHandler(this.SW_58993_textBox1_Change);
            // 
            // SW_58993_label1
            // 
            this.SW_58993_label1.AutoSize = true;
            this.SW_58993_label1.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_label1.Location = new System.Drawing.Point(24, 50);
            this.SW_58993_label1.Name = "SW_58993_label1";
            this.SW_58993_label1.Size = new System.Drawing.Size(413, 30);
            this.SW_58993_label1.TabIndex = 1;
            this.SW_58993_label1.Text = "Podaj liczby oddzielone przecinkiem:";
            // 
            // SW_58993_radioBubble
            // 
            this.SW_58993_radioBubble.AutoSize = true;
            this.SW_58993_radioBubble.Checked = true;
            this.SW_58993_radioBubble.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_radioBubble.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_radioBubble.Location = new System.Drawing.Point(21, 169);
            this.SW_58993_radioBubble.Name = "SW_58993_radioBubble";
            this.SW_58993_radioBubble.Size = new System.Drawing.Size(155, 34);
            this.SW_58993_radioBubble.TabIndex = 2;
            this.SW_58993_radioBubble.TabStop = true;
            this.SW_58993_radioBubble.Text = "bąbelkowe";
            this.SW_58993_radioBubble.UseVisualStyleBackColor = true;
            // 
            // SW_58993_radioInsertion
            // 
            this.SW_58993_radioInsertion.AutoSize = true;
            this.SW_58993_radioInsertion.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_radioInsertion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_radioInsertion.Location = new System.Drawing.Point(214, 169);
            this.SW_58993_radioInsertion.Name = "SW_58993_radioInsertion";
            this.SW_58993_radioInsertion.Size = new System.Drawing.Size(224, 34);
            this.SW_58993_radioInsertion.TabIndex = 3;
            this.SW_58993_radioInsertion.Text = "przez wstawianie";
            this.SW_58993_radioInsertion.UseVisualStyleBackColor = true;
            // 
            // SW_58993_button1
            // 
            this.SW_58993_button1.Location = new System.Drawing.Point(24, 222);
            this.SW_58993_button1.Name = "SW_58993_button1";
            this.SW_58993_button1.Size = new System.Drawing.Size(112, 34);
            this.SW_58993_button1.TabIndex = 4;
            this.SW_58993_button1.Text = "SORTUJ";
            this.SW_58993_button1.UseVisualStyleBackColor = true;
            this.SW_58993_button1.Click += new System.EventHandler(this.SW_58993_button1_Click);
            // 
            // SW_58993_textBox2
            // 
            this.SW_58993_textBox2.Location = new System.Drawing.Point(24, 364);
            this.SW_58993_textBox2.Name = "SW_58993_textBox2";
            this.SW_58993_textBox2.ReadOnly = true;
            this.SW_58993_textBox2.Size = new System.Drawing.Size(407, 31);
            this.SW_58993_textBox2.TabIndex = 5;
            this.SW_58993_textBox2.Visible = false;
            // 
            // SW_58993_label2
            // 
            this.SW_58993_label2.AutoSize = true;
            this.SW_58993_label2.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_label2.Location = new System.Drawing.Point(21, 317);
            this.SW_58993_label2.Name = "SW_58993_label2";
            this.SW_58993_label2.Size = new System.Drawing.Size(241, 30);
            this.SW_58993_label2.TabIndex = 6;
            this.SW_58993_label2.Text = "Posortowana tablica:";
            this.SW_58993_label2.Visible = false;
            // 
            // SW_58993_label3
            // 
            this.SW_58993_label3.AutoSize = true;
            this.SW_58993_label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SW_58993_label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SW_58993_label3.Location = new System.Drawing.Point(21, 411);
            this.SW_58993_label3.Name = "SW_58993_label3";
            this.SW_58993_label3.Size = new System.Drawing.Size(385, 30);
            this.SW_58993_label3.TabIndex = 7;
            this.SW_58993_label3.Text = "Ilość operacji podczas sortowania:";
            this.SW_58993_label3.Visible = false;
            // 
            // SW_58993_label4
            // 
            this.SW_58993_label4.AutoSize = true;
            this.SW_58993_label4.Location = new System.Drawing.Point(33, 455);
            this.SW_58993_label4.Name = "SW_58993_label4";
            this.SW_58993_label4.Size = new System.Drawing.Size(0, 25);
            this.SW_58993_label4.TabIndex = 8;
            // 
            // SW_58993_label
            // 
            this.SW_58993_label.AutoSize = true;
            this.SW_58993_label.ForeColor = System.Drawing.Color.Yellow;
            this.SW_58993_label.Location = new System.Drawing.Point(18, 131);
            this.SW_58993_label.Name = "SW_58993_label";
            this.SW_58993_label.Size = new System.Drawing.Size(0, 25);
            this.SW_58993_label.TabIndex = 9;
            this.SW_58993_label.Visible = false;
            // 
            // SW_58993_Sort_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.SW_58993_label);
            this.Controls.Add(this.SW_58993_label4);
            this.Controls.Add(this.SW_58993_label3);
            this.Controls.Add(this.SW_58993_label2);
            this.Controls.Add(this.SW_58993_textBox2);
            this.Controls.Add(this.SW_58993_button1);
            this.Controls.Add(this.SW_58993_radioInsertion);
            this.Controls.Add(this.SW_58993_radioBubble);
            this.Controls.Add(this.SW_58993_label1);
            this.Controls.Add(this.SW_58993_textBox1);
            this.Name = "SW_58993_Sort_UC";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SW_58993_textBox1;
        private System.Windows.Forms.Label SW_58993_label1;
        private System.Windows.Forms.RadioButton SW_58993_radioBubble;
        private System.Windows.Forms.RadioButton SW_58993_radioInsertion;
        private System.Windows.Forms.Button SW_58993_button1;
        private System.Windows.Forms.TextBox SW_58993_textBox2;
        private System.Windows.Forms.Label SW_58993_label2;
        private System.Windows.Forms.Label SW_58993_label3;
        private System.Windows.Forms.Label SW_58993_label4;
        private System.Windows.Forms.Label SW_58993_label;
    }
}
