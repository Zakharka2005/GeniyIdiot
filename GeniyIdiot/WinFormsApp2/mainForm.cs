
using GeniyIdiotClassLibrary;
using GeniyIdiotWinForm;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private string path = @"C:\TestGeniyIdiot";
        private string fileNameQquestions = @"questions.json";
        private List<Question> questions;
        private List<int> randomIndexes = new List<int>();
        private User user = new User();
        private int questionNumber = 0;
        private int currentIndexQuestion;
        private int startTime = 10;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("На решение вопроса дается 10 секунд", "Сообщение", MessageBoxButtons.OK);
            questions = QuestionsStorage.GetQuestions(path, fileNameQquestions);
            randomIndexes = Game.GetRandomIndexes(questions.Count);
            ShowNextQuestion();
            Determinelocation(numberQuestionsLabel);
            Determinelocation(textQuestionLabel);
            Determinelocation(timerLabel);
            Determinelocation(userAnswerTextBox);
            Determinelocation(nextButton);
        }

        private void ShowNextQuestion()
        {

            currentIndexQuestion = randomIndexes[0];
            randomIndexes.RemoveAt(0);
            textQuestionLabel.Text = questions[currentIndexQuestion].Text;

            questionNumber++;
            numberQuestionsLabel.Text = "Вопрос № " + questionNumber;
            timer1.Start();
        }



        private void nextButton_Click(object sender, EventArgs e)
        {
            int userAnswer;

            while (!int.TryParse(userAnswerTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Ответьте на вопрос числом");
                return;
            }

            timer1.Stop();
            startTime = 10;
            timerLabel.Text = startTime + "секунд";

            var rightAnswers = questions[currentIndexQuestion].Answer;

            if (userAnswer == rightAnswers)
            {
                user.AcceptRigtAnswer();
            }
            if (randomIndexes.Count == 0)
            {
                user.Diagnose = UsersResultStorage.GetDiagnosis(questions.Count, user.QuantityCorrectAnswers);
                ResultsForm resultsForm = new ResultsForm(user);
                resultsForm.ShowDialog();
                return;
            }
            ShowNextQuestion();
            Determinelocation(numberQuestionsLabel);
            Determinelocation(textQuestionLabel);
            Determinelocation(timerLabel);
            Determinelocation(userAnswerTextBox);
            Determinelocation(nextButton);
        }

        private void Determinelocation(Control control)
        {
            control.Left = ClientSize.Width / 2 - control.Width / 2;
        }
        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startTime--;
            timerLabel.ForeColor = Color.Black;
            if (startTime >= 5)
            {
                timerLabel.Text = startTime + " секунд";
            }
            if (startTime >= 2 && startTime <= 4)
            {
                timerLabel.Text = startTime + " секунды";
                timerLabel.ForeColor = Color.Red;
            }
            if (startTime == 1)
            {
                timerLabel.Text = startTime + " секунда";
            }

            if (startTime == 0)
            {
                timer1.Stop();
                startTime = 10;
                timerLabel.Text = startTime + "секунд";
                timerLabel.ForeColor = Color.Black;
                ShowNextQuestion();
                if (randomIndexes.Count == 0)
                {
                    user.Diagnose = UsersResultStorage.GetDiagnosis(questions.Count, user.QuantityCorrectAnswers);
                    ResultsForm resultsForm = new ResultsForm(user);
                    resultsForm.ShowDialog();
                    return;
                }
            }
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Подтверждение", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
            {
                e.Cancel = true;
            }
        }
    }

}
