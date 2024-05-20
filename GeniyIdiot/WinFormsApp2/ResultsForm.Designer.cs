namespace GeniyIdiotWinForm
{
    partial class ResultsForm
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
            currentResultLabel = new Label();
            resultsButton = new Button();
            currentResultLabel2 = new Label();
            deleteButton = new Button();
            addButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // currentResultLabel
            // 
            currentResultLabel.AutoSize = true;
            currentResultLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            currentResultLabel.Location = new Point(377, 48);
            currentResultLabel.Margin = new Padding(4, 0, 4, 0);
            currentResultLabel.Name = "currentResultLabel";
            currentResultLabel.Size = new Size(385, 24);
            currentResultLabel.TabIndex = 0;
            currentResultLabel.Text = "Имя/Количество правельных ответов";
            // 
            // resultsButton
            // 
            resultsButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsButton.Location = new Point(186, 150);
            resultsButton.Margin = new Padding(4, 3, 4, 3);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(778, 81);
            resultsButton.TabIndex = 1;
            resultsButton.Text = "Посмотреть результаты прошлых тестирований";
            resultsButton.UseVisualStyleBackColor = true;
            resultsButton.Click += resultsButton_Click;
            // 
            // currentResultLabel2
            // 
            currentResultLabel2.AutoSize = true;
            currentResultLabel2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentResultLabel2.Location = new Point(520, 99);
            currentResultLabel2.Margin = new Padding(4, 0, 4, 0);
            currentResultLabel2.Name = "currentResultLabel2";
            currentResultLabel2.Size = new Size(95, 24);
            currentResultLabel2.TabIndex = 2;
            currentResultLabel2.Text = "Диагноз ";
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(186, 238);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(778, 80);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить вопрос";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(186, 325);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(778, 80);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить вопрос";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(186, 412);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(778, 77);
            exitButton.TabIndex = 5;
            exitButton.Text = "Завершить тестирование";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 518);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(currentResultLabel2);
            Controls.Add(resultsButton);
            Controls.Add(currentResultLabel);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ResultsForm";
            Text = "Гений Идиот";
            Load += resultsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentResultLabel;
        private Button resultsButton;
        private Label currentResultLabel2;
        private Button deleteButton;
        private Button addButton;
        private Button exitButton;
    }
}