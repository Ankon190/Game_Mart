﻿namespace ProjectWin
{
    partial class AddGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGames));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            browseBtn = new Button();
            SubmitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(371, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(371, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(371, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(371, 229);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 23);
            textBox5.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(646, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(704, 287);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(75, 23);
            browseBtn.TabIndex = 6;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += button1_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(405, 280);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(75, 23);
            SubmitBtn.TabIndex = 7;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 8;
            label1.Text = "name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 68);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 9;
            label2.Text = "genre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 185);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 123);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 237);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 12;
            label5.Text = "discount";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 150);
            dataGridView1.TabIndex = 13;
            // 
            // AddGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 582);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubmitBtn);
            Controls.Add(browseBtn);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AddGames";
            Text = "AddGames";
            Load += AddGames_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private Button browseBtn;
        private Button SubmitBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
    }
}