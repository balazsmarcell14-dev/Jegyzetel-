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
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _textWriterAndReader.Save(tbContent.Text);

        }


        private void tbContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            _textWriterAndReader.loadFile(namingFile.Text);
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            namingFile.Visibility = Visibility.Visible;
            saveNameButton.Visibility = Visibility.Visible;
        }

        private void saveNameButton_Click(object sender, RoutedEventArgs e)
        {
            _textWriterAndReader.saveFileName(namingFile.Text);
            namingFile.Visibility = Visibility.Collapsed;
            saveNameButton.Visibility = Visibility.Collapsed;
        }

        private void namingFile_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void showFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}