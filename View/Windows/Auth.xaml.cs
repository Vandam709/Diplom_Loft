using Diplom_Loft.AppData.Helpers;
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

namespace Diplom_Loft.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = ClassConnect.panas.Profiles.Where(i => i.Login == LogTb.Text && i.Password == PassTb.Password).FirstOrDefault();
            var userCheck = ClassConnect.panas.Profiles.Where(i => i.IdRole == 2).FirstOrDefault();
            if (userCheck != null && user == null)
            {
                MessageBox.Show("Пользователь не найден");
                LogTb.Text = "";
                PassTb.Password = "";
                return;
            }
            else
            {
                Osnovnoe oknoProfile = new Osnovnoe();
                oknoProfile.Show();
                Close();
                LogTb.Text = "";
                PassTb.Password = "";
            }
           

           
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Registration oknoRegistration = new Registration();
            oknoRegistration.Show();
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void CloseAppBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
