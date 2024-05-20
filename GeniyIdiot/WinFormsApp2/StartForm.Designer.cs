namespace GeniyIdiotWinForm
{
    partial class StartForm
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
            helloLabel = new Label();
            questionNameLabel = new Label();
            nameTextBox = new TextBox();
            furtherButton2 = new Button();
            SuspendLayout();
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helloLabel.Location = new Point(35, 49);
            helloLabel.Margin = new Padding(5, 0, 5, 0);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(498, 24);
            helloLabel.TabIndex = 0;
            helloLabel.Text = "Для прохождения теста необходимо ввести имя ";
            // 
            // questionNameLabel
            // 
            questionNameLabel.AutoSize = true;
            questionNameLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionNameLabel.Location = new Point(173, 113);
            questionNameLabel.Margin = new Padding(5, 0, 5, 0);
            questionNameLabel.Name = "questionNameLabel";
            questionNameLabel.Size = new Size(194, 24);
            questionNameLabel.TabIndex = 1;
            questionNameLabel.Text = "Введите ваше имя";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(144, 187);
            nameTextBox.Margin = new Padding(5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(254, 34);
            nameTextBox.TabIndex = 2;
            // 
            // furtherButton2
            // 
            furtherButton2.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            furtherButton2.Location = new Point(54, 244);
            furtherButton2.Margin = new Padding(5);
            furtherButton2.Name = "furtherButton2";
            furtherButton2.Size = new Size(436, 101);
            furtherButton2.TabIndex = 3;
            furtherButton2.Text = "Далее";
            furtherButton2.UseVisualStyleBackColor = true;
            furtherButton2.Click += furtherButton2_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 584);
            Controls.Add(furtherButton2);
            Controls.Add(nameTextBox);
            Controls.Add(questionNameLabel);
            Controls.Add(helloLabel);
            Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "StartForm";
            Text = "Гений Идиот";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helloLabel;
        private Label questionNameLabel;
        private TextBox nameTextBox;
        private Button furtherButton2;
    }
}