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
            nextButton.Location = new Point(102, 268);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(295, 80);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // numberQuestionsLabel
            // 
            numberQuestionsLabel.AutoSize = true;
            numberQuestionsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberQuestionsLabel.Location = new Point(170, 61);
            numberQuestionsLabel.Name = "numberQuestionsLabel";
            numberQuestionsLabel.Size = new Size(118, 28);
            numberQuestionsLabel.TabIndex = 1;
            numberQuestionsLabel.Text = "Вопрос №1";
            // 
            // textQuestionLabel
            // 
            textQuestionLabel.AutoSize = true;
            textQuestionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textQuestionLabel.Location = new Point(41, 131);
            textQuestionLabel.Name = "textQuestionLabel";
            textQuestionLabel.Size = new Size(142, 28);
            textQuestionLabel.TabIndex = 2;
            textQuestionLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(139, 205);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(216, 27);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { restart, exit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(724, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // restart
            // 
            restart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            restart.Name = "restart";
            restart.Size = new Size(252, 29);
            restart.Text = "Перезапустить приложение";
            restart.Click += restart_Click;
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.Size = new Size(180, 29);
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
            timerLabel.Location = new Point(437, 43);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(79, 20);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "10 секунд ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 456);
            Controls.Add(timerLabel);
            Controls.Add(userAnswerTextBox);
            Controls.Add(textQuestionLabel);
            Controls.Add(numberQuestionsLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
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
