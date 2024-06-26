using EMIAS.Model;
using EMIAS.ViewModel;
using EMIAS.ViewModel.Helpers;
using Newtonsoft.Json;
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

namespace EMIAS
{
    /// <summary>
    /// Логика взаимодействия для Authentication_window_admin.xaml
    /// </summary>
    public partial class Authentication_window_admin : Window
    {
        public Authentication_window_admin()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)// авторизация
        {

            var info = new { id = LogTextBox.Text, enterPassword = PasswordBox.Password }; //создаем массив из данных

            string json = JsonConvert.SerializeObject(info); // серилизация данных в json 

            try
            {
                string response = Api.Post(json, "Admins/PostAdminAuthorizen"); //создал переменную для получение api

                var adminResult = JsonConvert.DeserializeObject<List<Admin>>(response); // превращаю в переменные из json

                if (adminResult != null && adminResult.Count > 0)
                {
                    var admin = adminResult[0];

                    MessageBox.Show($"Welcome, Admin {admin.AdminName} {admin.Surname}. Your email is {admin.Email}");

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }


                string response2 = Api.Post(json, "Doctors/PostAdminAuthorizen");

                var doctorResult = JsonConvert.DeserializeObject<Doctor>(response);

                if (doctorResult != null && doctorResult.IdDoctor != 0)
                {
                    MessageBox.Show($"Welcome, Doctor {doctorResult.FirstName} {doctorResult.Surname}. Your speciality ID is {doctorResult.SpecialityId}");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Authentication_Window authentication_Window = new Authentication_Window();
            authentication_Window.Show();
            Close();
        }
    }
}
