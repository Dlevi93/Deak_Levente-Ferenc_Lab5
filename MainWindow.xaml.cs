using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Deak_Levente_Ferenc_Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Deak_Levente_Ferenc_Lab5.DataSet1 dataSet1 = ((Deak_Levente_Ferenc_Lab5.DataSet1)(this.FindResource("dataSet1")));
            // Load data into the table Customer. You can modify this code as needed.
            Deak_Levente_Ferenc_Lab5.DataSet1TableAdapters.CustomerTableAdapter dataSet1CustomerTableAdapter = new Deak_Levente_Ferenc_Lab5.DataSet1TableAdapters.CustomerTableAdapter();
            dataSet1CustomerTableAdapter.Fill(dataSet1.Customer);
            System.Windows.Data.CollectionViewSource customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));
            customerViewSource.View.MoveCurrentToFirst();
            // Load data into the table Inventory. You can modify this code as needed.
            Deak_Levente_Ferenc_Lab5.DataSet1TableAdapters.InventoryTableAdapter dataSet1InventoryTableAdapter = new Deak_Levente_Ferenc_Lab5.DataSet1TableAdapters.InventoryTableAdapter();
            dataSet1InventoryTableAdapter.Fill(dataSet1.Inventory);
            System.Windows.Data.CollectionViewSource inventoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("inventoryViewSource")));
            inventoryViewSource.View.MoveCurrentToFirst();
        }
    }
}
