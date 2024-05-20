using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace GeniyIdiotClassLibrary
{
    public class UsersResultStorage
    {
        public static void Append(User user, string path, string fileName)
        {
            var usersResults = Get(path, fileName);
            usersResults.Add(user);
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData, fileName);
        }

        public static List<User> Get(string path, string fileName)
        {
            if (!FileProvider.Exists( path, fileName))
            { 
            return new List<User> ();
            }
            var fileData = FileProvider.Get(path, fileName);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }
        public static string GetDiagnosis(int quantityQuestions, int quantityCorrectAnswers)
        {
            double CoefficientAnswerCorrect = (double)quantityCorrectAnswers / quantityQuestions;
            if (CoefficientAnswerCorrect == 0)
            {
                return "Идиот";
            }
            if (CoefficientAnswerCorrect > 0 && CoefficientAnswerCorrect < 0.25)
            {
                return "Кретин";
            }
            if (CoefficientAnswerCorrect >= 0.25 && CoefficientAnswerCorrect < 0.45)
            {
                return "Дурак";
            }
            if (CoefficientAnswerCorrect >= 0.45 && CoefficientAnswerCorrect < 0.65)
            {
                return "Нормальный";
            }
            if (CoefficientAnswerCorrect >= 0.65 && CoefficientAnswerCorrect < 0.85)
            {
                return "Талант";
            }
            return "Гений";

        }
    }

}

