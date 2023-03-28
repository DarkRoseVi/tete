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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new Nav("ghghbv",new RegPage()));

            //string login = LoginTb.Text.Trim();
            //string password = PassworTb.Password.Trim();
            //if (login.Length > 0 && password.Length > 0)
            //{
            //    Navigation.AutoUser = Bdconnect.db.User.ToList().Find(x => x.Password == password && x.Login == login);
            //    if (Navigation.AutoUser == null)
            //    {
            //        MessageBox.Show("Вы кто");
            //    }
            //    else
            //    {
            //        Navigation.NextPage(new Nav("ghghbv", new RegPage()));
            //    }
            //}
            //else MessageBox.Show("Заполните поля");
        }
    }
}
