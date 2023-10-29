namespace Task3_IPA
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
            size_TB = new TextBox();
            percentage_TB = new TextBox();
            quantity_TB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            drink_result = new Label();
            spirit_result = new Label();
            label6 = new Label();
            label7 = new Label();
            send_button1 = new Button();
            SuspendLayout();
            // 
            // size_TB
            // 
            size_TB.Location = new Point(47, 60);
            size_TB.Name = "size_TB";
            size_TB.Size = new Size(100, 23);
            size_TB.TabIndex = 0;
            // 
            // percentage_TB
            // 
            percentage_TB.Location = new Point(47, 104);
            percentage_TB.Name = "percentage_TB";
            percentage_TB.Size = new Size(100, 23);
            percentage_TB.TabIndex = 1;
            // 
            // quantity_TB
            // 
            quantity_TB.Location = new Point(47, 152);
            quantity_TB.Name = "quantity_TB";
            quantity_TB.Size = new Size(100, 23);
            quantity_TB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 42);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "vessel size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 4;
            label2.Text = "percentage of spirit in the drink";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 134);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "quantity of vessels";
            // 
            // drink_result
            // 
            drink_result.AutoSize = true;
            drink_result.Location = new Point(326, 63);
            drink_result.Name = "drink_result";
            drink_result.Size = new Size(36, 15);
            drink_result.TabIndex = 6;
            drink_result.Text = "result";
            // 
            // spirit_result
            // 
            spirit_result.AutoSize = true;
            spirit_result.Location = new Point(326, 122);
            spirit_result.Name = "spirit_result";
            spirit_result.Size = new Size(36, 15);
            spirit_result.TabIndex = 7;
            spirit_result.Text = "result";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 107);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 8;
            label6.Text = "volume of pure spirit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(305, 48);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 9;
            label7.Text = "drink volume";
            // 
            // send_button1
            // 
            send_button1.Location = new Point(58, 181);
            send_button1.Name = "send_button1";
            send_button1.Size = new Size(75, 22);
            send_button1.TabIndex = 10;
            send_button1.Text = "send";
            send_button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 229);
            Controls.Add(send_button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(spirit_result);
            Controls.Add(drink_result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quantity_TB);
            Controls.Add(percentage_TB);
            Controls.Add(size_TB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox size_TB;
        private TextBox percentage_TB;
        private TextBox quantity_TB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label drink_result;
        private Label spirit_result;
        private Label label6;
        private Label label7;
        private Button send_button1;
    }
}