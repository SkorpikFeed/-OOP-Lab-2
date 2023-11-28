namespace Lab_2
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
        class PeriodicPublication
        {
            double subPrice;
            string title;
            int numberOfIssuesPerYear;
            public PeriodicPublication(double price, string title, int numberOfIssuesPerYear)
            {
                this.subPrice = price;
                this.title = title;
                this.numberOfIssuesPerYear = numberOfIssuesPerYear;
            }
            public PeriodicPublication()
            {
                this.title = "------";
                this.numberOfIssuesPerYear = 12;
                this.subPrice = 0.0;
            }
            public double AnnualCost()
            {
                return subPrice * numberOfIssuesPerYear;
            }
            public double AverageIssueCost()
            {
                if (numberOfIssuesPerYear != 0)
                {
                    return subPrice / numberOfIssuesPerYear;
                }
                else return 0.0;
            }
            public void Info()
            {
                MessageBox.Show("Інформація про видання\n\nНазва видання:                       " + title.ToString() + "\n\nКількість випусків на рік:      " +
                    numberOfIssuesPerYear.ToString() + "\n\nВартість підписки:                  " + subPrice.ToString(), "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(172, 99);
            button1.Name = "button1";
            button1.Size = new Size(196, 60);
            button1.TabIndex = 0;
            button1.Text = "Видання за замовчуванням";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(407, 99);
            button2.Name = "button2";
            button2.Size = new Size(196, 60);
            button2.TabIndex = 1;
            button2.Text = "Визначене видання";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(294, 337);
            button3.Name = "button3";
            button3.Size = new Size(196, 60);
            button3.TabIndex = 2;
            button3.Text = "Закрити програму";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}