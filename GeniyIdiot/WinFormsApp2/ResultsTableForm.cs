using GeniyIdiotClassLibrary;
using Microsoft.VisualBasic.ApplicationServices;

namespace GeniyIdiotWinForm
{
    public partial class ResultsTableForm : Form
    {
        string path = @"C:\TestGeniyIdiot";
        string fileNameResults = @"results.json";
        public ResultsTableForm()
        {
            InitializeComponent();
        }
        private void ResultsTableForm_Load(object sender, EventArgs e)
        {
            var results = UsersResultStorage.Get(path, fileNameResults);
            dataGridView.Rows.Add(results.Count);

            for (int i = 0; i < results.Count; ++i)
            {
                dataGridView.Rows[i].Cells[0].Value = results[i].Name;
                dataGridView.Rows[i].Cells[1].Value = results[i].QuantityCorrectAnswers;
                dataGridView.Rows[i].Cells[2].Value = results[i].Diagnose;
            }
        }
    }
}
