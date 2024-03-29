namespace Project_for_Vize
{
    partial class Form3
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
            KitapKaydetButton = new Button();
            YayinEviTextBox = new TextBox();
            YayinYiliTextBox = new TextBox();
            KitapAdiTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            KitapKoduTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // KitapKaydetButton
            // 
            KitapKaydetButton.Location = new Point(71, 320);
            KitapKaydetButton.Name = "KitapKaydetButton";
            KitapKaydetButton.Size = new Size(189, 82);
            KitapKaydetButton.TabIndex = 0;
            KitapKaydetButton.Text = "Kitabı Kaydet";
            KitapKaydetButton.UseVisualStyleBackColor = true;
            KitapKaydetButton.Click += KitapKaydetButton_Click;
            // 
            // YayinEviTextBox
            // 
            YayinEviTextBox.Location = new Point(71, 198);
            YayinEviTextBox.Name = "YayinEviTextBox";
            YayinEviTextBox.Size = new Size(189, 27);
            YayinEviTextBox.TabIndex = 1;
            // 
            // YayinYiliTextBox
            // 
            YayinYiliTextBox.Location = new Point(71, 131);
            YayinYiliTextBox.Name = "YayinYiliTextBox";
            YayinYiliTextBox.Size = new Size(189, 27);
            YayinYiliTextBox.TabIndex = 2;
            // 
            // KitapAdiTextBox
            // 
            KitapAdiTextBox.Location = new Point(71, 62);
            KitapAdiTextBox.Name = "KitapAdiTextBox";
            KitapAdiTextBox.Size = new Size(189, 27);
            KitapAdiTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "Kitap Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 108);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 5;
            label2.Text = "Kitap Yayın Yılı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 175);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 6;
            label3.Text = "Kitap Yayınevi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 245);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 7;
            label4.Text = "Kitap Kodu :";
            // 
            // KitapKoduTextBox
            // 
            KitapKoduTextBox.Location = new Point(71, 268);
            KitapKoduTextBox.Name = "KitapKoduTextBox";
            KitapKoduTextBox.Size = new Size(189, 27);
            KitapKoduTextBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(238, 408);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 413);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Yükle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 459);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(KitapKoduTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KitapAdiTextBox);
            Controls.Add(YayinYiliTextBox);
            Controls.Add(YayinEviTextBox);
            Controls.Add(KitapKaydetButton);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button KitapKaydetButton;
        private TextBox YayinEviTextBox;
        private TextBox YayinYiliTextBox;
        private TextBox KitapAdiTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox KitapKoduTextBox;
        private Button button1;
        private Button button2;
    }
}