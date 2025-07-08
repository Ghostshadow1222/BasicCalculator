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
            LengthTbx = new TextBox();
            WidthTbx = new TextBox();
            CalculateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 51);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 118);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Width";
            // 
            // LengthTbx
            // 
            LengthTbx.Location = new Point(178, 48);
            LengthTbx.Name = "LengthTbx";
            LengthTbx.Size = new Size(100, 23);
            LengthTbx.TabIndex = 2;
            // 
            // WidthTbx
            // 
            WidthTbx.Location = new Point(178, 115);
            WidthTbx.Name = "WidthTbx";
            WidthTbx.Size = new Size(100, 23);
            WidthTbx.TabIndex = 3;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(90, 194);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(144, 71);
            CalculateBtn.TabIndex = 4;
            CalculateBtn.Text = "Calculate Area and Perimeter";
            CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculateBtn);
            Controls.Add(WidthTbx);
            Controls.Add(LengthTbx);
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
        private TextBox LengthTbx;
        private TextBox WidthTbx;
        private Button CalculateBtn;
    }
}
