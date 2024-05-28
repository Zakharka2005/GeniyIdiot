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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            nameTextBox = new TextBox();
            furtherButton2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(146, 210);
            nameTextBox.Margin = new Padding(5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(254, 29);
            nameTextBox.TabIndex = 2;
            // 
            // furtherButton2
            // 
            furtherButton2.BackgroundImage = (Image)resources.GetObject("furtherButton2.BackgroundImage");
            furtherButton2.BackgroundImageLayout = ImageLayout.Stretch;
            furtherButton2.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            furtherButton2.Location = new Point(181, 249);
            furtherButton2.Margin = new Padding(5);
            furtherButton2.Name = "furtherButton2";
            furtherButton2.Size = new Size(200, 85);
            furtherButton2.TabIndex = 3;
            furtherButton2.UseVisualStyleBackColor = true;
            furtherButton2.Click += furtherButton2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(542, 342);
            Controls.Add(pictureBox1);
            Controls.Add(furtherButton2);
            Controls.Add(nameTextBox);
            Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "StartForm";
            Text = "Гений Идиот";
            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameTextBox;
        private Button furtherButton2;
        private PictureBox pictureBox1;
    }
}