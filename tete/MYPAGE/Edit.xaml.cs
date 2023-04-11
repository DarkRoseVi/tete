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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        public User user { get; set; }
        public Edit(User _user)
        {
            user = _user;
            InitializeComponent();
        
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            var UsId = Bdconnect.db.User.Where(x => x.Login == LoginTb.Text).FirstOrDefault();
            if (UsId == null)
            {
                Bdconnect.db.User.Add(new User
                {
                    Login = LoginTb.Text,
                    Password = PassswordTb.Text,
                    Name = NameTb.Text,
                    RoleId = 2
                });
                Bdconnect.db.SaveChanges();

                MessageBox.Show("yes");
            }
            Navigation.NextPage(new Nav("", new Listus())); 
        }
    }
}
