namespace Test_FormApp
{
    partial class ExcelNew
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
            dataGridView1 = new DataGridView();
            Upload = new Button();
            Process = new Button();
            Read = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(209, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(850, 652);
            dataGridView1.TabIndex = 0;
            // 
            // Upload
            // 
            Upload.Location = new Point(12, 12);
            Upload.Name = "Upload";
            Upload.Size = new Size(182, 67);
            Upload.TabIndex = 1;
            Upload.Text = "Upload a file";
            Upload.UseVisualStyleBackColor = true;
            Upload.Click += Upload_Click;
            // 
            // Process
            // 
            Process.Location = new Point(12, 116);
            Process.Name = "Process";
            Process.Size = new Size(182, 67);
            Process.TabIndex = 2;
            Process.Text = "Process";
            Process.UseVisualStyleBackColor = true;
            Process.Click += Process_Click;
            // 
            // Read
            // 
            Read.Location = new Point(12, 586);
            Read.Name = "Read";
            Read.Size = new Size(182, 67);
            Read.TabIndex = 3;
            Read.Text = "Read file";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // ExcelNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 665);
            Controls.Add(Read);
            Controls.Add(Process);
            Controls.Add(Upload);
            Controls.Add(dataGridView1);
            Name = "ExcelNew";
            Text = "ExcelNew";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button Process;
        private Button Read;
        private Button Upload;
    }
}