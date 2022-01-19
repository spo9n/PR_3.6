using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_3._6_Surgai
{
    public partial class MainForm : Form
    {
        Queue<Question> Questions = new Queue<Question>();
        Question CurrentQuestion;

        int CorrectAnswers = 0;
        int IncorrectAnswers = 0;
        int QuestionNumber = 0;



        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCounters();

            Questions.Enqueue(new Question("Кавун – це ягода?", true));
            Questions.Enqueue(new Question("У Сахарі сніг ніколи не випадав?", false));
            Questions.Enqueue(new Question("У дощових черв'яків по п'ять сердець", true));
            Questions.Enqueue(new Question("Столітня війна тривала сто років?", false));
            Questions.Enqueue(new Question("Єдиний у світі птах, що вміє літати тому - це колібрі?", true));

            questionTextLabel.Text = Questions.Peek().GetQuestionText();

        }

        public void UpdateCounters()
        {
            questionNumberLabel.Text = QuestionNumber.ToString();
            countCorrectAnswersLabel.Text = CorrectAnswers.ToString();
            countIncorrectAnswersLabel.Text = IncorrectAnswers.ToString();
        }

        public void CheckCountOfIncorrectAnswers()
        {
            if (IncorrectAnswers == 2)
            {
                MessageBox.Show("Ви програли.", "Кінець гри.");
                Application.Exit();
            }
        }


        private void trueButton_Click(object sender, EventArgs e)
        {
            CurrentQuestion = Questions.Dequeue();

            if (CurrentQuestion.GetAnswer())
            {
                CorrectAnswers++;
            }
            else
            {
                IncorrectAnswers++;
            }

            QuestionNumber++;

            HideButtons();
            UpdateCounters();
            CheckCountOfIncorrectAnswers();
        }

        private void falseButton_Click(object sender, EventArgs e)
        {
            CurrentQuestion = Questions.Dequeue();

            if (!CurrentQuestion.GetAnswer())
            {
                CorrectAnswers++;
            }
            else
            {
                IncorrectAnswers++;
            }

            QuestionNumber++;

            HideButtons();
            UpdateCounters();
            CheckCountOfIncorrectAnswers();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (Questions.Count == 0)
            {
                MessageBox.Show("Ви перемогли!", "Вітаємо!");
                Application.Exit();
            }
            else
            {
                questionTextLabel.Text = Questions.Peek().GetQuestionText();
            }
            ShowButtons();
        }

        private void HideButtons()
        {
            trueButton.Visible = false;
            falseButton.Visible = false;
        }

        private void ShowButtons()
        {
            trueButton.Visible = true;
            falseButton.Visible = true;
        }
    }
}
