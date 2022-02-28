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
    /// Логика взаимодействия для AddAptWindow.xaml
    /// </summary>
    public partial class AddAptWindow : Window
    {
        private AptekaEntities _context;
        private MainWindow _window;
        public AddAptWindow(AptekaEntities aptekaEntities, MainWindow mainWindow)
        {
            InitializeComponent();
            this._context = aptekaEntities;
            this._window = mainWindow;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            _context.Apt.Add(new Apt() { name = TxtName.Text, adres = TxtAdres.Text });
            _context.SaveChanges();
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }
    }
}
