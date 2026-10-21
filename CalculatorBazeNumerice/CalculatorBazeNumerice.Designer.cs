namespace CalculatorBazeNumerice
{
    partial class CalculatorBazeNumerice
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
            ResultBox = new TextBox();
            DeleteBtn = new Button();
            ZeroBtn = new Button();
            ClearBtn = new Button();
            BaseTwoBtn = new RadioButton();
            BaseTenBtn = new RadioButton();
            BaseSixteenBtn = new RadioButton();
            OneBtn = new Button();
            SuspendLayout();
            // 
            // ResultBox
            // 
            ResultBox.Font = new Font("Segoe UI", 18F);
            ResultBox.Location = new Point(26, 24);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(499, 55);
            ResultBox.TabIndex = 0;
            ResultBox.Text = "0";
            ResultBox.TextAlign = HorizontalAlignment.Right;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(194, 343);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(78, 75);
            DeleteBtn.TabIndex = 12;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Location = new Point(110, 343);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(78, 75);
            ZeroBtn.TabIndex = 11;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(26, 343);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(78, 75);
            ClearBtn.TabIndex = 10;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // BaseTwoBtn
            // 
            BaseTwoBtn.AutoSize = true;
            BaseTwoBtn.Font = new Font("Segoe UI", 13F);
            BaseTwoBtn.Location = new Point(337, 322);
            BaseTwoBtn.Name = "BaseTwoBtn";
            BaseTwoBtn.Size = new Size(114, 40);
            BaseTwoBtn.TabIndex = 13;
            BaseTwoBtn.TabStop = true;
            BaseTwoBtn.Text = "baza 2\r\n";
            BaseTwoBtn.UseVisualStyleBackColor = true;
            BaseTwoBtn.CheckedChanged += BaseTwoBtn_CheckedChanged;
            // 
            // BaseTenBtn
            // 
            BaseTenBtn.AutoSize = true;
            BaseTenBtn.Font = new Font("Segoe UI", 13F);
            BaseTenBtn.Location = new Point(337, 276);
            BaseTenBtn.Name = "BaseTenBtn";
            BaseTenBtn.Size = new Size(128, 40);
            BaseTenBtn.TabIndex = 14;
            BaseTenBtn.TabStop = true;
            BaseTenBtn.Text = "baza 10\r\n";
            BaseTenBtn.UseVisualStyleBackColor = true;
            BaseTenBtn.CheckedChanged += BaseTenBtn_CheckedChanged;
            // 
            // BaseSixteenBtn
            // 
            BaseSixteenBtn.AutoSize = true;
            BaseSixteenBtn.Font = new Font("Segoe UI", 13F);
            BaseSixteenBtn.Location = new Point(337, 368);
            BaseSixteenBtn.Name = "BaseSixteenBtn";
            BaseSixteenBtn.Size = new Size(128, 40);
            BaseSixteenBtn.TabIndex = 15;
            BaseSixteenBtn.TabStop = true;
            BaseSixteenBtn.Text = "baza 16\r\n";
            BaseSixteenBtn.UseVisualStyleBackColor = true;
            BaseSixteenBtn.CheckedChanged += BaseSixteenBtn_CheckedChanged;
            // 
            // OneBtn
            // 
            OneBtn.Location = new Point(26, 100);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(78, 75);
            OneBtn.TabIndex = 1;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // CalculatorBazeNumerice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(BaseSixteenBtn);
            Controls.Add(BaseTenBtn);
            Controls.Add(BaseTwoBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(ClearBtn);
            Controls.Add(OneBtn);
            Controls.Add(ResultBox);
            Name = "CalculatorBazeNumerice";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResultBox;
        private Button DeleteBtn;
        private Button ZeroBtn;
        private Button ClearBtn;
        private RadioButton BaseTwoBtn;
        private RadioButton BaseTenBtn;
        private RadioButton BaseSixteenBtn;
        private Button OneBtn;
    }
}
