namespace GeniyIdiotWinForm
{
    partial class ResultsTableForm
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
            dataGridView = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            correctAnswers = new DataGridViewTextBoxColumn();
            diagnose = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { name, correctAnswers, diagnose });
            dataGridView.Location = new Point(12, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(763, 426);
            dataGridView.TabIndex = 0;
            // 
            // Name
            // 
            name.HeaderText = "Имя";
            name.MinimumWidth = 6;
            name.Name = "Name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // correctAnswers
            // 
            correctAnswers.HeaderText = "Количество правильных ответов ";
            correctAnswers.MinimumWidth = 6;
            correctAnswers.Name = "correctAnswers";
            correctAnswers.ReadOnly = true;
            correctAnswers.Width = 125;
            // 
            // Diagnose
            // 
            diagnose.HeaderText = "Диагноз";
            diagnose.MinimumWidth = 6;
            diagnose.Name = "Diagnose";
            diagnose.ReadOnly = true;
            diagnose.Width = 125;
            // 
            // ResultsTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Text = "Гений Идиот";
            Load += ResultsTableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn correctAnswers;
        private DataGridViewTextBoxColumn diagnose;
    }
}