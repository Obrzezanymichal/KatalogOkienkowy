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

namespace KatalogOkienkowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Produkt> produkty = new List<Produkt>
            {
                new Produkt("Procesor intel core i9", 1500.00, "Procesory",10),
                new Produkt("Karta graficzna NVIDIA geforce rtx 3080", 4000.00, "Karty graficzne",5),
                new Produkt("Płyta glowna asus ROG strix Z590-e", 1200.00, "Płyty głowne",8),
                new Produkt("Dysk SSD Samsung 970 EVO plus 1TB", 600.00, "Dyski SSD",15),
            };

            EtykietaLiczby.Text = $"Liczba produktow: {produkty.Count}";
        }
    }
}