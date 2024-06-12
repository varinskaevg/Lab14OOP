namespace Lab13OOP
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
            listBoxDrives = new ListBox();
            listBoxContent = new ListBox();
            textBoxPath = new TextBox();
            buttonApplyFilter = new Button();
            labelProperties = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxDirectoryFilter = new ComboBox();
            textBoxFileFilter = new TextBox();
            pictureBoxImage = new PictureBox();
            richTextBoxContent = new RichTextBox();
            btnRed1 = new Button();
            btnRed2 = new Button();
            btnRegText = new Button();
            btnArchive = new Button();
            btnExtract = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // listBoxDrives
            // 
            listBoxDrives.FormattingEnabled = true;
            listBoxDrives.Location = new Point(12, 12);
            listBoxDrives.Name = "listBoxDrives";
            listBoxDrives.Size = new Size(150, 104);
            listBoxDrives.TabIndex = 0;
            listBoxDrives.SelectedIndexChanged += listBoxDrives_SelectedIndexChanged;
            // 
            // listBoxContent
            // 
            listBoxContent.FormattingEnabled = true;
            listBoxContent.Location = new Point(192, 12);
            listBoxContent.Name = "listBoxContent";
            listBoxContent.Size = new Size(296, 104);
            listBoxContent.TabIndex = 1;
            listBoxContent.SelectedIndexChanged += listBoxContent_SelectedIndexChanged;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(581, 12);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(385, 27);
            textBoxPath.TabIndex = 2;
            // 
            // buttonApplyFilter
            // 
            buttonApplyFilter.Location = new Point(192, 211);
            buttonApplyFilter.Name = "buttonApplyFilter";
            buttonApplyFilter.Size = new Size(121, 40);
            buttonApplyFilter.TabIndex = 5;
            buttonApplyFilter.Text = "Пошук";
            buttonApplyFilter.UseVisualStyleBackColor = true;
            buttonApplyFilter.Click += buttonApplyFilter_Click;
            // 
            // labelProperties
            // 
            labelProperties.AutoSize = true;
            labelProperties.Location = new Point(581, 64);
            labelProperties.Name = "labelProperties";
            labelProperties.Size = new Size(50, 20);
            labelProperties.TabIndex = 6;
            labelProperties.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 137);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 7;
            label1.Text = "Фільт списків";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 177);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 8;
            label2.Text = "Фільт каталогів";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 12);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 9;
            label3.Text = "Шлях";
            // 
            // comboBoxDirectoryFilter
            // 
            comboBoxDirectoryFilter.FormattingEnabled = true;
            comboBoxDirectoryFilter.Location = new Point(130, 177);
            comboBoxDirectoryFilter.Name = "comboBoxDirectoryFilter";
            comboBoxDirectoryFilter.Size = new Size(250, 28);
            comboBoxDirectoryFilter.TabIndex = 11;
            // 
            // textBoxFileFilter
            // 
            textBoxFileFilter.Location = new Point(130, 137);
            textBoxFileFilter.Name = "textBoxFileFilter";
            textBoxFileFilter.Size = new Size(250, 27);
            textBoxFileFilter.TabIndex = 12;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(25, 316);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(536, 316);
            pictureBoxImage.TabIndex = 13;
            pictureBoxImage.TabStop = false;
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.Location = new Point(581, 316);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(543, 316);
            richTextBoxContent.TabIndex = 14;
            richTextBoxContent.Text = "";
            // 
            // btnRed1
            // 
            btnRed1.Location = new Point(386, 130);
            btnRed1.Name = "btnRed1";
            btnRed1.Size = new Size(112, 35);
            btnRed1.TabIndex = 15;
            btnRed1.Text = "Редагування";
            btnRed1.UseVisualStyleBackColor = true;
            btnRed1.Click += btnRed1_Click;
            // 
            // btnRed2
            // 
            btnRed2.Location = new Point(386, 177);
            btnRed2.Name = "btnRed2";
            btnRed2.Size = new Size(112, 35);
            btnRed2.TabIndex = 16;
            btnRed2.Text = "Редагування";
            btnRed2.UseVisualStyleBackColor = true;
            btnRed2.Click += btnRed2_Click;
            // 
            // btnRegText
            // 
            btnRegText.Location = new Point(581, 278);
            btnRegText.Name = "btnRegText";
            btnRegText.Size = new Size(543, 32);
            btnRegText.TabIndex = 17;
            btnRegText.Text = "Збереження тексту";
            btnRegText.UseVisualStyleBackColor = true;
            btnRegText.Click += btnRegText_Click;
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(49, 278);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(132, 32);
            btnArchive.TabIndex = 18;
            btnArchive.Text = "Запакувати";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // btnExtract
            // 
            btnExtract.Location = new Point(192, 278);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(117, 32);
            btnExtract.TabIndex = 19;
            btnExtract.Text = "Розпакувати";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 284);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 20;
            label4.Text = "ZIP:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 657);
            Controls.Add(label4);
            Controls.Add(btnExtract);
            Controls.Add(btnArchive);
            Controls.Add(btnRegText);
            Controls.Add(btnRed2);
            Controls.Add(btnRed1);
            Controls.Add(richTextBoxContent);
            Controls.Add(pictureBoxImage);
            Controls.Add(textBoxFileFilter);
            Controls.Add(comboBoxDirectoryFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelProperties);
            Controls.Add(buttonApplyFilter);
            Controls.Add(textBoxPath);
            Controls.Add(listBoxContent);
            Controls.Add(listBoxDrives);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxDrives;
        private ListBox listBoxContent;
        private TextBox textBoxPath;
        private Button buttonApplyFilter;
        private Label labelProperties;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxDirectoryFilter;
        private TextBox textBoxFileFilter;
        private PictureBox pictureBoxImage;
        private RichTextBox richTextBoxContent;
        private Button btnRed1;
        private Button btnRed2;
        private Button btnRegText;
        private Button btnArchive;
        private Button btnExtract;
        private Label label4;
    }
}
