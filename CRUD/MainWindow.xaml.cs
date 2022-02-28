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

namespace CRUD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static AptekaEntities _context = new AptekaEntities();

        public MainWindow()
        {
            InitializeComponent();
            DataGridApteka.ItemsSource = _context.Apt.ToList();
        }

        private void BtnEditApt_Click(object sender, RoutedEventArgs e)
        {
            EditAptWindow ap = new EditAptWindow(_context, sender, this);
            ap.Show();
            this.Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddAptWindow ad = new AddAptWindow(_context, this);
            ad.Show();
            this.Close();
        }
    }
}
