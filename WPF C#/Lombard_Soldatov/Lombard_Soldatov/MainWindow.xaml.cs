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

namespace Lombard_Soldatov
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

        public void DBCon()
        {
            Model.LombardEntities db = new Model.LombardEntities();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTxtBox.Text == "")
            {
                MessageBox.Show("Вы не ввели логин!");
            }
            else
            {
                if (PasswordTxtBox.Text == "")
                {
                    MessageBox.Show("Вы не ввели пароль!");
                }
                else
                {
                    if (Controller.DBConnection.GetContext().User.Any(a => a.Login == LoginTxtBox.Text) == true)
                    {
                        var User = Controller.DBConnection.GetContext().User.Where(a => a.Login == LoginTxtBox.Text).First();
                        if (User.Password == PasswordTxtBox.Text)
                        {

                            MessageBox.Show("Вы авторизированы!");
                        }
                        else
                        {
                            MessageBox.Show("Вы ввели неправильный пароль!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не существует!");
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginTxtBox.Clear();
            PasswordTxtBox.Clear();
        }
    }
}
