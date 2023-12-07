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
            Update();

            cbSort.Items.Add("По возрастанию");
            cbSort.Items.Add("По убыванию");

            //List<Task> tasksCompletes = CoreModel.init().Tasks.ToList();
            //tasksCompletes.Insert(0, new Task { TasksComplete = "+" });

            cbFiltr.Items.Add("мужчины");
            cbFiltr.Items.Add("женщины");
            cbFiltr.Items.Add("все");
        }

        private void Update()
        {
            ListViewClient.ItemsSource = CoreModel.init().Clients.ToList();
        }
        private void UpdateSearch()
        {
            IEnumerable<Client> clients = CoreModel.init().Clients.Where(p => p.FirstName.Contains(tbSearch.Text) || p.LastName.Contains(tbSearch.Text));

            switch (cbSort.SelectedIndex)
            {
                case 0:
                    clients = clients.OrderBy(p => p.FirstName);
                    break;
                case 1:
                    clients = clients.OrderByDescending(p => p.FirstName);
                    break;
            }

            if (cbFiltr.SelectedItem == "мужчины")
            {
                clients = CoreModel.init().Clients.Where(p => p.GenderCode.Contains("м"));
            }
            else if (cbFiltr.SelectedItem == "женщины")
            {
                clients = CoreModel.init().Clients.Where(p => p.GenderCode.Contains("ж"));
            }
            else
            {
                Update();
            }

            ListViewClient.ItemsSource = clients.ToList();
        }
        private void tbSearchChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSearch();
        }

        private void cbSortChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSearch();
        }

        private void cbFiltrChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSearch();
        }
    }
}
