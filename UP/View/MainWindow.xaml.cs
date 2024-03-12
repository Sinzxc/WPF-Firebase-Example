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
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;


namespace UP.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        async Task Authorizate()
        {
            DB db = new DB();
            var users = db.firebaseClient
                .Child("users")
                .OnceSingleAsync<User[]>().ToString();
            MessageBox.Show(users);
            /*if (users.FirstOrDefault(u => u.username == tb1.Text && u.password == tb2.Text) != null)
            {
                MessageBox.Show("Вошли");
            }
            else
                MessageBox.Show("Не вошли");*/
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await Authorizate();
        }

    }
}
