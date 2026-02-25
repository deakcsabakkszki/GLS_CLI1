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
        public MainWindow()
        {
            InitializeComponent();
            string[] adatok = File.ReadAllLines("GLS.txt");
            List<AutoAdatok> autoLista = new List<AutoAdatok>();
            foreach (var item in adatok)
            {
                autoLista.Add(new AutoAdatok(item));
            }
            datagrid.ItemsSource = autoLista;
        }
    }
}