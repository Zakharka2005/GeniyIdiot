namespace WinFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            nextButton = new Button();
            numberQuestionsLabel = new Label();
            textQuestionLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            restart = new ToolStripMenuItem();
            exit = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(90, 271);
            nextButton.Margin = new Padding(3, 2, 3, 2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(258, 60);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // numberQuestionsLabel
            // 
            numberQuestionsLabel.AutoSize = true;
            numberQuestionsLabel.BackColor = Color.White;
            numberQuestionsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberQuestionsLabel.Location = new Point(176, 56);
            numberQuestionsLabel.Name = "numberQuestionsLabel";
            numberQuestionsLabel.Size = new Size(93, 21);
            numberQuestionsLabel.TabIndex = 1;
            numberQuestionsLabel.Text = "Вопрос №1";
            // 
            // textQuestionLabel
            // 
            textQuestionLabel.AutoSize = true;
            textQuestionLabel.BackColor = Color.White;
            textQuestionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textQuestionLabel.Location = new Point(0, 103);
            textQuestionLabel.Name = "textQuestionLabel";
            textQuestionLabel.Size = new Size(111, 21);
            textQuestionLabel.TabIndex = 2;
            textQuestionLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(132, 231);
            userAnswerTextBox.Margin = new Padding(3, 2, 3, 2);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(190, 23);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { restart, exit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(461, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // restart
            // 
            restart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            restart.Name = "restart";
            restart.Size = new Size(217, 24);
            restart.Text = "Перезапустить приложение";
            restart.Click += restart_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exit.Name = "exit";
            exit.Size = new Size(178, 24);
            exit.Text = "Выйти из приложения";
            exit.Click += exit_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.White;
            timerLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timerLabel.Location = new Point(190, 197);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(79, 20);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "10 секунд ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(461, 342);
            Controls.Add(timerLabel);
            Controls.Add(userAnswerTextBox);
            Controls.Add(textQuestionLabel);
            Controls.Add(numberQuestionsLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Гений Идиот ";
            FormClosing += MainForm_FormClosing_1;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label numberQuestionsLabel;
        private Label textQuestionLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem restart;
        private ToolStripMenuItem exit;
        private System.Windows.Forms.Timer timer1;
        private Label timerLabel;
    }
}
