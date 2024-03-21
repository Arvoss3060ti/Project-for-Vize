namespace Project_for_Vize
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            UyeListeleButton = new Button();
            KitapListeleButton = new Button();
            EmanetListeleButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 111);
            button1.Name = "button1";
            button1.Size = new Size(221, 101);
            button1.TabIndex = 0;
            button1.Text = "Üye Ekleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(239, 111);
            button2.Name = "button2";
            button2.Size = new Size(221, 101);
            button2.TabIndex = 1;
            button2.Text = "Kitap Ekleme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(462, 111);
            button3.Name = "button3";
            button3.Size = new Size(221, 101);
            button3.TabIndex = 2;
            button3.Text = "Emanet ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(196, 36);
            label2.Name = "label2";
            label2.Size = new Size(314, 20);
            label2.TabIndex = 4;
            label2.Text = "LÜTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ.";
            // 
            // UyeListeleButton
            // 
            UyeListeleButton.Location = new Point(12, 255);
            UyeListeleButton.Name = "UyeListeleButton";
            UyeListeleButton.Size = new Size(221, 29);
            UyeListeleButton.TabIndex = 5;
            UyeListeleButton.Text = "Üye Listele";
            UyeListeleButton.UseVisualStyleBackColor = true;
            // 
            // KitapListeleButton
            // 
            KitapListeleButton.Location = new Point(239, 255);
            KitapListeleButton.Name = "KitapListeleButton";
            KitapListeleButton.Size = new Size(221, 29);
            KitapListeleButton.TabIndex = 6;
            KitapListeleButton.Text = "Kitap Listele";
            KitapListeleButton.UseVisualStyleBackColor = true;
            // 
            // EmanetListeleButton
            // 
            EmanetListeleButton.Location = new Point(462, 255);
            EmanetListeleButton.Name = "EmanetListeleButton";
            EmanetListeleButton.Size = new Size(221, 29);
            EmanetListeleButton.TabIndex = 7;
            EmanetListeleButton.Text = "Emanet Listele";
            EmanetListeleButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 364);
            Controls.Add(EmanetListeleButton);
            Controls.Add(KitapListeleButton);
            Controls.Add(UyeListeleButton);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button UyeListeleButton;
        private Button KitapListeleButton;
        private Button EmanetListeleButton;
    }
}
