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

namespace tete.MYPAGE
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();// trim удалят пробелы
            string password = PassworTb.Text.Trim();
            string name = NameTb.Text.Trim();        
            if (login.Length > 0 && password.Length > 0)
            {
                Bdconnect.db.User.Add(new User
                {
                    Login = login,
                    Password = password,
                    Name = name,
                    RoleId = 2
                });
                Bdconnect.db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");
                Navigation.BackPage();
            }
            else
                MessageBox.Show("Заполните поля !");
        }
    }
}
