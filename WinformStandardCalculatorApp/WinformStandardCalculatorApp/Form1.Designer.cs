namespace WinformStandardCalculatorApp
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
            panel1 = new Panel();
            lblResult = new Label();
            btnZero = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnDecimal = new Button();
            button12 = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnAdd = new Button();
            button17 = new Button();
            btnBack = new Button();
            btnClear = new Button();
            btnEquals = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(lblResult);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 97);
            panel1.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 21F);
            lblResult.ForeColor = SystemColors.Control;
            lblResult.Location = new Point(13, 32);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(32, 38);
            lblResult.TabIndex = 0;
            lblResult.Text = "0";
            lblResult.Click += label1_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(172, 413);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 66);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(91, 341);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(75, 66);
            btnOne.TabIndex = 2;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(172, 341);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(75, 66);
            btnTwo.TabIndex = 3;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(253, 341);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(75, 66);
            btnThree.TabIndex = 4;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(91, 269);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(75, 66);
            btnFour.TabIndex = 5;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(172, 269);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(75, 66);
            btnFive.TabIndex = 6;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(253, 269);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(75, 66);
            btnSix.TabIndex = 7;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(91, 197);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 66);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(172, 197);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(75, 66);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(253, 197);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(75, 66);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(253, 413);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(75, 66);
            btnDecimal.TabIndex = 11;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(91, 413);
            button12.Name = "button12";
            button12.Size = new Size(75, 66);
            button12.TabIndex = 12;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(334, 269);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 66);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(334, 197);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 66);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(334, 125);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 66);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(334, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 66);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button17
            // 
            button17.Location = new Point(9, 197);
            button17.Name = "button17";
            button17.Size = new Size(75, 66);
            button17.TabIndex = 17;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(253, 125);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 66);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(172, 125);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 66);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(334, 413);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 66);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(416, 484);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(button17);
            Controls.Add(btnAdd);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(button12);
            Controls.Add(btnDecimal);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnZero);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnZero;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnDecimal;
        private Button button12;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnAdd;
        private Button button17;
        private Button btnBack;
        private Button btnClear;
        private Label lblResult;
        private Button btnEquals;
    }
}
