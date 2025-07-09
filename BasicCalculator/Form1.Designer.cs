namespace BasicCalculator
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
            label1 = new Label();
            label2 = new Label();
            Integer1Tbx = new TextBox();
            Integer2Tbx = new TextBox();
            CalculateBtn = new Button();
            SumTbx = new TextBox();
            label3 = new Label();
            OperandTbx = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 51);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Integer 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 135);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Integer 2:";
            // 
            // Integer1Tbx
            // 
            Integer1Tbx.Location = new Point(178, 48);
            Integer1Tbx.Name = "Integer1Tbx";
            Integer1Tbx.Size = new Size(100, 23);
            Integer1Tbx.TabIndex = 2;
            // 
            // Integer2Tbx
            // 
            Integer2Tbx.Location = new Point(178, 132);
            Integer2Tbx.Name = "Integer2Tbx";
            Integer2Tbx.Size = new Size(100, 23);
            Integer2Tbx.TabIndex = 3;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(90, 194);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(144, 71);
            CalculateBtn.TabIndex = 4;
            CalculateBtn.Text = "Calculate Sum";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // SumTbx
            // 
            SumTbx.Location = new Point(56, 301);
            SumTbx.Name = "SumTbx";
            SumTbx.ReadOnly = true;
            SumTbx.Size = new Size(222, 23);
            SumTbx.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 93);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Operand:";
            // 
            // OperandTbx
            // 
            OperandTbx.Location = new Point(178, 90);
            OperandTbx.Name = "OperandTbx";
            OperandTbx.Size = new Size(100, 23);
            OperandTbx.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OperandTbx);
            Controls.Add(label3);
            Controls.Add(SumTbx);
            Controls.Add(CalculateBtn);
            Controls.Add(Integer2Tbx);
            Controls.Add(Integer1Tbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Integer1Tbx;
        private TextBox Integer2Tbx;
        private Button CalculateBtn;
        private TextBox SumTbx;
        private Label label3;
        private TextBox OperandTbx;
    }
}
