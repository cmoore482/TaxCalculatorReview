namespace TaxCalculator
{
    partial class IncomeTaxCalculator
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
            BtnExit = new Button();
            BtnCalculate = new Button();
            OwedTxt = new TextBox();
            IncomeTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(165, 95);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(23, 95);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 23);
            BtnCalculate.TabIndex = 3;
            BtnCalculate.Text = "&Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // OwedTxt
            // 
            OwedTxt.Location = new Point(140, 53);
            OwedTxt.Name = "OwedTxt";
            OwedTxt.ReadOnly = true;
            OwedTxt.Size = new Size(100, 23);
            OwedTxt.TabIndex = 2;
            OwedTxt.TextChanged += OwedTxt_TextChanged;
            // 
            // IncomeTxt
            // 
            IncomeTxt.Location = new Point(140, 24);
            IncomeTxt.Name = "IncomeTxt";
            IncomeTxt.Size = new Size(100, 23);
            IncomeTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Taxable income:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 5;
            label2.Text = "Income tax owed:";
            // 
            // IncomeTaxCalculator
            // 
            AcceptButton = BtnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnExit;
            ClientSize = new Size(279, 152);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IncomeTxt);
            Controls.Add(OwedTxt);
            Controls.Add(BtnCalculate);
            Controls.Add(BtnExit);
            Name = "IncomeTaxCalculator";
            Text = "Income Tax Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnExit;
        private Button BtnCalculate;
        private TextBox OwedTxt;
        private TextBox IncomeTxt;
        private Label label1;
        private Label label2;
    }
}
