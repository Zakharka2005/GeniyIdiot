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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionsForm));
            questionsTextBox = new TextBox();
            answerTextBox = new TextBox();
            addButton = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            exitMenuStrip = new ToolStripMenuItem();
            returnMenuStrip = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // questionsTextBox
            // 
            questionsTextBox.Location = new Point(80, 87);
            questionsTextBox.Margin = new Padding(4);
            questionsTextBox.Name = "questionsTextBox";
            questionsTextBox.Size = new Size(170, 29);
            questionsTextBox.TabIndex = 1;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(80, 180);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(170, 29);
            answerTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.BackgroundImage = (Image)resources.GetObject("addButton.BackgroundImage");
            addButton.BackgroundImageLayout = ImageLayout.Stretch;
            addButton.Location = new Point(46, 215);
            addButton.Name = "addButton";
            addButton.Size = new Size(248, 59);
            addButton.TabIndex = 4;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 387);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitMenuStrip, returnMenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(337, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitMenuStrip
            // 
            exitMenuStrip.Name = "exitMenuStrip";
            exitMenuStrip.Size = new Size(161, 20);
            exitMenuStrip.Text = "Завершить тестирование ";
            exitMenuStrip.Click += exitMenuStrip_Click;
            // 
            // returnMenuStrip
            // 
            returnMenuStrip.Name = "returnMenuStrip";
            returnMenuStrip.Size = new Size(203, 20);
            returnMenuStrip.Text = "Вернуться  к предыдущему шагу ";
            returnMenuStrip.Click += returnMenuStrip_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(137, 299);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 9;
            // 
            // AddQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(337, 342);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(answerTextBox);
            Controls.Add(questionsTextBox);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "AddQuestionsForm";
            Text = "Гений Идиот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox questionsTextBox;
        private TextBox answerTextBox;
        private Button addButton;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitMenuStrip;
        private ToolStripMenuItem returnMenuStrip;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}