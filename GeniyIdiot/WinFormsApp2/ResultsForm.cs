﻿using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinForm
{
    public partial class ResultsForm : Form
    {
        string path = @"C:\TestGeniyIdiot";
        string fileNameResults = @"results.json";
        private User user = new User();
        public ResultsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void resultsForm_Load(object sender, EventArgs e)
        {
            currentResultLabel.Text = user.Name + ", количество правельных ответов: " + user.QuantityCorrectAnswers;
            currentResultLabel2.Text = "Ваш диагноз: " + user.Diagnose;
            UsersResultStorage.Append(user, path, fileNameResults);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resultsToolStripMenu_Click(object sender, EventArgs e)
        {
            ResultsTableForm resultsTableForm = new ResultsTableForm();
            resultsTableForm.ShowDialog();
        }

        private void addToolStripMenu_Click(object sender, EventArgs e)
        {
            AddQuestionsForm addQuestionsForm = new AddQuestionsForm();
            addQuestionsForm.ShowDialog();
        }

        private void deleteToolStripMenu_Click(object sender, EventArgs e)
        {
            DeleteQuestionForm deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.ShowDialog();
        }
    }
}
