namespace task4
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            listBox3 = new ListBox();
            label11 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox2 = new ListBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 57, 50);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.Location = new Point(12, 358);
            button5.Name = "button5";
            button5.Size = new Size(159, 30);
            button5.TabIndex = 15;
            button5.Text = "Təmizlə";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 322);
            button4.Name = "button4";
            button4.Size = new Size(159, 30);
            button4.TabIndex = 14;
            button4.Text = "Hesabla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(12, 283);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 19);
            listBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 5;
            label3.Text = "Qalıq:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(12, 210);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(91, 27);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 2;
            label2.Text = "Məbləğ:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Brush Script MT", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 132);
            label1.Name = "label1";
            label1.Size = new Size(109, 36);
            label1.TabIndex = 3;
            label1.Text = "Starbucks";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 57, 50);
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(label10);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(611, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 450);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(79, 404);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(98, 19);
            listBox3.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(18, 404);
            label11.Name = "label11";
            label11.Size = new Size(55, 19);
            label11.TabIndex = 12;
            label11.Text = "Hesab:";
            // 
            // button3
            // 
            button3.Location = new Point(18, 358);
            button3.Name = "button3";
            button3.Size = new Size(159, 30);
            button3.TabIndex = 11;
            button3.Text = "Yekun hesab";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(18, 322);
            button2.Name = "button2";
            button2.Size = new Size(159, 30);
            button2.TabIndex = 10;
            button2.Text = "Yenilə";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 286);
            button1.Name = "button1";
            button1.Size = new Size(159, 30);
            button1.TabIndex = 9;
            button1.Text = "Səbətdən sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.ForeColor = SystemColors.WindowText;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(18, 81);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(159, 199);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(64, 44);
            label10.Name = "label10";
            label10.Size = new Size(65, 26);
            label10.TabIndex = 7;
            label10.Text = "Səbət";
            label10.Click += label10_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(195, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(195, 132);
            label4.Name = "label4";
            label4.Size = new Size(120, 54);
            label4.TabIndex = 3;
            label4.Text = "Shaken Espresso $5.95";
            label4.Click += label4_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(339, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(339, 132);
            label5.Name = "label5";
            label5.Size = new Size(120, 54);
            label5.TabIndex = 5;
            label5.Text = "Caramel Macchiato $5.45";
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(485, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 117);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(485, 132);
            label6.Name = "label6";
            label6.Size = new Size(120, 54);
            label6.TabIndex = 7;
            label6.Text = "Cold Brew $4.95";
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(195, 210);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(120, 117);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(195, 330);
            label7.Name = "label7";
            label7.Size = new Size(120, 54);
            label7.TabIndex = 9;
            label7.Text = "Pumpkin Spice Latte $5.95";
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(339, 210);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 117);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(339, 330);
            label8.Name = "label8";
            label8.Size = new Size(120, 54);
            label8.TabIndex = 11;
            label8.Text = "Chocolate Mocha $5.45";
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(485, 210);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(120, 117);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(485, 330);
            label9.Name = "label9";
            label9.Size = new Size(120, 54);
            label9.TabIndex = 13;
            label9.Text = "Caffè Americano $4.25";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(pictureBox7);
            Controls.Add(label8);
            Controls.Add(pictureBox6);
            Controls.Add(label7);
            Controls.Add(pictureBox5);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Starbucks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox4;
        private Label label6;
        private PictureBox pictureBox5;
        private Label label7;
        private PictureBox pictureBox6;
        private Label label8;
        private PictureBox pictureBox7;
        private Label label9;
        private ListBox listBox2;
        private Label label10;
        private ListBox listBox3;
        private Label label11;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}
