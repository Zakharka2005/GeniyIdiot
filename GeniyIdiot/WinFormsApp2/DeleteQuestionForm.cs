using GeniyIdiotClassLibrary;
using System.IO;

namespace GeniyIdiotWinForm
{
    public partial class DeleteQuestionForm : Form
    {
        string path = @"C:\TestGeniyIdiot";
        string fileNameQuestions = @"questions.json";
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }
        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.GetQuestions(path, fileNameQuestions);
            for (int i = 0; i < questions.Count; i++)
            {
                questionsListBox.Items.Add((i + 1) + "." + questions[i].Text);
            }

        }

        private void returnMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = questionsListBox.SelectedIndex;
            while (selectedIndex == -1)
            {
                MessageBox.Show("Выделите удаляемый вопрос");
                return;
                selectedIndex = questionsListBox.SelectedIndex;
            }
            QuestionsStorage.Remove(selectedIndex, path, fileNameQuestions);

            statusLabel.Text = "Статус: выделенный вопрос удален";

            questionsListBox.Items.RemoveAt(selectedIndex);
        }
    }
}

