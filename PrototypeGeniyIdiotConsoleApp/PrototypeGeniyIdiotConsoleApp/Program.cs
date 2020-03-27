using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.IO;

namespace PrototypeGeniyIdiotConsoleApp
{
    public class Program
    {
        const string questionFileName = "Questions.txt";
        const string statisticsFileName = "Statistics.txt";

        public static void Main(string[] args)
        {
            Initialization();
            while (true)
            {
                Console.WriteLine("Начать новую игру? (введите: да/нет)");
                var yes = CheckAnswer(Console.ReadLine());
                var random = new Random();
                if (yes)
                {
                    Console.WriteLine("Как Вас зовут?");
                    var name = Console.ReadLine();
                    var user = new User(name);
                    var questions = GetQuestions();
                    var beginCountQuestions = questions.Count;
                    var questionNumberCounter = 1m;
                    while (questions.Count > 0)
                    {
                        var randomQuestionIndex = random.Next(questions.Count);
                        Console.WriteLine("Вопрос №" + questionNumberCounter);
                        Console.WriteLine(questions[randomQuestionIndex].Print());
                        var userAnswer = TryGetUserAnswer();
                        var rightAnswer = questions[randomQuestionIndex].Answer;
                        if (userAnswer == rightAnswer)
                        {
                            user.RightAnswers++;
                        }
                        questionNumberCounter++;
                        questions.Remove(questions[randomQuestionIndex]);
                    }

                    var resultDiagnose = Diagnose.CalculateDiagnose(user, beginCountQuestions);
                    user.Diagnose = resultDiagnose;


                    var countRightAnswerText = $"Число правильных ответов: {user.RightAnswers}";
                    var diagnoseText = $"{user.Name}, Ваш диагноз: {user.Diagnose.Name}";

                    Console.WriteLine(countRightAnswerText);
                    Console.WriteLine(diagnoseText);

                    SaveResultInMyDocuments(user);
                    if (PostGameFlow())
                    {
                        continue;
                    }
                    break;
                }
                else
                {
                    if (PostGameFlow())
                    {
                        continue;
                    }
                    break;
                }
            }
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
                while(i != questions.Count)
                {
                    var question = questions[i].Text + '$' + questions[i].Answer;
                    FileSystem.SaveString(question, questionFileName);
                    i++;
                }
            }
        }
        public static bool PostGameFlow()
        {
            Console.WriteLine("Вывести статистику игр? (введите: да/нет)");
            var yes = CheckAnswer(Console.ReadLine());
            if (yes)
            {
                GetStatistics();
                return true;
            }
            Console.WriteLine("Хотите добавить свой вопрос? (введите: да/нет)");
            yes = CheckAnswer(Console.ReadLine());
            if (yes)
            {
                AddQuestionFlow();
                return true;
            }
            return false;
        }
        static int TryGetUserAnswer()
        {
            int userAnswer;
            while (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                {
                    Console.WriteLine("Введенный ответ не является числом");
                }
            }
            return userAnswer;
        }
        public static List<Question> GetQuestions()
        {
            var questions = new List<Question> { };
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
            return questions;
        }
        public static bool CheckAnswer(string answer)
        {
            return answer == "да" || answer == "Да" || answer == "ДА";
        }
        public static void SaveResultInMyDocuments(User user)
        {
            FileSystem.SaveString(user.Name + '$' + user.RightAnswers + '$' + user.Diagnose.Name, statisticsFileName);
        }
        public static void GetStatistics()
        {
            Console.WriteLine("{0,-20}{1,-40}{2,-15}", "Имя:", "Кол-во правильных ответов:", "Диагноз:");
            Console.WriteLine("____________________________________________________________________");
            var result = FileSystem.GetString(statisticsFileName);
            string[] delimeter = new string[1];
            delimeter[0] = "\r\n";
            var SplitedStrings = result.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < SplitedStrings.Length; i++)
            {
                var splitedWord = SplitedStrings[i].Split('$');

                Console.WriteLine("{0,-30}{1,-30}{2,-12}", splitedWord[0], splitedWord[1], splitedWord[2]);
                Console.WriteLine();
            }

        }
        public static void AddQuestionFlow()
        {
            Console.WriteLine("Введите новый вопрос");
            var question = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос");
            var answer = TryGetUserAnswer();
            FileSystem.SaveString(question + '$' + answer, questionFileName);
        }
    }
}
