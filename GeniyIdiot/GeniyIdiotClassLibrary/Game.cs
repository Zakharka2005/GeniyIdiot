namespace GeniyIdiotClassLibrary
{
    public class Game
    {
        public static List<int> GetRandomIndexes(int quantityQuestions)
        {
            int[] numberRandomQuestions = new int[quantityQuestions];
            for (int i = 0; i < quantityQuestions; i++)
            {
                numberRandomQuestions[i] = i;
            }
            Random.Shared.Shuffle(numberRandomQuestions);
            return numberRandomQuestions.ToList();
        }
        
        
    }

}

