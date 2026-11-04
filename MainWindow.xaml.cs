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

namespace SDIproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button _selectedEl;
        StackPanel _stackSelectedEl;
        public MainWindow()
        {
            InitializeComponent();
            _stackSelectedEl = (StackPanel)BtnPython.Parent;
        }

        private void SwithSelect(object sender, RoutedEventArgs e)
        {
            _stackSelectedEl.Style = null;
            _selectedEl = (Button)sender;
            _stackSelectedEl = (StackPanel)_selectedEl.Parent;

            _stackSelectedEl.Style = (Style)this.FindResource("SelectedButtonMenu");
        }
    }
}