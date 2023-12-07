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
using WpfAppLVGV.Windows;

namespace WpfAppLVGV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Server = cfif31.ru; Port = 3306; User ID = ISPr23-35_RogozhnikovaYO; Database = ISPr23-35_RogozhnikovaYO_wpf; Password = ISPr23-35_RogozhnikovaYO; Character Set = utf8
        }

        private void DataGrid_Click(object sender, RoutedEventArgs e)
        {
            gViewWindow dataGrid = new gViewWindow();
            dataGrid.Show();
        }

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            lViewWindow listView = new lViewWindow();
            listView.Show();
        }
    }
}
