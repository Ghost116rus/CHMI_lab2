using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorksWithFilesLibrary;

namespace lab3_forms
{
    public partial class MainForm : Form
    {

        private readonly WorkWithFiles _fileOperator;
        private string _rootDir;
        private string _curFileChosen;
        public MainForm(string rootdir)
        {
            _rootDir = rootdir;
            _fileOperator = new WorkWithFiles(rootdir);
            InitializeComponent();
            this.CurrentDirLbl.Text = rootdir;
            UpdateListOfFiles();
        }

        private void UpdateListOfFiles()
        {
            this.FilesListBox.Items.Clear();
            this.FilesListBox.Items.AddRange(_fileOperator.GetAllFiles());
        }

        private void AddFile(string filename)
        {
            var res = _fileOperator.CreateFile(filename);
            if (res == -2)
            {
                MessageBox.Show($"{filename} - неправильное расширение файла!");
            }
            else if (res == -1)
            {
                MessageBox.Show("Произошла ошибка при создании файла");
            }
            else
            {
                MessageBox.Show("Файл успешно создан");
                UpdateListOfFiles();
            }
        }

        private void ChangeDirBySelected()
        {
            var selectedItem = FilesListBox.SelectedItem;
            if (selectedItem != null && Directory.Exists(selectedItem.ToString()))
            {

                try
                {
                    _fileOperator.ChangeDirectory(selectedItem.ToString());
                    this.CurrentDirLbl.Text = selectedItem.ToString();
                    UpdateListOfFiles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла непредвиденная ошибка\nПопробуйте перезапустить программу\nОшибка: {ex.Message}");
                }
            }
        }

        private void DeleteFile()
        {
            var selectedItem = FilesListBox.SelectedItem;
            var res = _fileOperator.DeleteFile(selectedItem.ToString());
            if (res == -2)
            {
                MessageBox.Show($"{selectedItem} - такого файла не существует");
            }
            else if (res == -1)
            {
                MessageBox.Show("Произошла ошибка при удалении файла");
            }
            else
            {
                MessageBox.Show("Файл успешно удалён");
                UpdateListOfFiles();
            }

        }


        private void GoBackDirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _fileOperator.ChangeDirectory("..");
                this.CurrentDirLbl.Text = _fileOperator.CurrentDirectory;
                UpdateListOfFiles();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Произошла непредвиденная ошибка\nПопробуйте перезапустить программу\nОшибка: {ex.Message}");
            }
        }

        private void ShowDirBtn_Click(object sender, EventArgs e)
        {
           UpdateListOfFiles();
        }

        private void ChangeDirBtn_Click(object sender, EventArgs e)
        {
            ChangeDirBySelected();
        }

        private void FilesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChangeDirBySelected();
        }

        private void AddFileBtn_Click(object sender, EventArgs e)
        {
            var addfile =  new AddFileDiaglogForm(AddFile);
            addfile.ShowDialog();
        }

        private void DeleteFileBtn_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
    }
}
