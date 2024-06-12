using System;
using System.IO;
using System.Windows.Forms;

namespace Lab13OOP
{
    public partial class FileOperationsForm : Form
    {
        public FileOperationsForm()
        {
            InitializeComponent();
            LoadDrives();
        }

        // Метод для завантаження доступних дисків
        private void LoadDrives()
        {
            comboBoxDrives.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                comboBoxDrives.Items.Add(drive.Name);
            }
            if (comboBoxDrives.Items.Count > 0)
            {
                comboBoxDrives.SelectedIndex = 0; // Встановлення значення за замовчуванням
            }
        }

        // Метод для отримання обраного диска
        private string GetSelectedDrive()
        {
            return comboBoxDrives.SelectedItem.ToString();
        }

        // Метод для створення файлу
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(GetSelectedDrive(), txtFilePath.Text);
                File.Create(path).Close();
                MessageBox.Show("Файл створено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка створення файлу: " + ex.Message);
            }
        }

        // Метод для перенесення файлу
        private void btnMoveFile_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = Path.Combine(GetSelectedDrive(), txtSourceFilePath.Text);
                string destinationPath = Path.Combine(GetSelectedDrive(), txtDestinationFilePath.Text);
                File.Move(sourcePath, destinationPath);
                MessageBox.Show("Файл перенесено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка перенесення файлу: " + ex.Message);
            }
        }

        // Метод для копіювання файлу
        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = Path.Combine(GetSelectedDrive(), txtSourceFilePath.Text);
                string destinationPath = Path.Combine(GetSelectedDrive(), txtDestinationFilePath.Text);
                File.Copy(sourcePath, destinationPath, true);
                MessageBox.Show("Файл скопійовано успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка копіювання файлу: " + ex.Message);
            }
        }

        // Метод для видалення файлу
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(GetSelectedDrive(), txtFilePath.Text);
                File.Delete(path);
                MessageBox.Show("Файл видалено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видалення файлу: " + ex.Message);
            }
        }

        private void btnApplyFileAttributes_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(GetSelectedDrive(), txtFilePathAttributes.Text);
                FileInfo fileInfo = new FileInfo(path);

                if (checkBoxReadOnly.Checked)
                {
                    fileInfo.Attributes |= FileAttributes.ReadOnly;
                }
                else
                {
                    fileInfo.Attributes &= ~FileAttributes.ReadOnly;
                }

                if (checkBoxHidden.Checked)
                {
                    fileInfo.Attributes |= FileAttributes.Hidden;
                }
                else
                {
                    fileInfo.Attributes &= ~FileAttributes.Hidden;
                }

                if (checkBoxArchive.Checked)
                {
                    fileInfo.Attributes |= FileAttributes.Archive;
                }
                else
                {
                    fileInfo.Attributes &= ~FileAttributes.Archive;
                }

                MessageBox.Show("Атрибути файлу змінено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка зміни атрибутів файлу: " + ex.Message);
            }
        }
    }
}
