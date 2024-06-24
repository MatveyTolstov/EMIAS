using System.Collections.Generic;
using System.Windows;
using EMIAS.ViewModel;

namespace EMIAS.View
{
    public partial class ZapisWindow : Window
    {
        public ZapisWindow()
        {
            InitializeComponent();

            var doctors = new List<Doctor>
            {
                new Doctor { Name = "Иванов Ивар Иванович", Address = "Москва, Профсоюзная улица, д. 111A" },
                new Doctor { Name = "Смирнов Сергей Петрович", Address = "Москва, Каширское ш., д. 62" },
                new Doctor { Name = "Петров Алексей Андреевич", Address = "Москва, Тверская улица, д. 5" },
                new Doctor { Name = "Кузнецов Михаил Иванович", Address = "Москва, Ленина проспект, д. 14" },
                new Doctor { Name = "Соколов Дмитрий Николаевич", Address = "Москва, Новая улица, д. 7" }
            };

            DataContext = new
            {
                Doctors = doctors
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
