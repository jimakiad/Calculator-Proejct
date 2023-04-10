namespace Calculator_Project
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
            txtDisplay = new TextBox();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnOperationDivide = new Button();
            btnOperationMultiply = new Button();
            btnOperationMinus = new Button();
            btnOperationPlus = new Button();
            btnOperationEqual = new Button();
            btnClear = new Button();
            btnNum0 = new Button();
            btnSign = new Button();
            btnDecimal = new Button();
            btnBackspace = new Button();
            btnReciprocal = new Button();
            btnSquare = new Button();
            txtHistory = new TextBox();
            btnSquareRoot = new Button();
            btnPercentage = new Button();
            btnClearEntry = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.Location = new Point(25, 73);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(403, 46);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(53, 261);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(77, 23);
            btnNum1.TabIndex = 1;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += button1_Click;
            // 
            // btnNum2
            // 
            btnNum2.Location = new Point(135, 261);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(76, 23);
            btnNum2.TabIndex = 2;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum3
            // 
            btnNum3.Location = new Point(215, 261);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(77, 23);
            btnNum3.TabIndex = 3;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum4
            // 
            btnNum4.Location = new Point(53, 232);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(77, 23);
            btnNum4.TabIndex = 4;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum5
            // 
            btnNum5.Location = new Point(135, 232);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(77, 23);
            btnNum5.TabIndex = 5;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum6
            // 
            btnNum6.Location = new Point(215, 232);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(77, 23);
            btnNum6.TabIndex = 6;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum7
            // 
            btnNum7.Location = new Point(53, 203);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(77, 23);
            btnNum7.TabIndex = 7;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum8
            // 
            btnNum8.Location = new Point(134, 203);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(77, 23);
            btnNum8.TabIndex = 8;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum9
            // 
            btnNum9.Location = new Point(215, 203);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(77, 23);
            btnNum9.TabIndex = 9;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnOperationDivide
            // 
            btnOperationDivide.Location = new Point(300, 174);
            btnOperationDivide.Name = "btnOperationDivide";
            btnOperationDivide.Size = new Size(77, 23);
            btnOperationDivide.TabIndex = 10;
            btnOperationDivide.Text = "/";
            btnOperationDivide.UseVisualStyleBackColor = true;
            btnOperationDivide.Click += btnOperationDivide_Click;
            // 
            // btnOperationMultiply
            // 
            btnOperationMultiply.Location = new Point(300, 203);
            btnOperationMultiply.Name = "btnOperationMultiply";
            btnOperationMultiply.Size = new Size(77, 23);
            btnOperationMultiply.TabIndex = 11;
            btnOperationMultiply.Text = "*";
            btnOperationMultiply.UseVisualStyleBackColor = true;
            btnOperationMultiply.Click += btnOperationMultiply_Click;
            // 
            // btnOperationMinus
            // 
            btnOperationMinus.Location = new Point(300, 232);
            btnOperationMinus.Name = "btnOperationMinus";
            btnOperationMinus.Size = new Size(77, 23);
            btnOperationMinus.TabIndex = 12;
            btnOperationMinus.Text = "-";
            btnOperationMinus.UseVisualStyleBackColor = true;
            btnOperationMinus.Click += btnOperationMinus_Click;
            // 
            // btnOperationPlus
            // 
            btnOperationPlus.Location = new Point(300, 261);
            btnOperationPlus.Name = "btnOperationPlus";
            btnOperationPlus.Size = new Size(77, 23);
            btnOperationPlus.TabIndex = 13;
            btnOperationPlus.Text = "+";
            btnOperationPlus.UseVisualStyleBackColor = true;
            btnOperationPlus.Click += btnOperationPlus_Click;
            // 
            // btnOperationEqual
            // 
            btnOperationEqual.Location = new Point(300, 290);
            btnOperationEqual.Name = "btnOperationEqual";
            btnOperationEqual.Size = new Size(77, 23);
            btnOperationEqual.TabIndex = 14;
            btnOperationEqual.Text = "=";
            btnOperationEqual.UseVisualStyleBackColor = true;
            btnOperationEqual.Click += btnOperationEqual_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(216, 145);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNum0
            // 
            btnNum0.Location = new Point(134, 290);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(77, 23);
            btnNum0.TabIndex = 16;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(53, 290);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(77, 23);
            btnSign.TabIndex = 17;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(215, 290);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(77, 23);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(300, 145);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(77, 23);
            btnBackspace.TabIndex = 19;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Location = new Point(53, 174);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(77, 23);
            btnReciprocal.TabIndex = 20;
            btnReciprocal.Text = "1/x";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(135, 174);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(77, 23);
            btnSquare.TabIndex = 21;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // txtHistory
            // 
            txtHistory.Location = new Point(25, 23);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.ScrollBars = ScrollBars.Vertical;
            txtHistory.Size = new Size(403, 52);
            txtHistory.TabIndex = 22;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Location = new Point(215, 174);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(77, 23);
            btnSquareRoot.TabIndex = 23;
            btnSquareRoot.Text = "√x";
            btnSquareRoot.UseVisualStyleBackColor = true;
            btnSquareRoot.Click += btnSquareRoot_Click;
            // 
            // btnPercentage
            // 
            btnPercentage.Location = new Point(53, 145);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(77, 23);
            btnPercentage.TabIndex = 24;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += btnPercentage_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Location = new Point(135, 145);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(77, 23);
            btnClearEntry.TabIndex = 25;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(452, 345);
            Controls.Add(btnClearEntry);
            Controls.Add(btnPercentage);
            Controls.Add(btnSquareRoot);
            Controls.Add(txtHistory);
            Controls.Add(btnSquare);
            Controls.Add(btnReciprocal);
            Controls.Add(btnBackspace);
            Controls.Add(btnDecimal);
            Controls.Add(btnSign);
            Controls.Add(btnNum0);
            Controls.Add(btnClear);
            Controls.Add(btnOperationEqual);
            Controls.Add(btnOperationPlus);
            Controls.Add(btnOperationMinus);
            Controls.Add(btnOperationMultiply);
            Controls.Add(btnOperationDivide);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnOperationDivide;
        private Button btnOperationMultiply;
        private Button btnOperationMinus;
        private Button btnOperationPlus;
        private Button btnOperationEqual;
        private Button btnClear;
        private Button btnNum0;
        private Button btnSign;
        private Button btnDecimal;
        private Button btnBackspace;
        private Button btnReciprocal;
        private Button btnSquare;
        private TextBox txtHistory;
        private Button btnSquareRoot;
        private Button btnPercentage;
        private Button btnClearEntry;
    }
}