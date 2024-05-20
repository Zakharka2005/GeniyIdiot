namespace GeniyIdiotWinForm
{
    partial class AddQuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enteringQuestionLabel = new Label();
            questionsTextBox = new TextBox();
            answerLabel = new Label();
            answerTextBox = new TextBox();
            addButton = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            exitMenuStrip = new ToolStripMenuItem();
            returnMenuStrip = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // enteringQuestionLabel
            // 
            enteringQuestionLabel.AutoSize = true;
            enteringQuestionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enteringQuestionLabel.Location = new Point(367, 30);
            enteringQuestionLabel.Margin = new Padding(4, 0, 4, 0);
            enteringQuestionLabel.Name = "enteringQuestionLabel";
            enteringQuestionLabel.Size = new Size(224, 28);
            enteringQuestionLabel.TabIndex = 0;
            enteringQuestionLabel.Text = "Введите новый вопрос";
            // 
            // questionsTextBox
            // 
            questionsTextBox.Location = new Point(389, 96);
            questionsTextBox.Margin = new Padding(4);
            questionsTextBox.Name = "questionsTextBox";
            questionsTextBox.Size = new Size(170, 34);
            questionsTextBox.TabIndex = 1;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(352, 158);
            answerLabel.Margin = new Padding(4, 0, 4, 0);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(239, 28);
            answerLabel.TabIndex = 2;
            answerLabel.Text = "Введите ответ на вопрос";
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(418, 233);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(125, 34);
            answerTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.Location = new Point(376, 312);
            addButton.Name = "addButton";
            addButton.Size = new Size(215, 54);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить вопрос ";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 387);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitMenuStrip, returnMenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1191, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitMenuStrip
            // 
            exitMenuStrip.Name = "exitMenuStrip";
            exitMenuStrip.Size = new Size(203, 24);
            exitMenuStrip.Text = "Завершить тестирование ";
            exitMenuStrip.Click += exitMenuStrip_Click;
            // 
            // returnMenuStrip
            // 
            returnMenuStrip.Name = "returnMenuStrip";
            returnMenuStrip.Size = new Size(252, 24);
            returnMenuStrip.Text = "Вернуться  к предыдущему шагу ";
            returnMenuStrip.Click += returnMenuStrip_Click;
            // 
            // AddQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 630);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(answerTextBox);
            Controls.Add(answerLabel);
            Controls.Add(questionsTextBox);
            Controls.Add(enteringQuestionLabel);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "AddQuestionsForm";
            Text = "Гений Идиот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enteringQuestionLabel;
        private TextBox questionsTextBox;
        private Label answerLabel;
        private TextBox answerTextBox;
        private Button addButton;
        private Label label;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitMenuStrip;
        private ToolStripMenuItem returnMenuStrip;
    }
}