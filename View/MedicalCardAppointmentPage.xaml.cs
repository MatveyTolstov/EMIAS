using EMIAS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace EMIAS.View
{
    public partial class MedicalCardAppointmentPage : Page
    {

        public MedicalCardAppointmentPage(string patientOms)
        {
            InitializeComponent();

        }



        // Обработчик клика на StackPanel
        private async void StackPanel_Click(object sender, RoutedEventArgs e)
        {
        }

    }


}
