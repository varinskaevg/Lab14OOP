using System;
using System.IO;
using System.Windows.Forms;

namespace Lab13OOP
{
    public partial class DirectoryOperationsForm : Form
    {
        public DirectoryOperationsForm()
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

        // Метод для створення каталогу
        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(GetSelectedDrive(), txtDirectoryPath.Text);
                Directory.CreateDirectory(path);
                MessageBox.Show("Каталог створено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка створення каталогу: " + ex.Message);
            }
        }

        // Метод для перенесення каталогу
        private void btnMoveDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = Path.Combine(GetSelectedDrive(), txtSourceDirectoryPath.Text);
                string destinationPath = Path.Combine(GetSelectedDrive(), txtDestinationDirectoryPath.Text);
                Directory.Move(sourcePath, destinationPath);
                MessageBox.Show("Каталог перенесено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка перенесення каталогу: " + ex.Message);
            }
        }

        // Метод для копіювання каталогу
        private void btnCopyDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = Path.Combine(GetSelectedDrive(), txtSourceDirectoryPath.Text);
                string destinationPath = Path.Combine(GetSelectedDrive(), txtDestinationDirectoryPath.Text);
                CopyDirectory(sourcePath, destinationPath);
                MessageBox.Show("Каталог скопійовано успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка копіювання каталогу: " + ex.Message);
            }
        }

        private void CopyDirectory(string sourceDir, string destDir)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);
            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(destDir);

            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destDir, file.Name);
                file.CopyTo(targetFilePath, true);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string newDestDir = Path.Combine(destDir, subdir.Name);
                CopyDirectory(subdir.FullName, newDestDir);
            }
        }

        // Метод для видалення каталогу
        private void btnDeleteDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(GetSelectedDrive(), txtDirectoryPath.Text);
                Directory.Delete(path, true);
                MessageBox.Show("Каталог видалено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видалення каталогу: " + ex.Message);
            }
        }

        private void btnApplyDirectoryAttributes_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(GetSelectedDrive(), txtDirectoryPathAttributes.Text);
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                if (checkBoxReadOnly.Checked)
                {
                    dirInfo.Attributes |= FileAttributes.ReadOnly;
                }
                else
                {
                    dirInfo.Attributes &= ~FileAttributes.ReadOnly;
                }

                if (checkBoxHidden.Checked)
                {
                    dirInfo.Attributes |= FileAttributes.Hidden;
                }
                else
                {
                    dirInfo.Attributes &= ~FileAttributes.Hidden;
                }

                if (checkBoxArchive.Checked)
                {
                    dirInfo.Attributes |= FileAttributes.Archive;
                }
                else
                {
                    dirInfo.Attributes &= ~FileAttributes.Archive;
                }

                MessageBox.Show("Атрибути каталогу змінено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка зміни атрибутів каталогу: " + ex.Message);
            }
        }
    }
}
