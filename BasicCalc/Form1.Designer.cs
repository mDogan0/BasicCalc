namespace BasicCalc
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
            lbl_number_one = new Label();
            lbl_number_two = new Label();
            lbl_sonuc = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            txtSonuc = new TextBox();
            btnArti = new Button();
            btnEksi = new Button();
            btnCarpi = new Button();
            btnBol = new Button();
            SuspendLayout();
            // 
            // lbl_number_one
            // 
            lbl_number_one.AutoSize = true;
            lbl_number_one.Font = new Font("Segoe UI", 15F);
            lbl_number_one.Location = new Point(140, 66);
            lbl_number_one.Name = "lbl_number_one";
            lbl_number_one.Size = new Size(104, 28);
            lbl_number_one.TabIndex = 0;
            lbl_number_one.Text = "Number 1:";
            // 
            // lbl_number_two
            // 
            lbl_number_two.AutoSize = true;
            lbl_number_two.Font = new Font("Segoe UI", 15F);
            lbl_number_two.Location = new Point(140, 112);
            lbl_number_two.Name = "lbl_number_two";
            lbl_number_two.Size = new Size(104, 28);
            lbl_number_two.TabIndex = 1;
            lbl_number_two.Text = "Number 2:";
            // 
            // lbl_sonuc
            // 
            lbl_sonuc.AutoSize = true;
            lbl_sonuc.Font = new Font("Segoe UI", 15F);
            lbl_sonuc.Location = new Point(140, 259);
            lbl_sonuc.Name = "lbl_sonuc";
            lbl_sonuc.Size = new Size(75, 28);
            lbl_sonuc.TabIndex = 2;
            lbl_sonuc.Text = "Sonuç: ";
            // 
            // txtSayi1
            // 
            txtSayi1.Font = new Font("Segoe UI", 15F);
            txtSayi1.Location = new Point(250, 66);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(176, 34);
            txtSayi1.TabIndex = 3;
            // 
            // txtSayi2
            // 
            txtSayi2.Font = new Font("Segoe UI", 15F);
            txtSayi2.Location = new Point(250, 112);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(176, 34);
            txtSayi2.TabIndex = 4;
            // 
            // txtSonuc
            // 
            txtSonuc.Font = new Font("Segoe UI", 15F);
            txtSonuc.Location = new Point(220, 259);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.ReadOnly = true;
            txtSonuc.Size = new Size(206, 34);
            txtSonuc.TabIndex = 5;
            // 
            // btnArti
            // 
            btnArti.BackColor = SystemColors.Control;
            btnArti.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnArti.Location = new Point(141, 173);
            btnArti.Name = "btnArti";
            btnArti.Size = new Size(50, 60);
            btnArti.TabIndex = 6;
            btnArti.Text = "+";
            btnArti.UseVisualStyleBackColor = false;
            btnArti.Click += btnArti_Click;
            // 
            // btnEksi
            // 
            btnEksi.BackColor = SystemColors.Control;
            btnEksi.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnEksi.Location = new Point(217, 173);
            btnEksi.Name = "btnEksi";
            btnEksi.Size = new Size(50, 60);
            btnEksi.TabIndex = 7;
            btnEksi.Text = "-";
            btnEksi.UseVisualStyleBackColor = false;
            btnEksi.Click += btnEksi_Click;
            // 
            // btnCarpi
            // 
            btnCarpi.BackColor = SystemColors.Control;
            btnCarpi.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnCarpi.Location = new Point(295, 173);
            btnCarpi.Name = "btnCarpi";
            btnCarpi.Size = new Size(50, 60);
            btnCarpi.TabIndex = 8;
            btnCarpi.Text = "*";
            btnCarpi.UseVisualStyleBackColor = false;
            btnCarpi.Click += btnCarpi_Click;
            // 
            // btnBol
            // 
            btnBol.BackColor = SystemColors.Control;
            btnBol.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnBol.Location = new Point(376, 173);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(50, 60);
            btnBol.TabIndex = 9;
            btnBol.Text = "/";
            btnBol.UseVisualStyleBackColor = false;
            btnBol.Click += btnBol_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 350);
            Controls.Add(btnBol);
            Controls.Add(btnCarpi);
            Controls.Add(btnEksi);
            Controls.Add(btnArti);
            Controls.Add(txtSonuc);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(lbl_sonuc);
            Controls.Add(lbl_number_two);
            Controls.Add(lbl_number_one);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_number_one;
        private Label lbl_number_two;
        private Label lbl_sonuc;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private TextBox txtSonuc;
        private Button btnArti;
        private Button btnEksi;
        private Button btnCarpi;
        private Button btnBol;
    }
}
