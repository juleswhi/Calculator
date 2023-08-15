namespace Calculator
{
    partial class FormCalculator
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
            btnCalculate = new Button();
            lblResult = new Label();
            btn0 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(70, 340);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 75);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "=";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Left;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(157, 15);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(160, 55);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(151, 340);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 75);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberClick;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(151, 181);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 75);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberClick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(151, 262);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 75);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberClick;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(232, 262);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 75);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberClick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(70, 181);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 75);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberClick;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(70, 262);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 75);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberClick;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(232, 181);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 75);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberClick;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(232, 100);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 75);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberClick;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(151, 100);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 75);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberClick;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(70, 100);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 75);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberClick;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.Location = new Point(313, 340);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 75);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += OperatorClick;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMul.Location = new Point(313, 262);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 75);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += OperatorClick;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSub.Location = new Point(313, 181);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 75);
            btnSub.TabIndex = 14;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += OperatorClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(313, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 75);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OperatorClick;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(232, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 75);
            btnClear.TabIndex = 18;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblResult);
            panel1.Location = new Point(70, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 85);
            panel1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn0);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculate;
        private Label lblResult;
        private Button btn0;
        private Button btn5;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn1;
        private Button btn6;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDiv;
        private Button btnMul;
        private Button btnSub;
        private Button btnAdd;
        private Button btnClear;
        private Panel panel1;
    }
}