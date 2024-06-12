using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Lab13OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������������ ��������� ����� ��� ������� ��������
            LoadDrives();
            // ����������� ��������� ���� ��� �������� ���������
            listBoxDrives.SelectedIndexChanged += listBoxDrives_SelectedIndexChanged;
            listBoxContent.SelectedIndexChanged += listBoxContent_SelectedIndexChanged;
            buttonApplyFilter.Click += buttonApplyFilter_Click;
            // ����������� �����-����� ���������� ��������
            InitializeDirectoryFilterComboBox();

            btnRegText.Click += btnRegText_Click;
            btnArchive.Click += btnArchive_Click;
            btnExtract.Click += btnExtract_Click;
        }

        // ����� ��� ������������ ��������� �����
        private void LoadDrives()
        {
            listBoxDrives.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                listBoxDrives.Items.Add(drive.Name);
            }
        }

        // ����� ��� ����������� �����-����� ���������� ��������
        private void InitializeDirectoryFilterComboBox()
        {
            comboBoxDirectoryFilter.Items.Clear();
            comboBoxDirectoryFilter.Items.Add("�� �������� (*.*)");
            comboBoxDirectoryFilter.Items.Add("*.txt");
            comboBoxDirectoryFilter.Items.Add("*.exe");
            comboBoxDirectoryFilter.Items.Add("*.doc");
            comboBoxDirectoryFilter.SelectedIndex = 0; // ������������ �������� �� ������������� �� "�� ��������"
        }

        // �������� ��䳿 ������ ����� � ������ �����
        private void listBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDrives.SelectedItem != null)
            {
                string selectedDrive = listBoxDrives.SelectedItem.ToString();
                textBoxPath.Text = selectedDrive;
                LoadDirectoryContent(selectedDrive);
                ShowDriveProperties(selectedDrive);
            }
        }

        // �������� ��䳿 ������ �������� � ������ ����� ��������
        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContent.SelectedItem != null)
            {
                string selectedPath = Path.Combine(textBoxPath.Text, listBoxContent.SelectedItem.ToString());
                if (Directory.Exists(selectedPath))
                {
                    textBoxPath.Text = selectedPath;
                    LoadDirectoryContent(selectedPath);
                    ShowDirectoryProperties(selectedPath);
                }
                else if (File.Exists(selectedPath))
                {
                    textBoxPath.Text = selectedPath;
                    string fileExtension = Path.GetExtension(selectedPath).ToLower();

                    if (IsImageFile(fileExtension))
                    {
                        // ³���������� ���������� � PictureBox
                        pictureBoxImage.ImageLocation = selectedPath;
                    }
                    else if (IsTextFile(fileExtension))
                    {
                        // ³���������� ���������� ����� � RichTextBox
                        ShowTextFile(selectedPath);
                    }
                    else
                    {
                        // ���� ���� �����, ����� ������ ����� ��� �� �������
                        ShowFileProperties(selectedPath);
                    }
                }
            }
        }

        private bool IsImageFile(string fileExtension)
        {
            return fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif";
        }

        private bool IsTextFile(string fileExtension)
        {
            return fileExtension == ".txt" || fileExtension == ".doc" || fileExtension == ".docx";
        }

        private void ShowTextFile(string filePath)
        {
            try
            {
                // ������������ ������ � ����� �� ����������� � RichTextBox
                richTextBoxContent.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                // ³���������� ������������ �����
                ShowFileProperties(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ����������� ���������� �����: " + ex.Message);
            }
        }

        // ����� ��� ������������ ����� ��������
        private void LoadDirectoryContent(string path)
        {
            listBoxContent.Items.Clear();
            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                string directoryFilter = GetDirectoryFilterFromComboBox();
                string fileFilter = textBoxFileFilter.Text;

                foreach (string directory in directories)
                {
                    if (string.IsNullOrEmpty(directoryFilter) || directory.EndsWith(directoryFilter))
                    {
                        listBoxContent.Items.Add(Path.GetFileName(directory));
                    }
                }

                foreach (string file in files)
                {
                    if (string.IsNullOrEmpty(fileFilter) || Path.GetFileName(file).Contains(fileFilter))
                    {
                        listBoxContent.Items.Add(Path.GetFileName(file));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ ����� ��������: " + ex.Message);
            }
        }

        // ����� ��� ����������� ������������ �����
        private void ShowDriveProperties(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            labelProperties.Text = $"���� {drive.Name}\n" +
                                   $"���: {drive.DriveType}\n" +
                                   $"������: {drive.DriveFormat}\n" +
                                   $"��������� �����: {drive.TotalSize}\n" +
                                   $"��������� ������: {drive.AvailableFreeSpace}";
        }

        // ����� ��� ����������� ������������ ��������
        private void ShowDirectoryProperties(string path)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                labelProperties.Text = $"������� {directory.Name}\n" +
                                       $"����� �����: {directory.FullName}\n" +
                                       $"���������: {directory.CreationTime}\n" +
                                       $"������� ������: {directory.LastAccessTime}\n" +
                                       $"������ ����: {directory.LastWriteTime}\n" +
                                       $"�����: {directory.Root}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ����������� ������������ ��������: " + ex.Message);
            }
        }

        // ����� ��� ����������� ������������ ����� �� ���� �����
        private void ShowFileProperties(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                string fileContent = File.ReadAllText(path);

                // �������� ����� RichTextBox ����� ������������ ������ �����
                richTextBoxContent.Clear();
                // ��������� ����� ���������� ����� �� RichTextBox
                richTextBoxContent.AppendText(fileContent);

                labelProperties.Text = $"���� {file.Name}\n" +
                                       $"����� �����: {file.FullName}\n" +
                                       $"�����: {file.Length}\n" +
                                       $"���������: {file.CreationTime}\n" +
                                       $"������� ������: {file.LastAccessTime}\n" +
                                       $"������ ����: {file.LastWriteTime}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ����������� ������������ �����: " + ex.Message);
            }
        }

        // ����� ��� ������� ���������� ������ ������������ �������
        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            LoadDirectoryContent(textBoxPath.Text);

            string fileNameFilter = textBoxFileFilter.Text;
            if (!string.IsNullOrEmpty(fileNameFilter))
            {
                FilterFilesByName(fileNameFilter);
            }
        }

        // ����� ��� ��������� ������� �������� � �����-�����

        private string GetDirectoryFilterFromComboBox()
        {
            switch (comboBoxDirectoryFilter.SelectedIndex)
            {
                case 0:
                    return null;
                default:
                    return comboBoxDirectoryFilter.SelectedItem.ToString();
            }
        }
        private void FilterFilesByName(string fileNameFilter)
        {
            for (int i = listBoxContent.Items.Count - 1; i >= 0; i--)
            {
                string listItem = listBoxContent.Items[i].ToString();
                if (!listItem.Contains(fileNameFilter))
                {
                    listBoxContent.Items.RemoveAt(i);
                }
            }
        }

        private void btnRed1_Click(object sender, EventArgs e)
        {
            DirectoryOperationsForm directoryOperationsForm = new DirectoryOperationsForm();
            directoryOperationsForm.Show();
        }

        private void btnRed2_Click(object sender, EventArgs e)
        {
            FileOperationsForm fileOperationsForm = new FileOperationsForm();
            fileOperationsForm.Show();
        }
        // �������� ��䳿 ��� ������ btnRegText
        private void btnRegText_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }
        // ����� ��� ���������� ������ � richTextBoxContent � ����
        private void SaveTextFile()
        {
            try
            {
                string filePath = textBoxPath.Text;
                if (File.Exists(filePath) && IsTextFile(Path.GetExtension(filePath)))
                {
                    File.WriteAllText(filePath, richTextBoxContent.Text);
                    MessageBox.Show("���� ������ ����������.");
                }
                else
                {
                    MessageBox.Show("��������� �������� ����. ��������, �� �� ��������� ����.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ���������� �����: " + ex.Message);
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ArchiveFiles();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            ExtractFiles();
        }

        // ����� ��� ��������� ����� � ZIP
        private void ArchiveFiles()
        {
            try
            {
                string sourceDirectory = textBoxPath.Text;
                string zipPath = sourceDirectory + ".zip";

                if (Directory.Exists(sourceDirectory))
                {
                    ZipFile.CreateFromDirectory(sourceDirectory, zipPath);
                    MessageBox.Show("������� ������ ������������.");
                }
                else
                {
                    MessageBox.Show("������� �� ��������.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ���������: " + ex.Message);
            }
        }

        // ����� ��� ������������ ����� � ZIP
        private void ExtractFiles()
        {
            try
            {
                string zipPath = textBoxPath.Text;
                string extractPath = Path.Combine(Path.GetDirectoryName(zipPath), Path.GetFileNameWithoutExtension(zipPath));

                if (File.Exists(zipPath) && Path.GetExtension(zipPath).Equals(".zip", StringComparison.OrdinalIgnoreCase))
                {
                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                    MessageBox.Show("����� ������ �����������.");
                }
                else
                {
                    MessageBox.Show("���� ������ �� �������� ��� �� �� � ZIP-������.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������: " + ex.Message);
            }
        }
    }
}
