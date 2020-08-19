namespace SimpleCalcUI
{
    partial class CalculatorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnEquality = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnTimes = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnNegator = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.txtDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.02935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.97065F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisplay.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(3, 2);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(532, 69);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.BtnDivide, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnEquality, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnZero, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnDot, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnTimes, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnThree, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnTwo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnOne, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnMinus, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnSix, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnFive, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnFour, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnPlus, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnNine, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnEight, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnSeven, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnNegator, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnCancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnBackspace, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnCopy, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 329);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDivide.FlatAppearance.BorderSize = 0;
            this.BtnDivide.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDivide.Location = new System.Drawing.Point(402, 262);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(127, 65);
            this.BtnDivide.TabIndex = 0;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // BtnEquality
            // 
            this.BtnEquality.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEquality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEquality.FlatAppearance.BorderSize = 0;
            this.BtnEquality.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEquality.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEquality.Location = new System.Drawing.Point(269, 262);
            this.BtnEquality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEquality.Name = "BtnEquality";
            this.BtnEquality.Size = new System.Drawing.Size(127, 65);
            this.BtnEquality.TabIndex = 0;
            this.BtnEquality.Text = "=";
            this.BtnEquality.UseVisualStyleBackColor = false;
            this.BtnEquality.Click += new System.EventHandler(this.BtnEquality_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnZero.FlatAppearance.BorderSize = 0;
            this.BtnZero.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnZero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnZero.Location = new System.Drawing.Point(136, 262);
            this.BtnZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(127, 65);
            this.BtnZero.TabIndex = 0;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = false;
            this.BtnZero.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDot.Location = new System.Drawing.Point(3, 262);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(127, 65);
            this.BtnDot.TabIndex = 0;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnTimes
            // 
            this.BtnTimes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTimes.FlatAppearance.BorderSize = 0;
            this.BtnTimes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTimes.Location = new System.Drawing.Point(402, 197);
            this.BtnTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTimes.Name = "BtnTimes";
            this.BtnTimes.Size = new System.Drawing.Size(127, 61);
            this.BtnTimes.TabIndex = 0;
            this.BtnTimes.Text = "*";
            this.BtnTimes.UseVisualStyleBackColor = false;
            this.BtnTimes.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // BtnThree
            // 
            this.BtnThree.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnThree.FlatAppearance.BorderSize = 0;
            this.BtnThree.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnThree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnThree.Location = new System.Drawing.Point(269, 197);
            this.BtnThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(127, 61);
            this.BtnThree.TabIndex = 0;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = false;
            this.BtnThree.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnTwo
            // 
            this.BtnTwo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTwo.FlatAppearance.BorderSize = 0;
            this.BtnTwo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTwo.Location = new System.Drawing.Point(136, 197);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(127, 61);
            this.BtnTwo.TabIndex = 0;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = false;
            this.BtnTwo.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnOne
            // 
            this.BtnOne.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOne.FlatAppearance.BorderSize = 0;
            this.BtnOne.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnOne.Location = new System.Drawing.Point(3, 197);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(127, 61);
            this.BtnOne.TabIndex = 0;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMinus.FlatAppearance.BorderSize = 0;
            this.BtnMinus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMinus.Location = new System.Drawing.Point(402, 132);
            this.BtnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(127, 61);
            this.BtnMinus.TabIndex = 0;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // BtnSix
            // 
            this.BtnSix.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSix.FlatAppearance.BorderSize = 0;
            this.BtnSix.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSix.Location = new System.Drawing.Point(269, 132);
            this.BtnSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(127, 61);
            this.BtnSix.TabIndex = 0;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = false;
            this.BtnSix.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnFive
            // 
            this.BtnFive.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFive.FlatAppearance.BorderSize = 0;
            this.BtnFive.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFive.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFive.Location = new System.Drawing.Point(136, 132);
            this.BtnFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(127, 61);
            this.BtnFive.TabIndex = 0;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = false;
            this.BtnFive.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnFour
            // 
            this.BtnFour.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFour.FlatAppearance.BorderSize = 0;
            this.BtnFour.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFour.Location = new System.Drawing.Point(3, 132);
            this.BtnFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(127, 61);
            this.BtnFour.TabIndex = 0;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = false;
            this.BtnFour.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPlus.FlatAppearance.BorderSize = 0;
            this.BtnPlus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPlus.Location = new System.Drawing.Point(402, 67);
            this.BtnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(127, 61);
            this.BtnPlus.TabIndex = 0;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // BtnNine
            // 
            this.BtnNine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNine.FlatAppearance.BorderSize = 0;
            this.BtnNine.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNine.Location = new System.Drawing.Point(269, 67);
            this.BtnNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(127, 61);
            this.BtnNine.TabIndex = 0;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = false;
            this.BtnNine.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnEight
            // 
            this.BtnEight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEight.FlatAppearance.BorderSize = 0;
            this.BtnEight.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEight.Location = new System.Drawing.Point(136, 67);
            this.BtnEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(127, 61);
            this.BtnEight.TabIndex = 0;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = false;
            this.BtnEight.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnSeven
            // 
            this.BtnSeven.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSeven.FlatAppearance.BorderSize = 0;
            this.BtnSeven.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSeven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSeven.Location = new System.Drawing.Point(3, 67);
            this.BtnSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(127, 61);
            this.BtnSeven.TabIndex = 0;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = false;
            this.BtnSeven.Click += new System.EventHandler(this.BtnNumeric);
            // 
            // BtnNegator
            // 
            this.BtnNegator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNegator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNegator.FlatAppearance.BorderSize = 0;
            this.BtnNegator.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNegator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNegator.Location = new System.Drawing.Point(402, 2);
            this.BtnNegator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNegator.Name = "BtnNegator";
            this.BtnNegator.Size = new System.Drawing.Size(127, 61);
            this.BtnNegator.TabIndex = 0;
            this.BtnNegator.Text = "±";
            this.BtnNegator.UseVisualStyleBackColor = false;
            this.BtnNegator.Click += new System.EventHandler(this.BtnNegator_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancel.Location = new System.Drawing.Point(269, 2);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(127, 61);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "C";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBackspace.FlatAppearance.BorderSize = 0;
            this.BtnBackspace.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBackspace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBackspace.Location = new System.Drawing.Point(136, 2);
            this.BtnBackspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(127, 61);
            this.BtnBackspace.TabIndex = 0;
            this.BtnBackspace.Text = "⌫";
            this.BtnBackspace.UseVisualStyleBackColor = false;
            this.BtnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCopy.FlatAppearance.BorderSize = 0;
            this.BtnCopy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCopy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCopy.Location = new System.Drawing.Point(3, 2);
            this.BtnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(127, 61);
            this.BtnCopy.TabIndex = 0;
            this.BtnCopy.Text = "Copy";
            this.BtnCopy.UseVisualStyleBackColor = false;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblShowOp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowOp.Location = new System.Drawing.Point(22, 17);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 19);
            this.lblShowOp.TabIndex = 1;
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(562, 427);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(580, 474);
            this.MinimumSize = new System.Drawing.Size(580, 474);
            this.Name = "CalculatorUI";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnEquality;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnTimes;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnNegator;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Label lblShowOp;
    }
}

