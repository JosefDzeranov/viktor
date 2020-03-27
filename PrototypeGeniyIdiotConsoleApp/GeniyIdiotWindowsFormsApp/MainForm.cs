using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using GeniyIdiot.Common;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<Question> questions = Question.ListToQuestions();
        const string questionFileName = "Questions.txt";
        const string statisticsFileName = "Statistics.txt";
        readonly Random random = new Random();
        User user;
        int randomQuestionIndex;
        decimal questionNumberCounter = 1;


        public MainForm()
        {
            InitializeComponent();
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            Initialization();
            GetUserName();
            user = GetNameFromUser.user;
            PrintNextQuestion();
        }

        public static void Initialization()
        {
            var questions = Question.ListToQuestions();
            int i = 0;
            if (File.Exists(Path.Combine(FileSystem.docPath, statisticsFileName)) != true)
            {
                using (File.Create(Path.Combine(FileSystem.docPath, statisticsFileName)))
                { }
            }
            if (File.Exists(Path.Combine(FileSystem.docPath, questionFileName)) != true)
            {
                using (File.Create(Path.Combine(FileSystem.docPath, questionFileName)))
                { }
                while (i != questions.Count)
                {
                    var question = questions[i].Text + '$' + questions[i].Answer;
                    FileSystem.SaveString(question, questionFileName);
                    i++;
                }
            }
        }
        private void GetUserName()
        {
            var newForm = new GetNameFromUser();
            newForm.ShowDialog();
            userName.Text = newForm.writeUserName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(questionAnswerTextBox.Text, out int userAnswer))
            {
                MessageBox.Show("Введите ответ!");
                return;
            }
            var rightAnswer = questions[randomQuestionIndex].Answer;
            if (userAnswer == rightAnswer)
            {
                user.RightAnswers++;
            }
            questions.Remove(questions[randomQuestionIndex]);
            if (questions.Count == 0)
            {
                FinishGame();
                return;
            }
            PrintNextQuestion();
        }

        void PrintNextQuestion()
        {
            randomQuestionIndex = random.Next(questions.Count);
            questionNum.Text = "Вопрос №" + questionNumberCounter;
            questionTextLabel.Text = questions[randomQuestionIndex].Print();
            questionNumberCounter += 1;
            questionAnswerTextBox.Text = "";
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void показатьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new StatisticsForm();
            newForm.ShowDialog();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionForm = new QuestionsForm();
            questionForm.ShowDialog();
        }

        private void удалитьПользовательскиеВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(FileSystem.docPath, questionFileName));
            MessageBox.Show("Приложение будет перезапущенно!");
            Application.Restart();
        }

        private void открытьФайлВопросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(FileSystem.docPath, questionFileName));
        }

        private void очиститьСтатистикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(FileSystem.docPath, statisticsFileName));
            MessageBox.Show("Приложение будет перезапущенно!");
            Application.Restart();
        }

        private void открытьФайлСтатистикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(FileSystem.docPath, statisticsFileName));
        }
        private void FinishGame()
        {
            button1.Enabled = false;
            var resultDiagnose = Diagnose.CalculateDiagnose(user, 5);
            user.Diagnose = resultDiagnose;
            var result = $"Число правильных ответов: {user.RightAnswers} \n {user.Name}, Ваш диагноз: {user.Diagnose.Name}";
            MessageBox.Show(result);
            FileSystem.SaveString(user.Name + '$' + user.RightAnswers + '$' + user.Diagnose.Name, statisticsFileName);
        }
        

    }
}
