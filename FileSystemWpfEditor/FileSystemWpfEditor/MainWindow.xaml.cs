using Microsoft.Win32;
using System.IO;
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

namespace FileSystemWpfEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] lines = new string[] { "line1", "line2", "lin3" };
            string linetext = lines[1];
            linetext = linetext + " updated"; 
        }

        private void OnOpen(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Title = "Simple Editor - Open File",
                CheckPathExists = true,
                CheckFileExists = true,
                Filter = "Text Files (*.txt)|*.txt|All Files|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (dlg.ShowDialog() == true)
            { 
                text1.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void OnSave(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Title = "Simple Editor - Save As",
                DefaultExt = "txt",
                Filter = "Text Files (*.txt)|*.txt|All Files|*.*",
            };

            if(dlg.ShowDialog() == true)
            {
                File.WriteAllText(dlg.FileName, text1.Text);
            }
        }
    }
}