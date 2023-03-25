namespace StudentGradeCalculation
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
            groupBox1 = new GroupBox();
            textGrade = new TextBox();
            textAverage = new TextBox();
            textTotal = new TextBox();
            textEnglish = new TextBox();
            textScience = new TextBox();
            textMaths = new TextBox();
            textStudentName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Grade";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textGrade);
            groupBox1.Controls.Add(textAverage);
            groupBox1.Controls.Add(textTotal);
            groupBox1.Controls.Add(textEnglish);
            groupBox1.Controls.Add(textScience);
            groupBox1.Controls.Add(textMaths);
            groupBox1.Controls.Add(textStudentName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 368);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Grade";
            // 
            // textGrade
            // 
            textGrade.Location = new Point(182, 327);
            textGrade.Name = "textGrade";
            textGrade.Size = new Size(251, 31);
            textGrade.TabIndex = 13;
            // 
            // textAverage
            // 
            textAverage.Location = new Point(182, 279);
            textAverage.Name = "textAverage";
            textAverage.Size = new Size(251, 31);
            textAverage.TabIndex = 12;
            // 
            // textTotal
            // 
            textTotal.Location = new Point(182, 230);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(251, 31);
            textTotal.TabIndex = 11;
            // 
            // textEnglish
            // 
            textEnglish.Location = new Point(182, 186);
            textEnglish.Name = "textEnglish";
            textEnglish.Size = new Size(251, 31);
            textEnglish.TabIndex = 10;
            // 
            // textScience
            // 
            textScience.Location = new Point(182, 131);
            textScience.Name = "textScience";
            textScience.Size = new Size(251, 31);
            textScience.TabIndex = 9;
            // 
            // textMaths
            // 
            textMaths.Location = new Point(182, 82);
            textMaths.Name = "textMaths";
            textMaths.Size = new Size(251, 31);
            textMaths.TabIndex = 8;
            // 
            // textStudentName
            // 
            textStudentName.Location = new Point(182, 37);
            textStudentName.Name = "textStudentName";
            textStudentName.Size = new Size(251, 31);
            textStudentName.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 327);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 6;
            label8.Text = "Grade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(25, 286);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 5;
            label7.Text = "Avg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 237);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 4;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 186);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 3;
            label5.Text = "English";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 138);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Science";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Maths";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 44);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 423);
            button1.Name = "button1";
            button1.Size = new Size(462, 38);
            button1.TabIndex = 14;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 484);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Grade Calculation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox textGrade;
        private TextBox textAverage;
        private TextBox textTotal;
        private TextBox textEnglish;
        private TextBox textScience;
        private TextBox textMaths;
        private TextBox textStudentName;
    }
}