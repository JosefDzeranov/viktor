using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class Game
    {
        private const string questionFileName = "Questions.txt";
        private const string statisticsFileName = "Statistics.txt";

        private User user;
        private List<Question> questions;
        private int beginQuestionsCount;
        private Question currentQuestion;
        private int questionNumber = 0;
        private Random random = new Random();

        public Game(User user)
        {
            this.user = user;
            InitQuestions();
        }

        public bool IsEnd()
        {
            return questions.Count == 0;
        }

        public Question PopQuestion()
        {
            var randomIndex = random.Next(questions.Count);
            currentQuestion = questions[randomIndex];
            questions.RemoveAt(randomIndex);
            return currentQuestion;
        }

        public void AddNewQuestion(Question question)
        {
            var value = question.Text + '$' + question.Answer;
            FileSystem.SaveString(value, questionFileName);
        }

        public string GetQuestionNumberInfo()
        {
            questionNumber++;
            return "Вопрос №" + questionNumber;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.RightAnswers++;
            }
        }

        public string CalculateDiagnose()
        {
            var diagnose = Diagnose.CalculateDiagnose(user, beginQuestionsCount);
            user.Diagnose = diagnose;
            return $"{user.Name}, Ваш диагноз: {user.Diagnose.Name}";
        }

        public string GetRightQuestionsCountInfo()
        {
            return $"Число правильных ответов: {user.RightAnswers}";
        }

        public void SaveResult()
        {
            FileSystem.SaveString(user.Name + '$' + user.RightAnswers + '$' + user.Diagnose.Name, statisticsFileName);
        }

        private void InitQuestions()
        {
            questions = new List<Question>();

            if (FileSystem.IsExists(questionFileName))
            {
                var result = FileSystem.GetString(questionFileName);
                var separator = new[] { "\r\n" };
                var splitedStrings = result.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < splitedStrings.Length; i++)
                {
                    var splitedWord = splitedStrings[i].Split('$');
                    var text = splitedWord[0];
                    var answer = Convert.ToInt32(splitedWord[1]);
                    var question = new Question(text, answer);
                    questions.Add(question);
                }
            }
            else
            {
                questions = Question.ListToQuestions();
                foreach (var question in questions)
                {
                    var value = question.Text + '$' + question.Answer;
                    FileSystem.SaveString(value, questionFileName);
                }
            }

            beginQuestionsCount = questions.Count;
        }
    }
}
