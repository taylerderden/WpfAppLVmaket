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
using System.Windows.Shapes;

namespace WpfAppLVGV.Windows
{
    /// <summary>
    /// Логика взаимодействия для lViewWindow.xaml
    /// </summary>
    public partial class lViewWindow : Window
    {
        public lViewWindow()
        {
            InitializeComponent();
            ListViewClient.ItemsSource = CoreModel.init().Clients.ToList();
        }
    }
}
