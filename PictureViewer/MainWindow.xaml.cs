using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PictureViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var browser = new System.Windows.Forms.FolderBrowserDialog();
            browser.ShowDialog();
            var selectedDirectory = new System.IO.DirectoryInfo(browser.SelectedPath);
            var files = selectedDirectory.GetFiles();
            //MessageBox.Show("You chose: " + selectedDirectory + " containing " + files.Length + " files.");
            dataGridPictures.ItemsSource = files;
        }
    }
}