namespace WinFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(332, 352);
            pictureBox1.Margin = new Padding(7, 8, 7, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(982, 406);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 41);
            label1.TabIndex = 1;
            label1.Text = "한영탁";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(982, 479);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(326, 41);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터 sw 학과 재학생";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(982, 559);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(280, 41);
            label3.TabIndex = 3;
            label3.Text = "yt2342@naver.com";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(982, 635);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(229, 41);
            label4.TabIndex = 4;
            label4.Text = "010-8353-2342";
            // 
            // button1
            // 
            button1.Location = new Point(982, 714);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(274, 63);
            button1.TabIndex = 5;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1299, 719);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 6;
            button2.Text = "Github";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1543, 719);
            button3.Name = "button3";
            button3.Size = new Size(293, 58);
            button3.TabIndex = 7;
            button3.Text = "배경 이미지 바꾸기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1943, 1230);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
