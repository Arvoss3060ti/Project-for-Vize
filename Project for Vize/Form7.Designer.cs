﻿namespace Project_for_Vize
{
    partial class Form7
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 284);
            button1.Name = "button1";
            button1.Size = new Size(238, 88);
            button1.TabIndex = 0;
            button1.Text = "Emanet Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 45);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Emanet Edilen Üye No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 126);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 2;
            label2.Text = "Emanet Edilen Kitap Kodu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 204);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 3;
            label3.Text = "Emanet Teslim Tarihi :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 27);
            textBox3.TabIndex = 6;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 406);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}