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

namespace CRUD
{
    /// <summary>
    /// Логика взаимодействия для EditAptWindow.xaml
    /// </summary>
    public partial class EditAptWindow : Window
    {
        public static AptekaEntities _context;
        private Apt _apt;
        private MainWindow _window;
        public EditAptWindow(AptekaEntities context, object o, MainWindow mainWindow)
        {
            InitializeComponent();
            _apt = (o as Button).DataContext as Apt;
            _context = context;
            _window = mainWindow;
            TxtName.Text = _apt.name;
            TxtAdres.Text = _apt.adres;
            
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            _context.Apt.Remove(_apt);
            _context.SaveChanges();
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _apt.name = TxtName.Text;
            _apt.adres = TxtAdres.Text;

            _context.SaveChanges();
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }
    }
}
