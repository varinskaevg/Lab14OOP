namespace Lab13OOP
{
    partial class DirectoryOperationsForm
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
            btnCreateDirectory = new Button();
            btnMoveDirectory = new Button();
            btnCopyDirectory = new Button();
            btnDeleteDirectory = new Button();
            txtDirectoryPath = new TextBox();
            txtSourceDirectoryPath = new TextBox();
            txtDestinationDirectoryPath = new TextBox();
            comboBoxDrives = new ComboBox();
            label3 = new Label();
            txtDirectoryPathAttributes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnApplyDirectoryAttributes = new Button();
            groupBox1 = new GroupBox();
            checkBoxArchive = new CheckBox();
            checkBoxHidden = new CheckBox();
            checkBoxReadOnly = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(301, 95);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(94, 29);
            btnCreateDirectory.TabIndex = 0;
            btnCreateDirectory.Text = "Створити";
            btnCreateDirectory.UseVisualStyleBackColor = true;
            btnCreateDirectory.Click += btnCreateDirectory_Click;
            // 
            // btnMoveDirectory
            // 
            btnMoveDirectory.Location = new Point(424, 159);
            btnMoveDirectory.Name = "btnMoveDirectory";
            btnMoveDirectory.Size = new Size(118, 29);
            btnMoveDirectory.TabIndex = 1;
            btnMoveDirectory.Text = "Перемістити";
            btnMoveDirectory.UseVisualStyleBackColor = true;
            btnMoveDirectory.Click += btnMoveDirectory_Click;
            // 
            // btnCopyDirectory
            // 
            btnCopyDirectory.Location = new Point(25, 229);
            btnCopyDirectory.Name = "btnCopyDirectory";
            btnCopyDirectory.Size = new Size(94, 29);
            btnCopyDirectory.TabIndex = 2;
            btnCopyDirectory.Text = "Копіювати";
            btnCopyDirectory.UseVisualStyleBackColor = true;
            btnCopyDirectory.Click += btnCopyDirectory_Click;
            // 
            // btnDeleteDirectory
            // 
            btnDeleteDirectory.Location = new Point(167, 229);
            btnDeleteDirectory.Name = "btnDeleteDirectory";
            btnDeleteDirectory.Size = new Size(94, 29);
            btnDeleteDirectory.TabIndex = 3;
            btnDeleteDirectory.Text = "Видалити";
            btnDeleteDirectory.UseVisualStyleBackColor = true;
            btnDeleteDirectory.Click += btnDeleteDirectory_Click;
            // 
            // txtDirectoryPath
            // 
            txtDirectoryPath.Location = new Point(12, 95);
            txtDirectoryPath.Name = "txtDirectoryPath";
            txtDirectoryPath.Size = new Size(268, 27);
            txtDirectoryPath.TabIndex = 4;
            // 
            // txtSourceDirectoryPath
            // 
            txtSourceDirectoryPath.Location = new Point(135, 142);
            txtSourceDirectoryPath.Name = "txtSourceDirectoryPath";
            txtSourceDirectoryPath.Size = new Size(268, 27);
            txtSourceDirectoryPath.TabIndex = 5;
            // 
            // txtDestinationDirectoryPath
            // 
            txtDestinationDirectoryPath.Location = new Point(135, 184);
            txtDestinationDirectoryPath.Name = "txtDestinationDirectoryPath";
            txtDestinationDirectoryPath.Size = new Size(268, 27);
            txtDestinationDirectoryPath.TabIndex = 6;
            // 
            // comboBoxDrives
            // 
            comboBoxDrives.FormattingEnabled = true;
            comboBoxDrives.Location = new Point(60, 32);
            comboBoxDrives.Name = "comboBoxDrives";
            comboBoxDrives.Size = new Size(259, 28);
            comboBoxDrives.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 35);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 20;
            label3.Text = "Шлях";
            // 
            // txtDirectoryPathAttributes
            // 
            txtDirectoryPathAttributes.Location = new Point(402, 33);
            txtDirectoryPathAttributes.Name = "txtDirectoryPathAttributes";
            txtDirectoryPathAttributes.Size = new Size(375, 27);
            txtDirectoryPathAttributes.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 21;
            label1.Text = "Диск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 182);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 23;
            label2.Text = "Переміщення в";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 22;
            label4.Text = "Переміщення з";
            // 
            // btnApplyDirectoryAttributes
            // 
            btnApplyDirectoryAttributes.Location = new Point(594, 217);
            btnApplyDirectoryAttributes.Name = "btnApplyDirectoryAttributes";
            btnApplyDirectoryAttributes.Size = new Size(183, 29);
            btnApplyDirectoryAttributes.TabIndex = 25;
            btnApplyDirectoryAttributes.Text = "Збереження Атрибутів";
            btnApplyDirectoryAttributes.UseVisualStyleBackColor = true;
            btnApplyDirectoryAttributes.Click += btnApplyDirectoryAttributes_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxArchive);
            groupBox1.Controls.Add(checkBoxHidden);
            groupBox1.Controls.Add(checkBoxReadOnly);
            groupBox1.Location = new Point(588, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 133);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Атрибути";
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
            // DirectoryOperationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApplyDirectoryAttributes);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtDirectoryPathAttributes);
            Controls.Add(comboBoxDrives);
            Controls.Add(txtDestinationDirectoryPath);
            Controls.Add(txtSourceDirectoryPath);
            Controls.Add(txtDirectoryPath);
            Controls.Add(btnDeleteDirectory);
            Controls.Add(btnCopyDirectory);
            Controls.Add(btnMoveDirectory);
            Controls.Add(btnCreateDirectory);
            Name = "DirectoryOperationsForm";
            Text = "Редагування каталогів";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateDirectory;
        private Button btnMoveDirectory;
        private Button btnCopyDirectory;
        private Button btnDeleteDirectory;
        private TextBox txtDirectoryPath;
        private TextBox txtSourceDirectoryPath;
        private TextBox txtDestinationDirectoryPath;
        private ComboBox comboBoxDrives;
        private Label label3;
        private TextBox txtDirectoryPathAttributes;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnApplyDirectoryAttributes;
        private GroupBox groupBox1;
        private CheckBox checkBoxArchive;
        private CheckBox checkBoxHidden;
        private CheckBox checkBoxReadOnly;
    }
}