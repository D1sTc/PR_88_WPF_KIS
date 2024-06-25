using System;
using System.Collections.Generic;
using System.Data;
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

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();

        }

        private void Autorization_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MakingAnOrder winm = new MakingAnOrder();
            winm.Show();

            //// для администратора:

            //Close();
            //MainMenu mm = new MainMenu();
            //mm.Show();

        //if (loginBox.Text.Length > 0) // проверяем введён ли логин     
        //{
        //if (passwordBox.Password.Length > 0) // проверяем введён ли пароль         
        //{             // ищем в базе данных пользователя с такими данными         
        //DataTable dt_user = MainWindow.Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + loginBox.Text + "' AND [password] = '" + passwordBox.Password + "'");
        //if (dt_user.Rows.Count > 0) // если такая запись существует       
        //MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался         
        //else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
        //}
        //else MessageBox.Show("Введите пароль"); // выводим ошибку    
        //}
        //else MessageBox.Show("Введите логин"); // выводим ошибку 
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
