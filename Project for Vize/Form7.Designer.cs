namespace Project_for_Vize
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
            EmanetUyeNo = new TextBox();
            EmanetKitapKod = new TextBox();
            EmanetTeslimTarihi = new TextBox();
            button2 = new Button();
            button3 = new Button();
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
            button1.Click += button1_Click;
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
            // EmanetUyeNo
            // 
            EmanetUyeNo.Location = new Point(56, 68);
            EmanetUyeNo.Name = "EmanetUyeNo";
            EmanetUyeNo.Size = new Size(276, 27);
            EmanetUyeNo.TabIndex = 4;
            // 
            // EmanetKitapKod
            // 
            EmanetKitapKod.Location = new Point(56, 149);
            EmanetKitapKod.Name = "EmanetKitapKod";
            EmanetKitapKod.Size = new Size(276, 27);
            EmanetKitapKod.TabIndex = 5;
            // 
            // EmanetTeslimTarihi
            // 
            EmanetTeslimTarihi.Location = new Point(56, 227);
            EmanetTeslimTarihi.Name = "EmanetTeslimTarihi";
            EmanetTeslimTarihi.Size = new Size(276, 27);
            EmanetTeslimTarihi.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(303, 378);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 378);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Yükle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 418);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(EmanetTeslimTarihi);
            Controls.Add(EmanetKitapKod);
            Controls.Add(EmanetUyeNo);
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
        private TextBox EmanetUyeNo;
        private TextBox EmanetKitapKod;
        private TextBox EmanetTeslimTarihi;
        private Button button2;
        private Button button3;
    }
}