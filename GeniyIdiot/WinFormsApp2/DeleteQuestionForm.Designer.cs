namespace GeniyIdiotWinForm
{
    partial class DeleteQuestionForm
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
            numberDeleteLabel = new Label();
            questionsListBox = new ListBox();
            statusLabel = new Label();
            toolStripContainer1 = new ToolStripContainer();
            toolStripContainer2 = new ToolStripContainer();
            menuStrip1 = new MenuStrip();
            returnMenuStrip = new ToolStripMenuItem();
            exitMenuStrip = new ToolStripMenuItem();
            deleteQuestionButton = new Button();
            toolStripContainer1.SuspendLayout();
            toolStripContainer2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // numberDeleteLabel
            // 
            numberDeleteLabel.AutoSize = true;
            numberDeleteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberDeleteLabel.Location = new Point(255, 28);
            numberDeleteLabel.Name = "numberDeleteLabel";
            numberDeleteLabel.Size = new Size(261, 28);
            numberDeleteLabel.TabIndex = 0;
            numberDeleteLabel.Text = "Выдели удаляемый вопрос";
            // 
            // questionsListBox
            // 
            questionsListBox.FormattingEnabled = true;
            questionsListBox.Location = new Point(162, 72);
            questionsListBox.Name = "questionsListBox";
            questionsListBox.Size = new Size(466, 264);
            questionsListBox.TabIndex = 3;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusLabel.Location = new Point(292, 413);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(242, 28);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Статус: вопрос не удален";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(150, 150);
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(150, 175);
            toolStripContainer1.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            toolStripContainer2.ContentPanel.Size = new Size(150, 150);
            toolStripContainer2.Location = new Point(0, 0);
            toolStripContainer2.Name = "toolStripContainer2";
            toolStripContainer2.Size = new Size(150, 175);
            toolStripContainer2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { returnMenuStrip, exitMenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "Завершить тестирование";
            // 
            // returnMenuStrip
            // 
            returnMenuStrip.Name = "returnMenuStrip";
            returnMenuStrip.Size = new Size(248, 24);
            returnMenuStrip.Text = "Вернуться к предыдущему шагу ";
            returnMenuStrip.Click += returnMenuStrip_Click;
            // 
            // exitMenuStrip
            // 
            exitMenuStrip.Name = "exitMenuStrip";
            exitMenuStrip.Size = new Size(199, 24);
            exitMenuStrip.Text = "Завершить тестирование";
            exitMenuStrip.Click += exitMenuStrip_Click;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteQuestionButton.Location = new Point(238, 342);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(370, 68);
            deleteQuestionButton.TabIndex = 6;
            deleteQuestionButton.Text = "удалить вопрос";
            deleteQuestionButton.UseVisualStyleBackColor = true;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteQuestionButton);
            Controls.Add(statusLabel);
            Controls.Add(questionsListBox);
            Controls.Add(numberDeleteLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DeleteQuestionForm";
            Text = "Гений Идиот";
            Load += DeleteQuestionForm_Load;
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStripContainer2.ResumeLayout(false);
            toolStripContainer2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberDeleteLabel;
        private ListBox questionsListBox;
        private Label statusLabel;
        private ToolStripContainer toolStripContainer1;
        private ToolStripContainer toolStripContainer2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem returnMenuStrip;
        private ToolStripMenuItem exitMenuStrip;
        private Button deleteQuestionButton;
    }
}