using System.Runtime.InteropServices;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMIAS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xF010;
        private const int HTCAPTION = 0x2;

        public MainWindow()
        {
            InitializeComponent();
            PagesFrame.Content = new MainPagePatient();
            MainFrame.Navigate(new Uri("MainWindow.xaml", UriKind.Relative));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ReleaseCapture();
            SendMessage(new System.Windows.Interop.WindowInteropHelper(this).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Authentication_Window aut = new Authentication_Window();
            aut.Show();
            Close();

        }

        private void NavigateToPage(object sender, RoutedEventArgs e)
        {
            if (sender is TreeViewItem selectedItem)
            {
                string page = selectedItem.Tag.ToString();
                switch (page)
                {
                    case "MainWindow":
                        MainFrame.Navigate(new Uri("MainWindow.xaml", UriKind.Relative));
                        break;
                    case "Appointment":
                        MainFrame.Navigate(new Uri("Appointment.xaml", UriKind.Relative));
                        break;
                    case "PagePatient":
                        MainFrame.Navigate(new Uri("PagePatient.xaml", UriKind.Relative));
                        break;
                    case "ChoosingDoctor":
                        MainFrame.Navigate(new Uri("ChoosingDoctor.xaml", UriKind.Relative));
                        break;
                    case "MedcardPage":
                        MainFrame.Navigate(new Uri("MedcardPage.xaml", UriKind.Relative));
                        break;
                    case "AnalisisPage":
                        MainFrame.Navigate(new Uri("AnalisisPage.xaml", UriKind.Relative));
                        break;
                    case "MedcardResearchPage":
                        MainFrame.Navigate(new Uri("MedcardResearchPage.xaml", UriKind.Relative));
                        break;
                    default:
                        break;
                }
            }
        }

        private void NavigateToPtofile_Click(object sender, RoutedEventArgs e)
        {
            GearFrame.Navigate(new Profile_User());
        }

    }
}