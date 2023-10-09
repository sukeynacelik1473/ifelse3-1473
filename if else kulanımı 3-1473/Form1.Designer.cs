namespace if_else_kulanımı_3_1473
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
            this.rbRenk1 = new System.Windows.Forms.RadioButton();
            this.rbSayı2 = new System.Windows.Forms.RadioButton();
            this.rbSayı3 = new System.Windows.Forms.RadioButton();
            this.rbSayı4 = new System.Windows.Forms.RadioButton();
            this.btnDeıstır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRenk1
            // 
            this.rbRenk1.AutoSize = true;
            this.rbRenk1.Location = new System.Drawing.Point(33, 34);
            this.rbRenk1.Name = "rbRenk1";
            this.rbRenk1.Size = new System.Drawing.Size(50, 17);
            this.rbRenk1.TabIndex = 0;
            this.rbRenk1.TabStop = true;
            this.rbRenk1.Text = "SARI";
            this.rbRenk1.UseVisualStyleBackColor = true;
            this.rbRenk1.CheckedChanged += new System.EventHandler(this.rbRenk1_CheckedChanged);
            // 
            // rbSayı2
            // 
            this.rbSayı2.AutoSize = true;
            this.rbSayı2.Location = new System.Drawing.Point(33, 74);
            this.rbSayı2.Name = "rbSayı2";
            this.rbSayı2.Size = new System.Drawing.Size(55, 17);
            this.rbSayı2.TabIndex = 1;
            this.rbSayı2.TabStop = true;
            this.rbSayı2.Text = "YEŞİL";
            this.rbSayı2.UseVisualStyleBackColor = true;
            // 
            // rbSayı3
            // 
            this.rbSayı3.AutoSize = true;
            this.rbSayı3.Location = new System.Drawing.Point(33, 115);
            this.rbSayı3.Name = "rbSayı3";
            this.rbSayı3.Size = new System.Drawing.Size(57, 17);
            this.rbSayı3.TabIndex = 2;
            this.rbSayı3.TabStop = true;
            this.rbSayı3.Text = "SİYAH";
            this.rbSayı3.UseVisualStyleBackColor = true;
            // 
            // rbSayı4
            // 
            this.rbSayı4.AutoSize = true;
            this.rbSayı4.Location = new System.Drawing.Point(33, 160);
            this.rbSayı4.Name = "rbSayı4";
            this.rbSayı4.Size = new System.Drawing.Size(79, 17);
            this.rbSayı4.TabIndex = 3;
            this.rbSayı4.TabStop = true;
            this.rbSayı4.Text = "TURUNCU";
            this.rbSayı4.UseVisualStyleBackColor = true;
            // 
            // btnDeıstır
            // 
            this.btnDeıstır.Location = new System.Drawing.Point(33, 210);
            this.btnDeıstır.Name = "btnDeıstır";
            this.btnDeıstır.Size = new System.Drawing.Size(168, 56);
            this.btnDeıstır.TabIndex = 4;
            this.btnDeıstır.Text = "RENK DEĞİŞTİR";
            this.btnDeıstır.UseVisualStyleBackColor = true;
            this.btnDeıstır.Click += new System.EventHandler(this.btnDeıstır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeıstır);
            this.Controls.Add(this.rbSayı4);
            this.Controls.Add(this.rbSayı3);
            this.Controls.Add(this.rbSayı2);
            this.Controls.Add(this.rbRenk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRenk1;
        private System.Windows.Forms.RadioButton rbSayı2;
        private System.Windows.Forms.RadioButton rbSayı3;
        private System.Windows.Forms.RadioButton rbSayı4;
        private System.Windows.Forms.Button btnDeıstır;
    }
}

