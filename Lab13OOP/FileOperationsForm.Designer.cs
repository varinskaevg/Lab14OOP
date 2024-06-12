namespace Lab13OOP
{
    partial class FileOperationsForm
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
            txtDestinationFilePath = new TextBox();
            txtSourceFilePath = new TextBox();
            txtFilePath = new TextBox();
            btnDeleteFile = new Button();
            btnCopyFile = new Button();
            btnMoveFile = new Button();
            btnCreateFile = new Button();
            comboBoxDrives = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtFilePathAttributes = new TextBox();
            label3 = new Label();
            checkBoxReadOnly = new CheckBox();
            checkBoxHidden = new CheckBox();
            checkBoxArchive = new CheckBox();
            groupBox1 = new GroupBox();
            btnApplyFileAttributes = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDestinationFilePath
            // 
            txtDestinationFilePath.Location = new Point(128, 172);
            txtDestinationFilePath.Name = "txtDestinationFilePath";
            txtDestinationFilePath.Size = new Size(268, 27);
            txtDestinationFilePath.TabIndex = 13;
            // 
            // txtSourceFilePath
            // 
            txtSourceFilePath.Location = new Point(127, 139);
            txtSourceFilePath.Name = "txtSourceFilePath";
            txtSourceFilePath.Size = new Size(268, 27);
            txtSourceFilePath.TabIndex = 12;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(4, 81);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(268, 27);
            txtFilePath.TabIndex = 11;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(178, 229);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(94, 29);
            btnDeleteFile.TabIndex = 10;
            btnDeleteFile.Text = "Видалити";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnCopyFile
            // 
            btnCopyFile.Location = new Point(56, 229);
            btnCopyFile.Name = "btnCopyFile";
            btnCopyFile.Size = new Size(94, 29);
            btnCopyFile.TabIndex = 9;
            btnCopyFile.Text = "Копіювати";
            btnCopyFile.UseVisualStyleBackColor = true;
            btnCopyFile.Click += btnCopyFile_Click;
            // 
            // btnMoveFile
            // 
            btnMoveFile.Location = new Point(402, 153);
            btnMoveFile.Name = "btnMoveFile";
            btnMoveFile.Size = new Size(118, 29);
            btnMoveFile.TabIndex = 8;
            btnMoveFile.Text = "Перемістити";
            btnMoveFile.UseVisualStyleBackColor = true;
            btnMoveFile.Click += btnMoveFile_Click;
            // 
            // btnCreateFile
            // 
            btnCreateFile.Location = new Point(290, 79);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(94, 29);
            btnCreateFile.TabIndex = 7;
            btnCreateFile.Text = "Створити";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // comboBoxDrives
            // 
            comboBoxDrives.FormattingEnabled = true;
            comboBoxDrives.Location = new Point(66, 30);
            comboBoxDrives.Name = "comboBoxDrives";
            comboBoxDrives.Size = new Size(268, 28);
            comboBoxDrives.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 142);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 15;
            label1.Text = "Переміщення з";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 175);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 16;
            label2.Text = "Переміщення в";
            // 
            // txtFilePathAttributes
            // 
            txtFilePathAttributes.Location = new Point(413, 31);
            txtFilePathAttributes.Name = "txtFilePathAttributes";
            txtFilePathAttributes.Size = new Size(375, 27);
            txtFilePathAttributes.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 34);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 18;
            label3.Text = "Шлях";
            // 
            // checkBoxReadOnly
            // 
            checkBoxReadOnly.AutoSize = true;
            checkBoxReadOnly.Location = new Point(6, 31);
            checkBoxReadOnly.Name = "checkBoxReadOnly";
            checkBoxReadOnly.Size = new Size(164, 24);
            checkBoxReadOnly.TabIndex = 19;
            checkBoxReadOnly.Text = "Тільки для читання";
            checkBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxHidden
            // 
            checkBoxHidden.AutoSize = true;
            checkBoxHidden.Location = new Point(6, 61);
            checkBoxHidden.Name = "checkBoxHidden";
            checkBoxHidden.Size = new Size(119, 24);
            checkBoxHidden.TabIndex = 20;
            checkBoxHidden.Text = "Прихований";
            checkBoxHidden.UseVisualStyleBackColor = true;
            // 
            // checkBoxArchive
            // 
            checkBoxArchive.AutoSize = true;
            checkBoxArchive.Location = new Point(6, 93);
            checkBoxArchive.Name = "checkBoxArchive";
            checkBoxArchive.Size = new Size(96, 24);
            checkBoxArchive.TabIndex = 21;
            checkBoxArchive.Text = "Архівний";
            checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxArchive);
            groupBox1.Controls.Add(checkBoxHidden);
            groupBox1.Controls.Add(checkBoxReadOnly);
            groupBox1.Location = new Point(591, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 133);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Атрибути";
            // 
            // btnApplyFileAttributes
            // 
            btnApplyFileAttributes.Location = new Point(597, 220);
            btnApplyFileAttributes.Name = "btnApplyFileAttributes";
            btnApplyFileAttributes.Size = new Size(183, 29);
            btnApplyFileAttributes.TabIndex = 23;
            btnApplyFileAttributes.Text = "Збереження Атрибутів";
            btnApplyFileAttributes.UseVisualStyleBackColor = true;
            btnApplyFileAttributes.Click += btnApplyFileAttributes_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 34);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 24;
            label4.Text = "Диск";
            // 
            // FileOperationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnApplyFileAttributes);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtFilePathAttributes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDrives);
            Controls.Add(txtDestinationFilePath);
            Controls.Add(txtSourceFilePath);
            Controls.Add(txtFilePath);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnCopyFile);
            Controls.Add(btnMoveFile);
            Controls.Add(btnCreateFile);
            Name = "FileOperationsForm";
            Text = "Редагування файлів";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDestinationFilePath;
        private TextBox txtSourceFilePath;
        private TextBox txtFilePath;
        private Button btnDeleteFile;
        private Button btnCopyFile;
        private Button btnMoveFile;
        private Button btnCreateFile;
        private ComboBox comboBoxDrives;
        private Label label1;
        private Label label2;
        private TextBox txtFilePathAttributes;
        private Label label3;
        private CheckBox checkBoxReadOnly;
        private CheckBox checkBoxHidden;
        private CheckBox checkBoxArchive;
        private GroupBox groupBox1;
        private Button btnApplyFileAttributes;
        private Label label4;
    }
}