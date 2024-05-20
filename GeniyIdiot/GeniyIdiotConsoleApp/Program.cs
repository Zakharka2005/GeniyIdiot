using GeniyIdiotClassLibrary;

namespace GeniyIdiotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = "Да";

            string path = @"C:\TestGeniyIdiot";
            string fileNameResults = @"results.json";
            string fileNameQuestions = @"questions.json";
            FileProvider.CreateDirectory(path);

            var questions = QuestionsStorage.GetQuestions(path, fileNameQuestions);
            var quantityQuestions = questions.Count;

            Console.WriteLine("Введите своё имя");
            string name = GetString();
            var user = new User();
            user.Name = name;
            while (userAnswer.ToLower() == "да")
            {
                user.QuantityCorrectAnswers = 0;
                var numberRandomQuestions = Game.GetRandomIndexes(quantityQuestions);
                for (int i = 0; i < quantityQuestions; i++)
                {
                    Console.WriteLine("Вопрос № " + (i + 1));
                    int indexQuestions = numberRandomQuestions[0];
                    Console.WriteLine(questions[indexQuestions].Text);

                    var answerQuestion = GetNumber();
                    var rightAnswers = questions[indexQuestions].Answer;

                    if (answerQuestion == rightAnswers)
                    {
                        user.AcceptRigtAnswer();
                    }
                    numberRandomQuestions.RemoveAt(0);
                }
                user.Diagnose = UsersResultStorage.GetDiagnosis(quantityQuestions, user.QuantityCorrectAnswers);

                UsersResultStorage.Append(user, path, fileNameResults);
                Console.WriteLine(user.Name + ", количество правельных ответов: " + user.QuantityCorrectAnswers);
                Console.WriteLine("Ваш диагноз: " + user.Diagnose);
                Console.WriteLine("Повторить тест? (Да/Нет)");
                userAnswer = Console.ReadLine();
            }

            Console.WriteLine("Хотите посмотреть результаты прошлых игр? (да/нет)");
            userAnswer = GetString();
            if (userAnswer.ToLower() == "да")
            {
                Show(path, fileNameResults);
            }

            Console.WriteLine("Хотите добавить новый вопрос? (да/нет)");
            userAnswer = GetString();
            if (userAnswer.ToLower() == "да")
            {
                AddNewQuestion(path, fileNameQuestions);
            }
            Console.WriteLine("Хотите удалить какой-то вопрос? (да/нет)");
            userAnswer = GetString();
            if (userAnswer.ToLower() == "да")
            {
                RemoveQuestion(path, fileNameQuestions);
            }
        }

        static void RemoveQuestion(string path, string fileNameQuestions)
        {
            Console.WriteLine("Введите номер, удаляемого вопроса");
            var questions = QuestionsStorage.GetQuestions(path, fileNameQuestions);
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + questions[i].Text);
            }
            var removeQuestionNumber = GetNumber();
            while (removeQuestionNumber < 0 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNumber = GetNumber();
            }
            QuestionsStorage.Remove(removeQuestionNumber, path, fileNameQuestions);
        }

        private static string GetString()
        {
            string answer = Console.ReadLine();
            while (answer == string.Empty)
            {
                Console.WriteLine("Это поле обязательно для заполнения");
                Console.WriteLine("Введите данные");
                answer = Console.ReadLine();
            }
            return answer;
        }

        private static void AddNewQuestion(string path, string fileNameQuestions)
        {
            Console.WriteLine("Введите новый вопрос");
            var textQuestion = GetString();
            Console.WriteLine("Введите ответ на вопрос");
            var answer = GetNumber();

            var newQuestion = new Question(textQuestion, answer);
            QuestionsStorage.Add(newQuestion, path, fileNameQuestions);
        }

        private static int GetNumber()
        {
            int answerQuestion;
            while (!int.TryParse(Console.ReadLine(), out answerQuestion))
            {
                Console.WriteLine("Пожалуйста, введите число!");
            }

            return answerQuestion;
        }
        static void Show(string path, string fileName)
        {
            var results = UsersResultStorage.Get(path, fileName);
            Console.WriteLine("{0, -29}|{1, -29}|{2, -27}", "Имя", "Количество правельных ответов", "Диагноз");
            {
                foreach (var user in results)
                {
                    Console.WriteLine("{0, -29}|{1, -29}|{2, -27}", user.Name, user.QuantityCorrectAnswers, user.Diagnose);
                }
            }
        }
    }
}

