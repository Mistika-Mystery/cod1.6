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
using System.Data.Entity;

namespace cod1._6
{
    /// <summary>
    /// Логика взаимодействия для katalog.xaml
    /// </summary>
    public partial class katalog : Page
    {
        public katalog()
        {
            InitializeComponent();
        }

        private void tbback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btvhod_Click(object sender, RoutedEventArgs e)
        {
            
            var log = appdb.db.User.FirstOrDefault(x=> x.UserLogin == tblog.Text && x.UserPassword == tbpass.Text);
            if (log != null)
            {
                
                appdb.CurrentUser = log;
                NavigationService.Navigate(new tabl());
                
            }

            else
            {
                MessageBox.Show("Такого пользователя \n      не существует\nПопробуйте еще раз\n           ИЛИ\nЗарегестрируйтесь");
            }
        }
    }
    
}
