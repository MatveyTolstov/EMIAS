﻿using System;
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
    }
}
