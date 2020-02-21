using System;
using System.IO;

namespace PrototypeGeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // добавил комментарий для теста коммитов
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();

            int countRightAnswer = 0;
            const int countQuestions = 5;
            string[] questions = GetQuestions();
            int[] answers = GetAnswers();
            int[] randomOrderQuestionsIndexes = GetRandomOrderNumbers(countQuestions);

            for (int i = 0; i < countQuestions; i++)
            {
                Console.WriteLine("Вопрос №" + (i + 1));
                Console.WriteLine(questions[randomOrderQuestionsIndexes[i]]);

                int userAnswer = TryGetUserAnswer();
                int rightAnswer = answers[randomOrderQuestionsIndexes[i]];
                if (userAnswer == rightAnswer)
                {
                    countRightAnswer++;
                }
            }

            string resultDiagnose = CalculateDiagnose(countRightAnswer);
            string countRightAnswerText = $"Число правильных ответов: {countRightAnswer}";
            string diagnoseText = $"{name}, Ваш диагноз: {resultDiagnose}";

            Console.WriteLine(countRightAnswerText);
            Console.Write(diagnoseText);

            SaveResultInMyDocuments(countRightAnswerText, diagnoseText);
            Console.ReadKey();
        }

        static void SaveResultInMyDocuments(string countRightAnswerText, string diagnoseText)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                outputFile.WriteLine(countRightAnswerText);
                outputFile.WriteLine(diagnoseText);
            }
        }

        static int TryGetUserAnswer()
        {
            string answer = Console.ReadLine();
            if (!int.TryParse(answer, out int userAnswer))
            {
                Console.WriteLine("Введенный ответ не является числом");
            }
            return userAnswer;
        }

        static int[] GetRandomOrderNumbers(int maxValue)
        {
            Random rnd = new Random();
            int[] orderNumbers = new int[maxValue];
            for (int i = 0; i < maxValue; i++)
            {
                orderNumbers[i] = rnd.Next(maxValue);
                for (int j = 0; j < i; j++)
                {
                    if (orderNumbers[i] == orderNumbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            return orderNumbers;
        }
        static string[] GetQuestions()
        {
            string[] questions =
                {
                    "Сколько будет два плюс два  умноженное на два?",
                    "Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?",
                    "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
                    "Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?",
                    "Пять свечей горело, две  потухли. Сколько свечей  осталось?"
                };

            return questions;
        }
        static int[] GetAnswers()
        {
            int[] answers = { 6, 9, 25, 60, 2 };
            return answers;
        }
        static string CalculateDiagnose(int diagnoseNumber)
        {
            string[] diagnoses = GetDiagnoses();
            return diagnoses[diagnoseNumber];
        }
        private static string[] GetDiagnoses()
        {
            string[] diagnoses = new string[6];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            return diagnoses;
        }
    }
}
