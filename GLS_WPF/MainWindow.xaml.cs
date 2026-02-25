using GLS_CLI1;
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
using System.IO;

namespace GLS_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<AutoAdatok> autoLista = new List<AutoAdatok>();
        public MainWindow()
        {
            InitializeComponent();
            string[] adatok = File.ReadAllLines("GLS.txt");
            
            foreach (var item in adatok)
            {
                autoLista.Add(new AutoAdatok(item));
            }
            datagrid.ItemsSource = autoLista;
        }

        private void Felvitel_Click(object sender, RoutedEventArgs e)
        {
            if (autoLista.Find(x=>x.datum == datumBox.Text) != null)
            {
                MessageBox.Show("Már van ilyen dátum", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            AutoAdatok adat = new AutoAdatok(datumBox.Text, nevBox.Text, int.Parse(csomagokBox.Text), int.Parse(fogyasztasBox.Text), int.Parse(kmBox.Text));
            autoLista.Add(adat);
            datagrid.Items.Refresh();
        }

        private void Modositas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}