namespace Project_for_Vize
{
    partial class Form2
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
            ogrenciAdiTextBox = new TextBox();
            ogrenciSoyadiTextBox = new TextBox();
            ogrenciNoTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            OgrenciSistemeEkleButton = new Button();
            SuspendLayout();
            // 
            // ogrenciAdiTextBox
            // 
            ogrenciAdiTextBox.Location = new Point(154, 79);
            ogrenciAdiTextBox.Name = "ogrenciAdiTextBox";
            ogrenciAdiTextBox.Size = new Size(204, 27);
            ogrenciAdiTextBox.TabIndex = 0;
            // 
            // ogrenciSoyadiTextBox
            // 
            ogrenciSoyadiTextBox.Location = new Point(154, 138);
            ogrenciSoyadiTextBox.Name = "ogrenciSoyadiTextBox";
            ogrenciSoyadiTextBox.Size = new Size(204, 27);
            ogrenciSoyadiTextBox.TabIndex = 1;
            // 
            // ogrenciNoTextBox
            // 
            ogrenciNoTextBox.Location = new Point(154, 201);
            ogrenciNoTextBox.Name = "ogrenciNoTextBox";
            ogrenciNoTextBox.Size = new Size(204, 27);
            ogrenciNoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 49);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 115);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 178);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci No :";
            // 
            // OgrenciSistemeEkleButton
            // 
            OgrenciSistemeEkleButton.Location = new Point(154, 281);
            OgrenciSistemeEkleButton.Name = "OgrenciSistemeEkleButton";
            OgrenciSistemeEkleButton.Size = new Size(204, 65);
            OgrenciSistemeEkleButton.TabIndex = 6;
            OgrenciSistemeEkleButton.Text = "Ekle";
            OgrenciSistemeEkleButton.UseVisualStyleBackColor = true;
            OgrenciSistemeEkleButton.Click += OgrenciSistemeEkleButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 413);
            Controls.Add(OgrenciSistemeEkleButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ogrenciNoTextBox);
            Controls.Add(ogrenciSoyadiTextBox);
            Controls.Add(ogrenciAdiTextBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ogrenciAdiTextBox;
        private TextBox ogrenciSoyadiTextBox;
        private TextBox ogrenciNoTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button OgrenciSistemeEkleButton;
    }
}