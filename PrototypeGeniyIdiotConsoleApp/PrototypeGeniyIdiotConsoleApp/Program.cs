using GeniyIdiot.Common;
using System;
using System.IO;

namespace PrototypeGeniyIdiotConsoleApp
{
    public class Program
    {
        const string statisticsFileName = "Statistics.txt";
        private static Game game;
        static void Main(string[] args)
        {
            Initialization();
            while (true)
            {
                Console.WriteLine("Начать новую игру? (введите: да/нет)");
                var yes = CheckAnswer(Console.ReadLine());
                if (yes)
                {
                    Console.WriteLine("Как Вас зовут?");
                    var name = Console.ReadLine();
                    var user = new User(name);
                    game = new Game(user);

                    while (!game.IsEnd())
                    {
                        Console.WriteLine(game.GetQuestionNumberInfo());
                        var question = game.PopQuestion();
                        Console.WriteLine(question.Print());
                        var userAnswer = TryGetUserAnswer();
                        game.AcceptAnswer(userAnswer);
                    }

                    Console.WriteLine(game.GetRightQuestionsCountInfo());
                    Console.WriteLine(game.CalculateDiagnose());

                    game.SaveResult();
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
            if (File.Exists(Path.Combine(FileSystem.docPath, statisticsFileName)) != true)
            {
                using (File.Create(Path.Combine(FileSystem.docPath, statisticsFileName)))
                { }
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
                var newQuestion = AddQuestionFlow();
                game.AddNewQuestion(newQuestion);
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
        
        public static bool CheckAnswer(string answer)
        {
            return answer == "да" || answer == "Да" || answer == "ДА";
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
        public static Question AddQuestionFlow()
        {
            Console.WriteLine("Введите новый вопрос");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос");
            var answer = TryGetUserAnswer();
            return new Question(text, answer);
        }
    }
}
