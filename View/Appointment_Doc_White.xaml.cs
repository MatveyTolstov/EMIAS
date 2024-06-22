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
using System.ComponentModel;

namespace EMIAS.View
{
    /// <summary>
    /// Логика взаимодействия для Appointment_Doc_White.xaml
    /// </summary>
    public partial class Appointment_Doc_White : Window
    {

        public Appointment_Doc_White()
        {
            InitializeComponent();
        }
        private void OnMainMenuButtonClick(object sender, RoutedEventArgs e)
        {
            MainMenuStackPanel.Visibility = MainMenuStackPanel.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }

        private void OnMedCardButtonClick(object sender, RoutedEventArgs e)
        {
            MedCardStackPanel.Visibility = MedCardStackPanel.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }

        private void OnIrinaButtonClick(object sender, RoutedEventArgs e)
        {
            if (IrinaMenuStackPanel.Visibility == Visibility.Collapsed)
            {
                IrinaMenuStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                IrinaMenuStackPanel.Visibility = Visibility.Collapsed;
            }
        }

        private void OnGearButtonClick(object sender, RoutedEventArgs e)
        {
            if (OnGearStackPanel.Visibility == Visibility.Collapsed)
            {
                OnGearStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                OnGearStackPanel.Visibility = Visibility.Collapsed;
            }
        }


        private void OnExitClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Обработчик выхода
            MessageBox.Show("Выход");
        }

        private void OnDarkThemeClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Appointment_Doc_Black white = new Appointment_Doc_Black();
            white.Show();
            Close();

        }
    }
}





