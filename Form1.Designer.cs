namespace first_task
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
            FirstTaskLabel = new Label();
            ResumeButton = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // FirstTaskLabel
            // 
            FirstTaskLabel.AutoSize = true;
            FirstTaskLabel.Location = new Point(12, 9);
            FirstTaskLabel.Name = "FirstTaskLabel";
            FirstTaskLabel.Size = new Size(94, 15);
            FirstTaskLabel.TabIndex = 0;
            FirstTaskLabel.Text = "Первое задание";
            // 
            // ResumeButton
            // 
            ResumeButton.Location = new Point(0, 27);
            ResumeButton.Name = "ResumeButton";
            ResumeButton.Size = new Size(165, 37);
            ResumeButton.TabIndex = 1;
            ResumeButton.Text = "показать резюме";
            ResumeButton.UseVisualStyleBackColor = true;
            ResumeButton.Click += ResumeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "второе задание";
            // 
            // button1
            // 
            button1.Location = new Point(225, 27);
            button1.Name = "button1";
            button1.Size = new Size(165, 37);
            button1.TabIndex = 3;
            button1.Text = "угадать число";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 9);
            label2.Name = "label2";
            label2.Size = new Size(242, 15);
            label2.TabIndex = 4;
            label2.Text = "третье задание выполнено на другом окне";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 598);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ResumeButton);
            Controls.Add(FirstTaskLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstTaskLabel;
        private Button ResumeButton;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}