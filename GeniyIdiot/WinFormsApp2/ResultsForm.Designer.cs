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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            currentResultLabel = new Label();
            currentResultLabel2 = new Label();
            exitButton = new Button();
            menuStrip1 = new MenuStrip();
            resultsToolStripMenu = new ToolStripMenuItem();
            questionsToolStripMenu = new ToolStripMenuItem();
            addToolStripMenu = new ToolStripMenuItem();
            deleteToolStripMenu = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // currentResultLabel
            // 
            currentResultLabel.AutoSize = true;
            currentResultLabel.BackColor = Color.White;
            currentResultLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            currentResultLabel.Location = new Point(99, 60);
            currentResultLabel.Margin = new Padding(4, 0, 4, 0);
            currentResultLabel.Name = "currentResultLabel";
            currentResultLabel.Size = new Size(314, 19);
            currentResultLabel.TabIndex = 0;
            currentResultLabel.Text = "Имя/Количество правельных ответов";
            // 
            // currentResultLabel2
            // 
            currentResultLabel2.AutoSize = true;
            currentResultLabel2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentResultLabel2.Location = new Point(215, 106);
            currentResultLabel2.Margin = new Padding(4, 0, 4, 0);
            currentResultLabel2.Name = "currentResultLabel2";
            currentResultLabel2.Size = new Size(78, 19);
            currentResultLabel2.TabIndex = 2;
            currentResultLabel2.Text = "Диагноз ";
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = (Image)resources.GetObject("exitButton.BackgroundImage");
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Location = new Point(178, 304);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(308, 58);
            exitButton.TabIndex = 5;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { resultsToolStripMenu, questionsToolStripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(535, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // resultsToolStripMenu
            // 
            resultsToolStripMenu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultsToolStripMenu.Name = "resultsToolStripMenu";
            resultsToolStripMenu.Size = new Size(195, 24);
            resultsToolStripMenu.Text = "Результаты прошлых игр";
            resultsToolStripMenu.Click += resultsToolStripMenu_Click;
            // 
            // questionsToolStripMenu
            // 
            questionsToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenu, deleteToolStripMenu });
            questionsToolStripMenu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionsToolStripMenu.Name = "questionsToolStripMenu";
            questionsToolStripMenu.Size = new Size(84, 24);
            questionsToolStripMenu.Text = "Вопросы";
            // 
            // addToolStripMenu
            // 
            addToolStripMenu.Name = "addToolStripMenu";
            addToolStripMenu.Size = new Size(201, 24);
            addToolStripMenu.Text = "Добавить вопрос";
            addToolStripMenu.Click += addToolStripMenu_Click;
            // 
            // deleteToolStripMenu
            // 
            deleteToolStripMenu.Name = "deleteToolStripMenu";
            deleteToolStripMenu.Size = new Size(201, 24);
            deleteToolStripMenu.Text = "Удалить вопрос";
            deleteToolStripMenu.Click += deleteToolStripMenu_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(535, 388);
            Controls.Add(exitButton);
            Controls.Add(currentResultLabel2);
            Controls.Add(currentResultLabel);
            Controls.Add(menuStrip1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ResultsForm";
            Text = "Гений Идиот";
            Load += resultsForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentResultLabel;
        private Label currentResultLabel2;
        private Button exitButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem resultsToolStripMenu;
        private ToolStripMenuItem questionsToolStripMenu;
        private ToolStripMenuItem addToolStripMenu;
        private ToolStripMenuItem deleteToolStripMenu;
    }
}