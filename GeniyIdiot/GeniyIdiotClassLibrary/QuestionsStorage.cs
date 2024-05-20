using Newtonsoft.Json;
using System.IO;

namespace GeniyIdiotClassLibrary
{
    public class QuestionsStorage
    {
        public static List<Question> GetQuestions(string path, string fileNameQuestions)
        {
            var questions = new List<Question>();

            if (FileProvider.Exists(path, fileNameQuestions))
            {
                var fileData = FileProvider.Get(path, fileNameQuestions);
                 questions = JsonConvert.DeserializeObject<List<Question>>(fileData);
                return questions;
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
                FileProvider.Replace(path, jsonData, fileNameQuestions);
            }
            return questions;
        }
        public static void Add(Question newQuestion, string path, string fileNameQuestions)
        {
            var jsonData = string.Empty;
            var questions = new List<Question>();
           
                questions = GetQuestions(path, fileNameQuestions);
                questions.Add(newQuestion);
                jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
                FileProvider.Replace(path, jsonData, fileNameQuestions);
        }


        public static void Remove(int removeQuestionNumber, string path, string fileNameQuestions)
        {
            var questions = GetQuestions(path, fileNameQuestions);
            questions.RemoveAt(removeQuestionNumber-1);
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
           FileProvider.Replace(path, jsonData, fileNameQuestions);
        }
    }

}

