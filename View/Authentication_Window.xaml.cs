using EMIAS.Model;
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
    /// Логика взаимодействия для Authentication_Window.xaml
    /// </summary>
    public partial class Authentication_Window : Window
    {
        public Authentication_Window()
        {
            InitializeComponent();
        }

        private void DoctorButton_Click(object sender, RoutedEventArgs e)
        {
            Authentication_window_admin authentication_Window_Admin = new Authentication_window_admin();
            authentication_Window_Admin.Show();
            Close();
        }

        private void SignButton_Click(object sender, RoutedEventArgs e)
        {
            var info = new { id = NumberPolicyButton.Text};

            string json = JsonConvert.SerializeObject(info);



            try
            {
                string response = Api.Post(json, "Patients/PostPatientAuthorizen"); // создаем переменную для получения ответа API

                var adminResult = JsonConvert.DeserializeObject<List<Patient>>(response); // превращаем json в объект Admin

                if (adminResult != null && adminResult.Count != 0)
                {

                    var patient = adminResult[0];
                    MessageBox.Show($"Welcome, Admin {patient.FirstName} {patient.Surname}. Your email is {patient.Email}");

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    return; // если админ найден, выходим из метода
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
