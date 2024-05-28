
using GeniyIdiotClassLibrary;
using System.IO;
using WinFormsApp2;

namespace GeniyIdiotWinForm
{
    public partial class StartForm : System.Windows.Forms.Form
    {
        string path = @"C:\TestGeniyIdiot";
        private User user = new User();
        public StartForm()
        {
            InitializeComponent();
        }

        private void furtherButton2_Click(object sender, EventArgs e)
        {
            while (nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите свое имя, это обязательно");
                return;
            }
            user.Name = nameTextBox.Text;
            MainForm mainForm = new MainForm(user);
            mainForm.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            FileProvider.CreateDirectory(path);
        }
    }
}
