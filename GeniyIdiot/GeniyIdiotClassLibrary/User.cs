namespace GeniyIdiotClassLibrary
{
    public class User
    {
        public string Name;
        public int QuantityCorrectAnswers;
        public string Diagnose;

        public User()
        {
            Name = "Неизвестно";
        }
        public void AcceptRigtAnswer()
        {
            QuantityCorrectAnswers++;
        }

    }

}

