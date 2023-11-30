
namespace Test_FormApp
{
    partial class Upload
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            trackBar1 = new TrackBar();
            WebCamRedirect = new Button();
            ExcelRedirect = new Button();
            USB_Checker = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(218, 27);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 124);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 170);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(15, 219);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(596, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 356);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Location = new Point(896, 409);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(170, 29);
            button2.TabIndex = 10;
            button2.Text = "Upload a Picture";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(154, 219);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(144, 56);
            trackBar1.TabIndex = 14;
            trackBar1.Value = 4;
            // 
            // WebCamRedirect
            // 
            WebCamRedirect.Location = new Point(15, 409);
            WebCamRedirect.Name = "WebCamRedirect";
            WebCamRedirect.Size = new Size(122, 29);
            WebCamRedirect.TabIndex = 15;
            WebCamRedirect.Text = "Open WebCam ";
            WebCamRedirect.UseVisualStyleBackColor = true;
            WebCamRedirect.Click += WebCamRedirect_Click;
            // 
            // ExcelRedirect
            // 
            ExcelRedirect.Location = new Point(166, 409);
            ExcelRedirect.Name = "ExcelRedirect";
            ExcelRedirect.Size = new Size(94, 29);
            ExcelRedirect.TabIndex = 16;
            ExcelRedirect.Text = "Open Excel";
            ExcelRedirect.UseVisualStyleBackColor = true;
            ExcelRedirect.Click += ExcelRedirect_Click;
            // 
            // USB_Checker
            // 
            USB_Checker.Location = new Point(291, 409);
            USB_Checker.Name = "USB_Checker";
            USB_Checker.Size = new Size(126, 29);
            USB_Checker.TabIndex = 17;
            USB_Checker.Text = "USB Checker";
            USB_Checker.UseVisualStyleBackColor = true;
            USB_Checker.Click += USB_Checker_Click;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 451);
            Controls.Add(USB_Checker);
            Controls.Add(ExcelRedirect);
            Controls.Add(WebCamRedirect);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Upload";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private TrackBar trackBar1;
        private Button WebCamRedirect;
        private Button ExcelRedirect;
        private Button USB_Checker;
    }
}