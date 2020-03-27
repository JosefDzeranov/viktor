using GeniyIdiot.Common;
using PrototypeGeniyIdiotConsoleApp;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class QuestionsForm : Form
    {
        string question;
        string answer;
        public QuestionsForm()
        {
            InitializeComponent();
            QuestionForm_Load();
        }
        public void QuestionForm_Load()
        {
            questionFormLabel.Text = "Введите вопрос";
            answerQuestionFormButton.Enabled = false;
            answerQuestionFormButton.Visible = false;

        }
        public void questionFormbutton_Click(object sender, EventArgs e)
        {
            if (questionFormTextBox.Text == "")
            {
                MessageBox.Show("Введите вопрос!");
                return;
            }
            question = questionFormTextBox.Text;
            questionFormLabel.Text = "Введите ответ";
            answerQuestionFormButton.Enabled = true;
            answerQuestionFormButton.Visible = true;
        }

        public void answerQuestionFormButton_Click(object sender, EventArgs e)
        {
            answer = questionFormTextBox.Text;
            FileSystem.SaveString(question + '$' + answer, "Questions.txt");
            MessageBox.Show("Вопрос добавлен и сохранен");
            Close();
        }
    }
}
