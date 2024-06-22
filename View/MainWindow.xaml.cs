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
using EMIAS.View;
using EMIAS.ViewModel;

namespace EMIAS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel(); // Xaml xaml.cs -> MainViewModel

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Appointment_Doc_Black white = new Appointment_Doc_Black();
            white.Show();
            Close();
        }
    }
}
