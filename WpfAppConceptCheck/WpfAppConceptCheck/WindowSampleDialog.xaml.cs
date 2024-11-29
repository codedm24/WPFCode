using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppConceptCheck
{
    /// <summary>
    /// Interaction logic for WindowSampleDialog.xaml
    /// </summary>
    public partial class WindowSampleDialog : Window
    {
        public WindowSampleDialog()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult= false;
        }

        private void btnOpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = "*.txt";
            dialog.Filter = "Text Documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                string fileName = dialog.FileName;
            }
        }
        private void btnSaveFileDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = "*.txt";
            dialog.Filter = "Text Documents (.txt)|(*.txt)";
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                string fileName = dialog.FileName;
            }
        }
        private void btnOpenFolderDialog_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.MultiSelect = false;
            //dialog.Title = "Select a folder";
            //bool? result = dialog.ShowDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string fullPathToFolder = dialog.SelectedPath;
                string folderNameOnly = System.IO.Path.GetFileName(fullPathToFolder.TrimEnd(System.IO.Path.DirectorySeparatorChar));
            }

        }
        private void btnPrintDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Controls.PrintDialog();
            dialog.PageRangeSelection = System.Windows.Controls.PageRangeSelection.AllPages;
            dialog.UserPageRangeEnabled=true;

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                //document printed
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.MainWindow = new MainWindow();
            System.Windows.Application.Current.MainWindow.Show();
            this.Close();
        }
    }
}
