namespace StudentGradeCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maths, science, english, total, average;
            string grade;

            maths = int.Parse(textMaths.Text);
            science = int.Parse(textScience.Text);
            english = int.Parse(textEnglish.Text);

            total = maths + science + english;
            textTotal.Text = total.ToString();

            average = total / 3;
            textAverage.Text = average.ToString();

            if (average >= 75)
            {
                grade = "A";
            }
            else if (average >= 65)
            {
                grade = "B";
            }
            else if (average >= 55)
            {
                grade = "C";
            }
            else if (average >= 45)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            textGrade.Text = grade;
        }
    }
}