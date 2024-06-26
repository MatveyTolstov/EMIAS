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


            var info = new { id = LogTextBox.Text, enterPassword = PasswordBox.Password.ToString() }; //создаем массив из данных

            string json = JsonConvert.SerializeObject(info); // серилизация данных в json 

            try
            {
                // Проверка авторизации администратора
                string response = Api.Post(json, "Admins/PostAdminAuthorizen"); // создаем переменную для получения ответа API

                var adminResult = JsonConvert.DeserializeObject<Admin>(response); // превращаем json в объект Admin

                if (adminResult != null && adminResult.IdAdmin != 0)
                {
                    MessageBox.Show($"Welcome, Admin {adminResult.AdminName} {adminResult.Surname}. Your email is {adminResult.Email}");

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    return; // если админ найден, выходим из метода
                }

                // Проверка авторизации доктора
                string response2 = Api.Post(json, "Doctors/PostDoctorAuthorizen");

                var doctorResult = JsonConvert.DeserializeObject<List<Doctor>>(response2); // превращаем json в список объектов Doctor

                if (doctorResult != null && doctorResult.Count > 0)
                {
                    var doctor = doctorResult[0];
                    MessageBox.Show($"Welcome, Doctor {doctor.FirstName} {doctor.Surname}. Your speciality ID is {doctor.SpecialityId}");
                    return;
                }

                // Если ни админ, ни доктор не авторизованы, выводим сообщение об ошибке
                MessageBox.Show("Invalid credentials or user not found.");
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
