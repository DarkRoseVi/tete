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
using tete.Componens;
using tete.MYPAGE;
namespace tete.MYPAGE
{
    /// <summary>
    /// Логика взаимодействия для Listus.xaml
    /// </summary>
    public partial class Listus : Page
    {
        public Listus()
        {
            InitializeComponent();
            UserList.ItemsSource = Bdconnect.db.User.ToList();
        }

        private void Deletbtn_Click(object sender, RoutedEventArgs e)
        {
            var us = (sender as Button).DataContext as User;
            if (MessageBox.Show("Вы точно хотите удалить эту запись", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var tiedReminders = us.Reminder;
                Bdconnect.db.Reminder.RemoveRange(tiedReminders);
                Bdconnect.db.User.Remove(us);
                Bdconnect.db.SaveChanges();
            }
            UserList.ItemsSource = Bdconnect.db.User.ToList();

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var us = (sender as Button).DataContext as User;
            Navigation.NextPage(new Nav("", new Edit(us)));
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new Nav("", new Edit(new User())));

        }
    }
}
