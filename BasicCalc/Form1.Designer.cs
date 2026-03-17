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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            lbl_result = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtResult = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnCross = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Segoe UI", 15F);
            lblNumber1.Location = new Point(140, 66);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(104, 28);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Number 1:";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Segoe UI", 15F);
            lblNumber2.Location = new Point(140, 112);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(104, 28);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Number 2:";
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Font = new Font("Segoe UI", 15F);
            lbl_result.Location = new Point(140, 259);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(68, 28);
            lbl_result.TabIndex = 2;
            lbl_result.Text = "Result:";
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Segoe UI", 15F);
            txtNumber1.Location = new Point(250, 66);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(176, 34);
            txtNumber1.TabIndex = 0;
            txtNumber1.TextChanged += txtNumber1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Segoe UI", 15F);
            txtNumber2.Location = new Point(250, 112);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(176, 34);
            txtNumber2.TabIndex = 1;
            txtNumber2.TextChanged += txtNumber2_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 15F);
            txtResult.Location = new Point(250, 259);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(176, 34);
            txtResult.TabIndex = 6;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.Control;
            btnPlus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnPlus.Location = new Point(141, 173);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 60);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.Control;
            btnMinus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnMinus.Location = new Point(217, 173);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 60);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnCross
            // 
            btnCross.BackColor = SystemColors.Control;
            btnCross.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnCross.Location = new Point(295, 173);
            btnCross.Name = "btnCross";
            btnCross.Size = new Size(50, 60);
            btnCross.TabIndex = 4;
            btnCross.Text = "*";
            btnCross.UseVisualStyleBackColor = false;
            btnCross.Click += btnCross_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.Control;
            btnDivide.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnDivide.Location = new Point(376, 173);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 60);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 192);
            btnClear.Location = new Point(364, 304);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(62, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(556, 350);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnCross);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lbl_result);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private Label lbl_result;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtResult;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnCross;
        private Button btnDivide;
        private Button btnClear;
    }
}
