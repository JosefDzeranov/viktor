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
            

        }
        public void questionFormbutton_Click(object sender, EventArgs e)
        {
            if (questionFormTextBox.Text == "" || answerFormtextBox.Text == "")
            {
                MessageBox.Show("Заполните поля \"Вопрос-Ответ\" ");
                return;
            }
            question = questionFormTextBox.Text;
            answer = answerFormtextBox.Text;
            FileSystem.SaveString(question + '$' + answer, "Questions.txt");
            MessageBox.Show("Вопрос добавлен и сохранен");
            Close();

        }
    }
}
