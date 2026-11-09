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

namespace Listbox_gyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> termekekLista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            ListaFrissites();
        }

        private void ListaFrissites()
        {
            List<string> megjelenitettLista = new List<string>();

            for (int i = 0; i < termekekLista.Count; i++)
            {
                megjelenitettLista.Add((i + 1) + termekekLista[i]);
            }

            lbTermekek.ItemsSource = null;
            lbTermekek.ItemsSource = megjelenitettLista;

            DarabFrissites();
        }

        private void DarabFrissites()
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}