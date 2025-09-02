namespace WinformStandardCalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            panel1 = new Panel();
            lblSolution = new Label();
            lblInputOutput = new Label();
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
            btnSign = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnAdd = new Button();
            btnSqrRoot = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnEquals = new Button();
            tabCalculator = new TabControl();
            tabStandardPage = new TabPage();
            btnClearEntry = new Button();
            btnModulo = new Button();
            btnExponent = new Button();
            btnSquare = new Button();
            tabHistoryPage = new TabPage();
            panelHistory = new Panel();
            btnClearHistory = new Button();
            listBoxHistory = new ListBox();
            panel1.SuspendLayout();
            tabCalculator.SuspendLayout();
            tabStandardPage.SuspendLayout();
            tabHistoryPage.SuspendLayout();
            panelHistory.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InfoText;
            panel1.Controls.Add(lblSolution);
            panel1.Controls.Add(lblInputOutput);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 97);
            panel1.TabIndex = 0;
            // 
            // lblSolution
            // 
            lblSolution.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSolution.ForeColor = SystemColors.ActiveBorder;
            lblSolution.Location = new Point(3, 0);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(333, 27);
            lblSolution.TabIndex = 1;
            lblSolution.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInputOutput
            // 
            lblInputOutput.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputOutput.ForeColor = SystemColors.Control;
            lblInputOutput.Location = new Point(3, 27);
            lblInputOutput.Name = "lblInputOutput";
            lblInputOutput.Size = new Size(333, 70);
            lblInputOutput.TabIndex = 0;
            lblInputOutput.Text = "0";
            lblInputOutput.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(90, 392);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 52);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(8, 335);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(75, 51);
            btnOne.TabIndex = 2;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(90, 335);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(75, 51);
            btnTwo.TabIndex = 3;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(171, 335);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(75, 51);
            btnThree.TabIndex = 4;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(8, 279);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(75, 48);
            btnFour.TabIndex = 5;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(89, 279);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(75, 50);
            btnFive.TabIndex = 6;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(170, 278);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(75, 51);
            btnSix.TabIndex = 7;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(8, 223);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 50);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(89, 223);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(75, 50);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(170, 223);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(75, 50);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(171, 392);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(75, 52);
            btnDecimal.TabIndex = 11;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(8, 392);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(75, 52);
            btnSign.TabIndex = 12;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(251, 279);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 51);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(251, 223);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 50);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(251, 166);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 51);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(251, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 52);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSqrRoot
            // 
            btnSqrRoot.Location = new Point(170, 166);
            btnSqrRoot.Name = "btnSqrRoot";
            btnSqrRoot.Size = new Size(75, 51);
            btnSqrRoot.TabIndex = 17;
            btnSqrRoot.Text = "sqr root";
            btnSqrRoot.UseVisualStyleBackColor = true;
            btnSqrRoot.Click += btnSqrRoot_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(251, 105);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 55);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(170, 105);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 55);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(251, 394);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 48);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // tabCalculator
            // 
            tabCalculator.Controls.Add(tabStandardPage);
            tabCalculator.Controls.Add(tabHistoryPage);
            tabCalculator.Location = new Point(0, 0);
            tabCalculator.Name = "tabCalculator";
            tabCalculator.SelectedIndex = 0;
            tabCalculator.Size = new Size(344, 475);
            tabCalculator.TabIndex = 21;
            // 
            // tabStandardPage
            // 
            tabStandardPage.Controls.Add(btnClearEntry);
            tabStandardPage.Controls.Add(btnModulo);
            tabStandardPage.Controls.Add(btnExponent);
            tabStandardPage.Controls.Add(btnSquare);
            tabStandardPage.Controls.Add(panel1);
            tabStandardPage.Controls.Add(btnSign);
            tabStandardPage.Controls.Add(btnEquals);
            tabStandardPage.Controls.Add(btnDecimal);
            tabStandardPage.Controls.Add(btnSqrRoot);
            tabStandardPage.Controls.Add(btnNine);
            tabStandardPage.Controls.Add(btnAdd);
            tabStandardPage.Controls.Add(btnEight);
            tabStandardPage.Controls.Add(btnDelete);
            tabStandardPage.Controls.Add(btnSeven);
            tabStandardPage.Controls.Add(btnSubtract);
            tabStandardPage.Controls.Add(btnSix);
            tabStandardPage.Controls.Add(btnMultiply);
            tabStandardPage.Controls.Add(btnFive);
            tabStandardPage.Controls.Add(btnFour);
            tabStandardPage.Controls.Add(btnDivide);
            tabStandardPage.Controls.Add(btnThree);
            tabStandardPage.Controls.Add(btnClear);
            tabStandardPage.Controls.Add(btnTwo);
            tabStandardPage.Controls.Add(btnZero);
            tabStandardPage.Controls.Add(btnOne);
            tabStandardPage.Location = new Point(4, 24);
            tabStandardPage.Name = "tabStandardPage";
            tabStandardPage.Padding = new Padding(3);
            tabStandardPage.Size = new Size(336, 447);
            tabStandardPage.TabIndex = 0;
            tabStandardPage.Text = "Standard";
            tabStandardPage.UseVisualStyleBackColor = true;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Location = new Point(90, 107);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(75, 55);
            btnClearEntry.TabIndex = 24;
            btnClearEntry.Text = "Clear Entry";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnModulo
            // 
            btnModulo.Location = new Point(9, 107);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(75, 51);
            btnModulo.TabIndex = 23;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = true;
            btnModulo.Click += btnModulo_Click;
            // 
            // btnExponent
            // 
            btnExponent.Location = new Point(9, 166);
            btnExponent.Name = "btnExponent";
            btnExponent.Size = new Size(75, 51);
            btnExponent.TabIndex = 22;
            btnExponent.Text = "exponent";
            btnExponent.UseVisualStyleBackColor = true;
            btnExponent.Click += btnExponent_Click;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(90, 166);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(75, 51);
            btnSquare.TabIndex = 21;
            btnSquare.Text = "sqr";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // tabHistoryPage
            // 
            tabHistoryPage.Controls.Add(panelHistory);
            tabHistoryPage.Location = new Point(4, 24);
            tabHistoryPage.Name = "tabHistoryPage";
            tabHistoryPage.Padding = new Padding(3);
            tabHistoryPage.Size = new Size(336, 447);
            tabHistoryPage.TabIndex = 1;
            tabHistoryPage.Text = "History";
            tabHistoryPage.UseVisualStyleBackColor = true;
            // 
            // panelHistory
            // 
            panelHistory.BackColor = Color.Black;
            panelHistory.Controls.Add(btnClearHistory);
            panelHistory.Controls.Add(listBoxHistory);
            panelHistory.Location = new Point(0, 0);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(336, 447);
            panelHistory.TabIndex = 0;
            // 
            // btnClearHistory
            // 
            btnClearHistory.Location = new Point(255, 414);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(75, 23);
            btnClearHistory.TabIndex = 1;
            btnClearHistory.Text = "Clear History";
            btnClearHistory.UseVisualStyleBackColor = true;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // listBoxHistory
            // 
            listBoxHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.ItemHeight = 21;
            listBoxHistory.Items.AddRange(new object[] { "There's no history yet." });
            listBoxHistory.Location = new Point(3, 3);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(330, 403);
            listBoxHistory.TabIndex = 0;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(342, 473);
            Controls.Add(tabCalculator);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            panel1.ResumeLayout(false);
            tabCalculator.ResumeLayout(false);
            tabStandardPage.ResumeLayout(false);
            tabHistoryPage.ResumeLayout(false);
            panelHistory.ResumeLayout(false);
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
        private Button btnSign;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnAdd;
        private Button btnSqrRoot;
        private Button btnDelete;
        private Button btnClear;
        private Label lblInputOutput;
        private Button btnEquals;
        private TabControl tabCalculator;
        private TabPage tabStandardPage;
        private TabPage tabHistoryPage;
        private Button btnExponent;
        private Button btnSquare;
        private Button btnClearEntry;
        private Button btnModulo;
        private Label lblSolution;
        private Panel panelHistory;
        private ListBox listBoxHistory;
        private Button btnClearHistory;
    }
}
