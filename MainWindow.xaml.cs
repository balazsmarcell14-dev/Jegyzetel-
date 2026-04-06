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

namespace jegyzetelo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextWriterAndReader _textWriterAndReader = new TextWriterAndReader();
        private DocumentList _documents = new DocumentList();
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _textWriterAndReader.Save(tbContent.Text);

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            if (saveFileDialog.ShowDialog() == true)
            {
                _textWriterAndReader.FilePath = saveFileDialog.FileName;
                _textWriterAndReader.CreateFile();
                _documents.AddDocument(_textWriterAndReader.FilePath);

                showFiles.ItemsSource = null;
                showFiles.ItemsSource = _documents.Documents;
                
            }
        }

        private void showFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (showFiles.SelectedItem == null)
            {
                return;
            }
            _textWriterAndReader.FilePath = showFiles.SelectedItem.ToString();
            tbContent.Text = _textWriterAndReader.ReadFile();
        }
    }
}