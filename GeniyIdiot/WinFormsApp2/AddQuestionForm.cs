using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinForm
{
    public partial class AddQuestionsForm : Form
    {
        string path = @"C:\TestGeniyIdiot";
        string fileNameQuestions = @"questions.json";
        public AddQuestionsForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (questionsTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите вопрос");
                return;
            }
            int userAnswer;
            if (!int.TryParse(answerTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Ответ должен быть числовым");
                return;
            }


            var newQuestion = new Question(questionsTextBox.Text, userAnswer);
            QuestionsStorage.Add(newQuestion, path, fileNameQuestions);
            label1.Text = "Вопрос добавлен";
        }

        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
